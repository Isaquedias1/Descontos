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
    public partial class frmfatorizacao : Form
    {
        public frmfatorizacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i, num, result;

            num = Convert.ToDouble(txtnum.Text);

            i = 0;

            while (num != num * i)

            {
                result = num * num - i;
                i++;
            }
            
        }
    }
}
