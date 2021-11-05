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

        public MyCell(int c, int r)
        {
            _row = r;
            _column = c;
            _name = BasedSystem26.To26System(c) + Convert.ToString(r);
            _value = "0";
            _expression = "";
        }

        public string Name
        {
            get { return _name;  }
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

        public List<string> Depends
        {
            get { return dependingList; }
            set { dependingList = value; }
        }
    }
}
