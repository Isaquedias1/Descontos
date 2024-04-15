using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Descontos
{
    public partial class frmdesconto : Form
    {
        public frmdesconto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double preco, regiao, vf, desconto;

            preco = Convert.ToDouble(txtpreco.Text);
            regiao = Convert.ToDouble(txtregiao.Text);
            if (regiao == 1)
            {
                desconto = preco / 100 * 5;
                vf = preco - desconto;

                txttotal.Text = "R$" + vf.ToString();
                txtdesc.Text = "R$" + desconto.ToString();
                txtr.Text = "Região Norte";
            }
            else if (regiao == 2)
            {
                desconto = preco / 100 * 12;
                vf = preco - desconto;

                txttotal.Text = "R$" + vf.ToString();
                txtdesc.Text = "R$" + desconto.ToString();
                txtr.Text = "Região Nordeste";
            }
            else if (regiao == 3)
            {
                desconto = preco / 100 * 20;
                vf = preco - desconto;

                txttotal.Text = "R$" + vf.ToString();
                txtdesc.Text = "R$" + desconto.ToString();
                txtr.Text = "Região Centro-Oeste";
            }
            else if (regiao == 4)
            {
                desconto = preco / 100 * 7;
                vf = preco - desconto;
                txtdesc.Text = "R$" + desconto.ToString();
                txttotal.Text = "R$" + vf.ToString();
                txtr.Text = "Região Sudeste";
            }
            else if (regiao == 5) {
                desconto = preco / 100 * 15;
                vf = preco - desconto;

                txttotal.Text = "R$" + vf.ToString();
                txtdesc.Text = "R$" + desconto.ToString();
                txtr.Text = "Região Sul";
            }

        }

        private void txtregiao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtproduto.Clear();
            txtr.Clear();
            txtpreco.Clear();
            txtregiao.Clear();
            txtdesc.Clear();
            txttotal.Clear();
            txtproduto.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Visible = true;
        }

        private void frmdesconto_Load(object sender, EventArgs e)
        {

        }

        private void txtregiao_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblregiao_Click(object sender, EventArgs e)
        {

        }
    }
}
