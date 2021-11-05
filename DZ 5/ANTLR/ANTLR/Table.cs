using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ANTLR
{
    public class Table
    {
        private const int _col = 30;
        private const int _row = 10;
        public int colCount;
        public int rowCount;
        public static List<List<MyCell>> gridTable = new List<List<MyCell>>();
        public Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public Table()
        {
            setTable(_col, _row);
        }

        public void setTable(int col, int row)
        {
            Clear();
            colCount = col;
            rowCount = row;
            for (int i = 0; i < rowCount; i++)
            {
                List<MyCell> newRow = new List<MyCell>();
                for (int j = 0; j < colCount; j++)
                {
                    newRow.Add(new MyCell(i, j));
                    dictionary.Add(newRow.Last().getName(), "");
                }
                gridTable.Add(newRow);
            }
        }

        public void Clear()
        {
            foreach (List<MyCell> list in gridTable)
            {
                list.Clear();
            }
            gridTable.Clear();
            dictionary.Clear();
            rowCount = 0;
            colCount = 0;
        }
    }
}
