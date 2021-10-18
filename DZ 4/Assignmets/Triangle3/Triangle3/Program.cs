using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle3
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
            Application.Run(new Triangle3Form());
        }
    }

    abstract class Triangle
    {
        protected double _aSide;
        protected double _bSide;

        protected double _Angle;

        public Triangle(double aSide, double bSide, double Angle)
        {
            _aSide = aSide;
            _bSide = bSide;
            _Angle = Angle;
        }

        public virtual double Perimetr()
        {
            return 0;
        }

        public virtual double Square()
        {
            return 0;
        }
        
    }
    

    class RightTriangle: Triangle
    {
        public RightTriangle(double aSide, double bSide):base(aSide, bSide, 90)
        {

        }

        public override double Perimetr()
        {
            double cSide = Math.Sqrt(Math.Pow(_aSide, 2) + Math.Pow(_bSide, 2));
            return _aSide + _bSide + cSide;
        }

        public override double Square()
        {
            return _bSide * _aSide / 2;
        }

    }

    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double aSide, double Angle) : base(aSide, aSide, Angle)
        {

        }

        public override double Perimetr()
        {
            double Angle = (180 - _Angle) / 2;
            double cSide = _aSide * Math.Sin(_Angle * Math.PI / 180) / Math.Sin(Angle * Math.PI / 180);
            return _aSide + _bSide + cSide;
        }

        public override double Square()
        {
            return _bSide * _aSide * Math.Sin(_Angle * Math.PI / 180) / 2;
        }

    }
}
