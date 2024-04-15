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
    }
}
