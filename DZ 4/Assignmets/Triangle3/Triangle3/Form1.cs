using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle3
{
    public partial class Triangle3Form : Form
    {
        private Triangle _triangle;

        public Triangle3Form()
        {
            InitializeComponent();
        }

        private void RightTriangleLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateRightTriangleButton_Click(object sender, EventArgs e)
        {
            double _a = Convert.ToDouble(ASideRightTriangleTextBox.Text);
            double _b = Convert.ToDouble(BSideRightTriangleTextBox.Text);

            if (_a > 0 && _b > 0) 
            {
                _triangle = new RightTriangle(_a, _b);
                MessageBox.Show("+");
            }
            else
            {
                MessageBox.Show("ERROR: Invalid parametrs to create a triangle");
            }
        }

        private void CreateIsoscelesTriangleButton_Click(object sender, EventArgs e)
        {
            double _a = Convert.ToDouble(SideIsoscelesTriangleTextBox.Text);
            double _angle = Convert.ToDouble(AngleIsoscelesTriangleTextBox.Text);

            if (_a > 0 && _angle > 0 && _angle < 180)
            {
                _triangle = new IsoscelesTriangle(_a, _angle);
                MessageBox.Show("+");
            }
            else
            {
                MessageBox.Show("ERROR: Invalid parametrs to create a triangle");
            }
        }

        private void PerimtrTriangleTypeTextBox_Click(object sender, EventArgs e)
        {
            PerimetrOutputLable.Text = Convert.ToString(_triangle.Perimetr());
        }

        private void CalculateSquareButton_Click(object sender, EventArgs e)
        {
            SquareOutputLable.Text = Convert.ToString(_triangle.Square());
        }
    }


}
