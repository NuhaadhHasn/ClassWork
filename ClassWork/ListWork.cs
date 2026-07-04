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
    public partial class ListWork : Form
    {
        List<int> numbers=new List<int>();


        public ListWork()
        {
            InitializeComponent();
        }

        private void btnAB_Click(object sender, EventArgs e)
        {
            int[] num = { 3, 7, 9 };
            numbers.AddRange(num);
            //numbers.Add(3);
            //numbers.Add(7);
            //numbers.Add(9);
            MessageBox.Show(numbers.Capacity.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PrintList(numbers));
        }

        private string PrintList(List<int> list)
        {
            string res = "";
            foreach (int item in list)
            {
                res += item + " , ";
            }
            return res; 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int Count = numbers.Count;
            MessageBox.Show(Count.ToString());
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                int[] num = { 7, 2, 3, 5 };
                numbers.AddRange(num);
                MessageBox.Show("Capacity :" + numbers.Capacity.ToString());
                MessageBox.Show("Number of items" + numbers.Count.ToString());
                numbers.Insert(2, 8);
                MessageBox.Show("Capacity :" + numbers.Capacity.ToString());
                MessageBox.Show("Before remove of 7 :" + PrintList(numbers));
                numbers.Remove(7);
                MessageBox.Show("After remove of 7 :" + PrintList(numbers));
                numbers.RemoveAll(i => i == 3);
                MessageBox.Show("After remove of number 3 :" + PrintList(numbers));
            }
        }


    }
}
