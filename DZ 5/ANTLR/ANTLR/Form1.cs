using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ANTLR
{
    public partial class Form1 : Form
    {
        private int _defaultColumnNumber = 3;
        private int _defaultRowNumber = 3;
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

            for (int i = 0; i < rows; ++i)
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
            excelColumn.HeaderText = BasedSystem26.To26System(dataGridView1.ColumnCount);
            excelColumn.Name = BasedSystem26.To26System(dataGridView1.ColumnCount);

            dataGridView1.Columns.Add(excelColumn);

            _table.SetCellsInColumn(dataGridView1.ColumnCount-1, dataGridView1);

            _table.ColCount++;
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            SetRowNum(dataGridView1);

            _table.SetCellsInRow(dataGridView1);

            _table.RowCount++;
        }

        private void ExpCalculate()
        {
            int currRow = dataGridView1.CurrentCell.RowIndex;
            int currCol = dataGridView1.CurrentCell.ColumnIndex;
            string cellName = BasedSystem26.To26System(currCol) + (currRow + 1).ToString();
            if (dataGridView1.CurrentCell.Value == null)
            {
                _table.cellList[cellName].Clear();
                return;
            } 
            string expression = (dataGridView1.CurrentCell.Value).ToString();
            
            _table.ChangeCellsAndPointers(dataGridView1, cellName, expression);
            dataGridView1.CurrentCell.Value = _table.cellList[cellName].Value;
            textBox1.Text = _table.cellList[cellName].Exp;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            ExpCalculate();
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
                _table.Save(sw);
                sw.Close();
                fs.Close();
            }
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            if (!_table.DeleteRow(dataGridView1))
                return;
            dataGridView1.Rows.RemoveAt(_table.RowCount);
            SetRowNum(dataGridView1);
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
            if (!_table.DeleteColumn(dataGridView1))
                return;
            dataGridView1.Columns.RemoveAt(_table.ColCount);
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Our program has next operations:\n\t" +
                " 1. '+, -, *, /'\n\t " +
                "2. '^'\n\t " +
                "3. 'max(a,b), min(a,b)'",
                "Help Menu");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            int col = dataGridView1.CurrentCell.ColumnIndex;
            string cellName = BasedSystem26.To26System(col) + (row + 1).ToString();
            textBox1.Text = _table.cellList[cellName].Exp;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TableFile|*.txt";
            openFileDialog.Title = "Open Table File";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            StreamReader sr = new StreamReader(openFileDialog.FileName);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            int row; int column;
            Int32.TryParse(sr.ReadLine(), out row);
            Int32.TryParse(sr.ReadLine(), out column);
            CreateDataGrid(row, column);
            _table.Open(row, column, sr, dataGridView1);
            sr.Close();
        }

    }
}

