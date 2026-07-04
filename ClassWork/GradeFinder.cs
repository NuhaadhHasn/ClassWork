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
    public partial class GradeFinder : Form
    {
        public GradeFinder()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
      
            int marks= Convert.ToInt32(txtSub.Text);
            if (marks >= 0 && marks <= 100)
            {
                string grade = "F";
                if (marks >= 70)
                    grade = "A";
                else if (marks >= 60)
                    grade = "B";
                else if (marks >= 50)
                    grade = "C";
                else if (marks >= 40)
                    grade = "S";
                lblRes.Text = grade;
            }
            else
                MessageBox.Show("Please enter a vlaue between 0 - 100");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please enter a vlaue between 0 - 100"); 
                txtSub.Clear();
                txtSub.Focus();
            }
        }
    }
}
