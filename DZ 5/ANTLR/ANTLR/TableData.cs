using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ANTLR
{
    public class TableData
    {
        private int _columnNumber;
        private int _rowNumber;

        public Dictionary<string, MyCell> cellList = new Dictionary<string, MyCell>(); // map клеток
        public Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public TableData(int col ,int row)
        {
            _columnNumber = col;
            _rowNumber = row;
        }

        public void SetCellsInColumn(int nCol, DataGridView dataGridView1)
        {
            //char colName = (char)(65 + nCol);
            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                string cellName = BasedSystem26.To26System(nCol) + Convert.ToString(i + 1);
                MyCell cell = new MyCell(nCol, i, cellName);

                // cell.Depends.Add("");
                try
                {
                    cellList.Add(cellName, cell);
                }
                catch { }
            }
        }

        public void SetCellsInRow(DataGridView dataGridView1)
        {
            int number = dataGridView1.RowCount;
            for (int i = 0; i<dataGridView1.ColumnCount; ++i)
            {
                string cellName = BasedSystem26.To26System(i) + Convert.ToString(number + 1);
                MyCell cell = new MyCell(i, number, cellName);
                // cell.Depends.Add("");
                try
                {
                    cellList.Add(cellName, cell);
                }
                catch { }
            }
        }

        public void ChangeCellsAndPointers(DataGridView dataGridView1, string cellName, string expression)
        {
            cellList[cellName].DeletePointers();
            cellList[cellName].Exp = expression;
            cellList[cellName].new_referencesFromThis.Clear();

            if (expression != "")
            {
                if (expression[0] != '=')
                {
                    cellList[cellName].Value = expression;
                    dictionary[cellName] = expression;
                    foreach (MyCell cell in cellList[cellName].pointersToThis)
                    {
                        RefreshCellAndPointers(cell, dataGridView1);
                    }
                    return;
                }
            }

            string new_expression = ConvertReferences(cellName, expression);
            if (new_expression != "")
            {
                new_expression = new_expression.Remove(0, 1);
            }

            if (!cellList[cellName].CheckLoop(cellList[cellName].new_referencesFromThis))
            {
                MessageBox.Show("There is a loop! Change the expression.");
                cellList[cellName].Exp = "";
                cellList[cellName].Value = "0";
                dataGridView1.CurrentCell.Value = "0";
                return;
            }

            cellList[cellName].AddPointers();
            string Value = Calculate(new_expression);
            if (Value == "Error")
            {
                MessageBox.Show("Error in cell " + cellName);
                cellList[cellName].Exp = "";
                cellList[cellName].Value = "0";
                dataGridView1.CurrentCell.Value = "0";
                return;
            }

            cellList[cellName].Value = Value;
            dictionary[cellName] = Value;
            foreach (MyCell cell in cellList[cellName].pointersToThis)
                RefreshCellAndPointers(cell, dataGridView1);
        }

        public bool RefreshCellAndPointers(MyCell cell, DataGridView dataGridView1)
        {
            cell.new_referencesFromThis.Clear();
            string new_expression = ConvertReferences(cell.Name, cell.Exp);
            new_expression = new_expression.Remove(0, 1);
            string Value = Calculate(new_expression);

            if (Value == "Error")
            {
                MessageBox.Show("Error in cell " + cell.Name);
                cell.Exp = "";
                cell.Value = "0";
                dataGridView1.CurrentCell.Value = "0";
                return false;
            }
            //MyCell newCell = (MyCell)(dataGridView1.CurrentCell);

            cellList[cell.Name].Value = Value;
            dictionary[cell.Name] = Value;
            dataGridView1[cell.Column, cell.Row].Value = Value;

            foreach (MyCell point in cell.pointersToThis)
            {
                if (!RefreshCellAndPointers(point, dataGridView1))
                    return false;
            }

            return true;
        }
        
        public string ConvertReferences(string cellName, string expression)
        {
            string cellPattern = @"[A-Z]+[0-9]+";
            Regex regex = new Regex(cellPattern, RegexOptions.IgnoreCase);
           // Index nums;

            foreach (Match match in regex.Matches(expression))
            {
                if (dictionary.ContainsKey(match.Value))
                {
                   // nums = NumberConverter.From26System(match.Value);
                    cellList[cellName].new_referencesFromThis.Add(cellList[match.Value]);
                }
            }
            MatchEvaluator evaluator = new MatchEvaluator(referenceToValue);
            string new_expression = regex.Replace(expression, evaluator);
          //   cellList[cellName].Exp = new_expression;
            return new_expression;
        }

        public string referenceToValue(Match m)
        {
            if (dictionary.ContainsKey(m.Value))
                if (dictionary[m.Value] == "")
                    return "0";
                else
                    return dictionary[m.Value];
            return m.Value;
        }

        public string Calculate(string expression)
        {
            string res = null;
            try
            {
                res = Convert.ToString(ANTLR.Calculator.Evaluate(expression));
                if (res == "∞")
                {
                    res = "Division by zero error";
                }
                return res;
            }
            catch
            {
                return "Error";
            }
        }

    }
}
