using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork
{
    public partial class MethodWork : Form
    {
        public MethodWork()
        {
            InitializeComponent();
        }

        private decimal Add(decimal num1, decimal num2)
        { 
            return num1 + num2;
        }
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(txtNum1.Text);
            decimal num2 = Convert.ToDecimal(txtNum2.Text);
            MessageBox.Show(Add(num1,num2).ToString());

            //MessageBox.Show(Add(Convert.ToDecimal(txtNum1.Text),
            //Convert.ToDecimal(txtNum2.Text)).ToString());
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(txtNum1.Text);
            decimal num2 = Convert.ToDecimal(txtNum2.Text);
            decimal num3 = Convert.ToDecimal(txtNum3.Text);
            decimal result = Add(Add(num1, num2),num3);
            MessageBox.Show(result.ToString());
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                            Add(
                                Add( 
                                    Add(Convert.ToDecimal(txtNum1.Text),
                                        Convert.ToDecimal(txtNum2.Text)),
                                        Convert.ToDecimal(txtNum3.Text)),
                                        Convert.ToDecimal(txtNum4.Text)).ToString());
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(txtNum1.Text);
            decimal num2 = Convert.ToDecimal(txtNum2.Text);
            MessageBox.Show(Average(num1,num2).ToString());
        }

        private decimal Average(decimal num1, decimal num2)
        {
            return Add(num1, num2) / 2;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
