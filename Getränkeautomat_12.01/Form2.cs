using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Getränkeautomat_12._01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBoxGeldbetrag.Multiline = true;
            TextBoxGeldbetrag.MinimumSize = new Size(150, 24);
            TextBoxGeldbetrag.Size = new Size(150, 24);
            TextBoxGeldbetrag.Multiline = false;
        }
        public static double Addieren(double a, double b)
        {
            return a + b;
        }

        private void Geld50Ct_Click(object sender, EventArgs e)
        {
            TextBoxGeldbetrag.Text = ("0.50");
        }

        private void Geld200ct_Click(object sender, EventArgs e)
        {
            TextBoxGeldbetrag.Text = ("2.00");
        }

        private void Geld100Ct_Click(object sender, EventArgs e)
        {
            TextBoxGeldbetrag.Text = ("1.00");
        }

        private void Geld20Ct_Click(object sender, EventArgs e)
        {
            TextBoxGeldbetrag.Text = ("0.20");
        }

        private void Geld10Ct_Click(object sender, EventArgs e)
        {
            TextBoxGeldbetrag.Text = ("0.10");
        }

        private void bGeldauswurf_Click(object sender, EventArgs e)
        {
            TextBoxGeldbetrag.Clear();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
