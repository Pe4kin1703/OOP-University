using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangel_N1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TriangleForm());
        }
    }

    class Triangle
    {
        protected double _aSide;
        protected double _bSide;
        protected double _cSide;
        public Triangle(double aSide, double bSide, double cSide)
        {
            _aSide = aSide;
            _bSide = bSide;
            _cSide = cSide;
        }

        public double Perimetr()
        {
            return (_aSide + _bSide + _cSide);
        }

        public double CalculateAngels(string text)
        {
            switch (text) {
                case "A":
                    return Math.Acos((Math.Pow(_bSide, 2) + Math.Pow(_cSide, 2) - Math.Pow(_aSide, 2)) / (2 * _bSide * _cSide)); 
                case "B": 
                    return Math.Acos((Math.Pow(_aSide, 2) + Math.Pow(_cSide, 2) - Math.Pow(_bSide, 2)) / (2 * _aSide * _cSide)); 
                case "C": 
                    return Math.Acos((Math.Pow(_aSide, 2) + Math.Pow(_bSide, 2) - Math.Pow(_cSide, 2)) / (2 * _aSide * _bSide));
                default: 
                    Console.WriteLine("Error: Unknown input");
                return -1;
            }
        }

        public void ChangeSide (string SideName, double NewValue)
        {
            switch (SideName)
            {
                case "a":
                    {
                        _aSide = NewValue;
                        return;
                    }
                case "b":
                    {
                        _bSide = NewValue;
                        return;
                    }
                case "c":
                    {
                        _cSide = NewValue;
                        return;
                    }
                default:
                    {
                        MessageBox.Show("Error: Unknown input");
                        return;
                    }

            }
        }
    }

    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double aSide, double bSide, double cSide) :base(aSide, bSide, cSide)
        {
            
        }

        public double Square()
        {
            return (_aSide * _aSide * Math.Sqrt(3) / 4);
        }
    }
}
