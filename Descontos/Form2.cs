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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void descontosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdesconto desconto = new frmdesconto();
            desconto.Visible = true;
        }

        private void cidadaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmidioma idioma = new frmidioma();
            idioma.Visible = true;
        }

<<<<<<< HEAD
        private void fatoraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmfatorial fatorial = new frmfatorial();
            fatorial.Visible = true;
=======
        private void atividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

>>>>>>> caf6e1645abb5e4a696f4d399cfd98eb4601b35e
        }
    }
}
