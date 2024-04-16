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
    public partial class frmidioma : Form
    {
        public frmidioma()
        {
            InitializeComponent();
        }

        private void btnchecar_Click(object sender, EventArgs e)
        {
            Double codp;

            codp = Convert.ToDouble(txtcdp.Text);

            if (codp == 1)
            {
                txtidioma.Text = "Português Brasileiro";
                txtpais.Text = "Brasil";
            }

            else if (codp == 2)
            {
                txtidioma.Text = "Deustch";
                txtpais.Text = "Germany";
            }

            else if (codp == 3)
            {
                txtidioma.Text = "English";
                txtpais.Text = "England";
            }

            else if (codp == 4)
            {
                txtidioma.Text = "Italiano";
                txtpais.Text = "Italia";
            }

            else if (codp == 5)
            {
                txtidioma.Text = "Español";
                txtpais.Text = "España";
            }

            else if(codp == 6)
            {
                txtidioma.Text = "French";
                txtpais.Text = "France";
            }

            else
            {
                txtidioma.Text = "A lingua nativa da pessoa não pode ser verificada";
                txtpais.Text = "O pais nativo da pessoa não pode ser verificado";
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcdp.Clear();
            txtidioma.Clear();
            txtnome.Clear();
            txtpais.Clear();
            txtnome.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Visible = true;
        }
    }
}
