using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geom_Figure_2
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
            Application.Run(new FiguresForm());
        }
    }

    abstract class Figure
    {
        virtual public double Perimetr()
        {
            return 0;
        }

        virtual public double Square()
        {
            return 0;
        }
    }

    class Triangle : Figure
    {
        private double _aSide;
        private double _bSide;
        private double _cSide;

        public Triangle(double aSide, double bSide, double cSide)
        {
            _aSide = aSide;
            _bSide = bSide;
            _cSide = cSide;
        }

        public override double Perimetr()
        {
            //base.Perimetr();
            return (_aSide + _bSide + _cSide);
        }

        public override double Square()
        {
            double halfPerimetr = Perimetr() / 2;
            return (Math.Sqrt(halfPerimetr * (halfPerimetr - _aSide) * (halfPerimetr - _bSide) * (halfPerimetr - _cSide)));
        }

    }

    class Circle: Figure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double Perimetr()
        {
            return 2 * Math.PI * _radius;
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(_radius , 2);
        }
    }

    class Quadrate : Figure
    {
        protected double _Side;

        public Quadrate(double Side)
        {
            _Side = Side;
        }

        public override double Perimetr()
        {
            return _Side * 4;
        }

        public override double Square()
        {
            return Math.Pow(_Side, 2);
        }
    }

    class Rhombus: Quadrate
    {
        private double _Angle;
        public Rhombus(double Side, double Angle):base (Side)
        {
            _Angle = Angle;
        }

        public override double Square()
        {
            return Math.Pow(_Side,2) * Math.Sin(_Angle * Math.PI / 180);
        }


    }
}
