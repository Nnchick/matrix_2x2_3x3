
using System;
using System.Windows.Forms;

namespace _5566
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve2x2_Click_1(object sender, EventArgs e)
        {
            try
            {
                double a1 = Convert.ToDouble(txtB1.Text);
                double b1 = Convert.ToDouble(txtA2.Text);
                double c1 = Convert.ToDouble(txtC1.Text);
                double a2 = Convert.ToDouble(txtA2.Text);
                double b2 = Convert.ToDouble(txtB2.Text);
                double c2 = Convert.ToDouble(txtC2.Text);

                double det = a1 * b2 - a2 * b1;
                if (det == 0)
                {
                    MessageBox.Show("Система не имеет единственного решения.");
                    return;
                }

                double x = (c1 * b2 - c2 * b1) / det;
                double y = (a1 * c2 - a2 * c1) / det;

                lblResult2x2.Text = $"x = {x}, y = {y}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }

        private void btnSolve3x3_Click_1(object sender, EventArgs e)
        {
            try
            {
                double a1 = Convert.ToDouble(txtA1_3x3.Text);
                double b1 = Convert.ToDouble(txtB1_3x3.Text);
                double c1 = Convert.ToDouble(txtC1_3x3.Text);
                double d1 = Convert.ToDouble(txtD1_3x3.Text);

                double a2 = Convert.ToDouble(txtA2_3x3.Text);
                double b2 = Convert.ToDouble(txtB2_3x3.Text);
                double c2 = Convert.ToDouble(txtC2_3x3.Text);
                double d2 = Convert.ToDouble(txtD2_3x3.Text);

                double a3 = Convert.ToDouble(txtA3_3x3.Text);
                double b3 = Convert.ToDouble(txtB3_3x3.Text);
                double c3 = Convert.ToDouble(txtC3_3x3.Text);
                double d3 = Convert.ToDouble(txtD3_3x3.Text);

                double det = a1 * (b2 * c3 - c2 * b3) - b1 * (a2 * c3 - c2 * a3) + c1 * (a2 * b3 - b2 * a3);

                if (det == 0)
                {
                    MessageBox.Show("Система не имеет единственного решения.");
                    return;
                }

                double x = (d1 * (b2 * c3 - c2 * b3) - b1 * (d2 * c3 - c2 * d3) + c1 * (d2 * b3 - b2 * d3)) / det;
                double y = (a1 * (d2 * c3 - c2 * d3) - d1 * (a2 * c3 - c2 * a3) + c1 * (a2 * d3 - d2 * a3)) / det;
                double z = (a1 * (b2 * d3 - d2 * b3) - b1 * (a2 * d3 - d2 * a3) + d1 * (a2 * b3 - b2 * a3)) / det;

                lblResult3x3.Text = $"x = {x}, y = {y}, z = {z}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}  
        