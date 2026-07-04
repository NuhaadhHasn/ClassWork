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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gradeFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradeFinder gradeFinder = new GradeFinder();
            gradeFinder.MdiParent = this;
            gradeFinder.Show();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventWork eventWork = new EventWork();
            eventWork.MdiParent = this;
            eventWork.Show();
        }

        private void methodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodWork methodWork = new MethodWork();
            methodWork.MdiParent = this;
            methodWork.Show();
        }

        private void arrayWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayWork arrayWork = new ArrayWork();
            arrayWork.MdiParent = this;
            arrayWork.Show();
        }

        private void listWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListWork listWork = new ListWork();
            listWork.MdiParent = this;
            listWork.Show();
        }
    }
}
