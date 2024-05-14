using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descontos
{
    public partial class frmfatorial : Form
    {
        public frmfatorial()
        {
            InitializeComponent();
        }
        double num, i, x;
        string result;

        private void btndo_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(txtnum.Text);
            i = num;
            do {
                x = num * (i - 1);
                num = x;
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", x.ToString());
                i--;
            } while (i > 1);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();
            txtnum.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Visible = true;
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(txtnum.Text);
            for (i = num; i > 1; i--) {
                x = num * (i - 1);
                num = x;
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", x.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(txtnum.Text);
            i = num;
            while (i > 1) {
                x = num * (i - 1);
                num = x;
                txtresult.Text = String.Concat(txtresult.Text,"\r\n", x.ToString());
                i--;
            }
            
        }
    }
}
