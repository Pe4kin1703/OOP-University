using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geom_Figure_2
{
    public partial class FiguresForm : Form
    {
        private Dictionary<string, Figure> _figure;

        public FiguresForm()
        {
            _figure = new();
            InitializeComponent();
        }

        private void CircleLabel_Click(object sender, EventArgs e)
        {

        }

        private void TriangleASideTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculatePerimetrButton_Click(object sender, EventArgs e)
        {
            string figure = WhichFigurePerimetrTextBox.Text;
            switch (figure)
            {
                case "Triangle":
                    {
                        FigurePerimetrLable.Text = Convert.ToString(_figure["Triangle"].Perimetr());
                        break;
                    }
                case "Circle":
                    {
                        FigurePerimetrLable.Text = Convert.ToString(_figure["Circle"].Perimetr());
                        break;
                    }
                case "Quadrate":
                    {
                        FigurePerimetrLable.Text = Convert.ToString(_figure["Quadrate"].Perimetr());
                        break;
                    }
                default:
                    {
                        FigureSquareLable.Text = "ERROR: invalid figure name";
                        break;
                    }


            }
        }

        private void CreateTriangleButton_Click(object sender, EventArgs e)
        {
            double _a = Convert.ToDouble(TriangleASideTextBox.Text);
            double _b = Convert.ToDouble(TriangleBSideTextBox.Text);
            double _c = Convert.ToDouble(TriangleCSideTextBox.Text);


            if (_a + _b >= _c && _a + _c >= _b && _b + _c >= _a && _a > 0 && _b > 0 && _c > 0)
            {
                _figure.Add("Triangle", new Triangle(_a, _b, _c));                
                MessageBox.Show("+");
            }
            else
            {
                MessageBox.Show("ERROR: Invalid parametrs to create a triangle");
            }
        }

        private void CalculateSquareButton_Click(object sender, EventArgs e)
        {
            string figure = WhichFigureSquareTextBox.Text;
            switch (figure)
            {
                case "Triangle":
                    {
                        FigureSquareLable.Text = Convert.ToString(_figure["Triangle"].Square());
                        break;
                    }
                case "Circle":
                    {
                        FigureSquareLable.Text = Convert.ToString(_figure["Circle"].Square());
                        break;
                    }
                case "Quadrate":
                    {
                        FigureSquareLable.Text = Convert.ToString(_figure["Quadrate"].Square());
                        break;
                    }
                case "Rhombus":
                    {
                        FigureSquareLable.Text =Convert.ToString(_figure["Rhombus"].Square());
                        break;
                    }
                default:
                    {
                        FigureSquareLable.Text = "ERROR: invalid figure name";
                        break;
                    }



            }
        }

        private void CreateCircleButton_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(CircleRadiusTextBox.Text);
            if (radius > 0)
            {
                _figure.Add("Circle", new Circle(radius));
                MessageBox.Show("+");
            }
            else
            {
                MessageBox.Show("ERROR: Invalid parametrs to create a Circle");
            }
        }

        private void CreateSquareButton_Click(object sender, EventArgs e)
        {
            double side = Convert.ToDouble(SquareASideTextBox.Text);
            if (side > 0)
            {
                _figure.Add("Quadrate", new Quadrate(side));
                MessageBox.Show("+");
            }
            else
            {
                MessageBox.Show("ERROR: Invalid parametrs to create a Quadrate");
            }
        }

        private void CreateRhombusButton_Click(object sender, EventArgs e)
        {
            double side = Convert.ToDouble(RhombusASideTextBox.Text);
            double angle = Convert.ToDouble(RhombusAAngleTextBox.Text);
            if (side > 0)
            {
                _figure.Add("Rhombus", new Rhombus(side, angle));
                MessageBox.Show("+");
            }
            else
            {
                MessageBox.Show("ERROR: Invalid parametrs to create a Rhombus");
            }
        }
    }
}
