using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;


namespace ANTLR
{
    public partial class Form1 : Form
    {
        private int _defaultColumnNumber = 30;
        private int _defaultRowNumber = 10;
        private TableData _table;
        public Form1()
        {
            InitializeComponent();
            _table = new TableData(_defaultColumnNumber, _defaultRowNumber);

            CreateDataGrid(_defaultRowNumber, _defaultColumnNumber);
            WindowState = FormWindowState.Maximized;
        }

        private void CreateDataGrid(int rows, int column)
        {
            for (int i = 0; i < column; ++i)
            {
                DataGridViewColumn excelColumn = new DataGridViewColumn();
                MyCell cell = new MyCell();
                excelColumn.CellTemplate = cell;
                excelColumn.HeaderText = BasedSystem26.To26System(i);
                excelColumn.Name = BasedSystem26.To26System(i);

                dataGridView1.Columns.Add(excelColumn);

            }

            for (int i = 0; i < rows - 1; ++i)
            {
                dataGridView1.Rows.Add();
            }

            for (int i = 0; i<dataGridView1.ColumnCount; ++i)
            {
                _table.SetCellsInColumn(i, dataGridView1);
            }

            SetRowNum(dataGridView1);

            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);            
        }


        public void SetRowNum (DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.RowCount; ++i)
            {
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }
        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            DataGridViewColumn excelColumn = new DataGridViewColumn();
            MyCell cell = new MyCell();
            excelColumn.CellTemplate = cell;
            excelColumn.HeaderText = ((char)(dataGridView1.ColumnCount + 65)).ToString();
            excelColumn.Name = ((char)(dataGridView1.ColumnCount + 65)).ToString();

            dataGridView1.Columns.Add(excelColumn);

            _table.SetCellsInColumn(dataGridView1.ColumnCount - 1 + 65, dataGridView1);
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            SetRowNum(dataGridView1);
            _table.SetCellsInRow(dataGridView1);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int currRow = dataGridView1.CurrentCell.RowIndex;
            int currCol = dataGridView1.CurrentCell.ColumnIndex;
            string cellName = BasedSystem26.To26System(currCol) + (currRow + 1).ToString();

            string expression = (dataGridView1.CurrentCell.Value).ToString();

            _table.ChangeCellsAndPointers(dataGridView1, cellName, expression);
            dataGridView1.CurrentCell.Value = _table.cellList[cellName].Value;

            /*_table.cellList[cellName].Exp = (dataGridView1.CurrentCell.Value).ToString();
            _table.cellList[cellName].Value = Calculator.Evaluate(_table.cellList[cellName].Exp).ToString();
            dataGridView1.CurrentCell.Value = _table.cellList[cellName].Value;*/
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TableFile|*.txt";
            saveFileDialog.Title = "Save table file";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialog.OpenFile();
                StreamWriter sw = new StreamWriter(fs);
               // cellList.WriteXml(sw);
               // Stream
            }
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView1.RowCount - 1;
                for (int i = 0; i < dataGridView1.ColumnCount; ++i)
                {
                    string cellName = (char)(i + 65) + (row + 1).ToString();
                    _table.cellList.Remove(cellName);
                }
                dataGridView1.Rows.RemoveAt(row-1);
                dataGridView1.Refresh();
                SetRowNum(dataGridView1);
               // ClearRow(row + 1);
            }
            catch { }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите закрыть?",
                "Внимание",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }


        }

        private void DeleteColumnButton_Click(object sender, EventArgs e)
        {
            try
            {
                int col = dataGridView1.ColumnCount - 1;
                for (int i = 0; i < dataGridView1.RowCount; ++i)
                {
                    string cellName = (char)(i + 65) + (col + 1).ToString();
                    _table.cellList.Remove(cellName);
                }
                dataGridView1.Columns.RemoveAt(col);
                dataGridView1.Refresh();
            }
            catch { }
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Our program has next operations:\n\t" +
                " 1. '+, -, *, /'\n\t " +
                "2. '^'\n\t " +
                "3. 'max(a,b), min(a,b)'",
                "Help Menu");
        }

        /* private void DeleteRowButton_Click(object sender, EventArgs e)
         {
             dataGridView1.Columns.Remove();
         }*/
    }
}
