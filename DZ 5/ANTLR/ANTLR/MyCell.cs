using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANTLR
{
   public class MyCell: DataGridViewTextBoxCell
    {
        private string _name;
        private string _value;
        private string _expression;
        private int _row;
        private int _column;
        //  static private List<string> dependingList; // список клеток, на которые ссылается данная клетка

        public List<MyCell> pointersToThis = new List<MyCell>();
        public List<MyCell> referencesFromThis = new List<MyCell>();
        public List<MyCell> new_referencesFromThis = new List<MyCell>();

        public MyCell()
        {

        }
        public MyCell(int c, int r, string cellName)
        {
            _row = r;
            _column = c;
            _name = cellName;
            _value = "0";
            _expression = "";
        }

        public int Column
        {
            get { return _column; }
        }

        public int Row
        {
            get { return _row; }
        }

        public string Name
        {
            get { return _name;  }
            set { _name = value; }
        }

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public string Exp
        {
            get { return _expression; }
            set { _expression = value; }
        }

        /* public List<string> Depends
         {
             get { return dependingList; }
             set { dependingList = value; }
         }*/

        public void DeletePointers()
        {
            if (referencesFromThis != null)
            {
                foreach(MyCell cell in referencesFromThis)
                {
                    cell.pointersToThis.Remove(this);
                }
                referencesFromThis = null;
            }
        }

        public bool CheckLoop(List<MyCell> list)
        {
            foreach (MyCell cell in list)
            {
                if (cell.Name == Name)
                    return false;
            }
            foreach (MyCell point in pointersToThis)
            {
                foreach (MyCell cell in list)
                {
                    if (cell.Name == point.Name)
                    {
                        return false;
                    }
                }
                if (!point.CheckLoop(list)) return false;
            }
            return true;
        }

        public void AddPointers()
        {
            foreach (MyCell point in new_referencesFromThis)
            {
                point.pointersToThis.Add(this);
            }
            referencesFromThis = new_referencesFromThis;
        }
    }
}
