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
    public partial class ArrayWork : Form
    {
        int[] score= new int[5];
        string[] names = new string[5];
        int index = 0;
        public ArrayWork()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (index < score.Length)
            {
                score[index] = Convert.ToInt32(txtScore.Text);
                names[index] = txtName.Text;
                index++;
            }
            else
                MessageBox.Show("Array is full");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string result = "Player\t Name\t score\n";
            int count = 1;
            for (int i = 0; i < score.Length; i++)
            {
                
                result += count+".\t"+names[i]+"\t"+ score[i]+"\n";
                count++;    
            }
            MessageBox.Show(result);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            index = 0;
        }
    }
}
