using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpCalculator
{
    public partial class simpcalc : Form
    {
        public simpcalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, addsum;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            addsum = n1 + n2;
            textBox3.Text = addsum.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2, subsum;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            subsum = n1 - n2;
            textBox3.Text = subsum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1, n2, multiplysum;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            multiplysum = n1 * n2;
            textBox3.Text = multiplysum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1, n2, divop;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            divop = n1 / n2;
            textBox3.Text = divop.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reportBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportbug popup = new reportbug();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            credit popup = new credit();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }
    }
}
