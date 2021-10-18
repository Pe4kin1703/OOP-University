using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangel_N1
{
    public partial class TriangleForm : Form
    {

        private bool _isEq;
        private Triangle _triangle;
        private EquilateralTriangle _eqTriangle;
        public TriangleForm()
        {
            InitializeComponent();
        }

        private void aSideBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Triangle_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateTriangleButton_Click(object sender, EventArgs e)
        {
           double _a = Convert.ToDouble(aSideBox.Text);
           double _b = Convert.ToDouble(bSideBox.Text);
           double _c = Convert.ToDouble(cSideBox.Text);
           

            if (_a + _b >= _c && _a + _c >= _b && _b + _c >= _a && _a > 0 && _b > 0 && _c > 0)
            {
                if (_a == _b && _b == _c)
                {
                   _eqTriangle = new(_a, _b, _c);                    
                    _isEq = true;
                }
                else
                {
                    _triangle = new(_a, _b, _c);
                    _isEq = false;
                }
                
                MessageBox.Show("+");
            }
            else
            {
                 MessageBox.Show("ERROR: Invalid parametrs to create a triangle");
            }
            //MessageBox.Show("HI!");
        }

        private void bSideBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cSideBoxe_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PerimemtrButton_Click(object sender, EventArgs e)
        {
            if (_isEq)
            {
                PerimetrLabel.Text = Convert.ToString(_eqTriangle.Perimetr());
            }
            else
            {
                PerimetrLabel.Text = Convert.ToString(_triangle.Perimetr());
            }
        }

        private void FindSquareButton_Click(object sender, EventArgs e)
        {
            if (_isEq)
            {
                SquarLabel.Text = Convert.ToString(_eqTriangle.Square());
            }
            else
            {
                SquarLabel.Text = "ERROR: your triangle is not quilateral";
            }
        }

        private void CalculateAnglesButton_Click(object sender, EventArgs e)
        {
            if (_isEq)
            {
                A_AngleTextBox.Text = "60";
                B_AngleTextBox.Text = "60";
                C_AngleTextBox.Text = "60";
            }
            else
            {
                A_AngleTextBox.Text = Convert.ToString(Math.Round(_triangle.CalculateAngels("A") * 180 / Math.PI));
                B_AngleTextBox.Text = Convert.ToString(Math.Round(_triangle.CalculateAngels("B") * 180 / Math.PI));
                C_AngleTextBox.Text = Convert.ToString(Math.Round(_triangle.CalculateAngels("C") * 180 / Math.PI));
            }

        }

        private void A_AngleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeSideValueButton_Click(object sender, EventArgs e)
        {
            string SideName = SideNameTextBox.Text;
            double NewValue = Convert.ToDouble(NewSideValueTextBox.Text);
            _triangle.ChangeSide(SideName, NewValue);
            
        }
    }
}
