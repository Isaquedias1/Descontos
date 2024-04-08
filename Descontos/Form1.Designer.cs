namespace Descontos
{
    partial class frmdesconto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblproduto = new System.Windows.Forms.Label();
            this.lblcp = new System.Windows.Forms.Label();
            this.lblregiao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtregiao = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblnordeste = new System.Windows.Forms.Label();
            this.lblnorte = new System.Windows.Forms.Label();
            this.lblcentro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblreg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblproduto
            // 
            this.lblproduto.AutoSize = true;
            this.lblproduto.Location = new System.Drawing.Point(30, 41);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(92, 13);
            this.lblproduto.TabIndex = 1;
            this.lblproduto.Text = "Nome do produto:";
            // 
            // lblcp
            // 
            this.lblcp.AutoSize = true;
            this.lblcp.Location = new System.Drawing.Point(30, 81);
            this.lblcp.Name = "lblcp";
            this.lblcp.Size = new System.Drawing.Size(97, 13);
            this.lblcp.TabIndex = 2;
            this.lblcp.Text = "Código do produto:";
            // 
            // lblregiao
            // 
            this.lblregiao.AutoSize = true;
            this.lblregiao.Location = new System.Drawing.Point(30, 156);
            this.lblregiao.Name = "lblregiao";
            this.lblregiao.Size = new System.Drawing.Size(44, 13);
            this.lblregiao.TabIndex = 3;
            this.lblregiao.Text = "Região:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preço total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(140, 38);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(133, 20);
            this.txtproduto.TabIndex = 6;
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(140, 78);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(133, 20);
            this.txtcod.TabIndex = 7;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(140, 118);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(133, 20);
            this.txtpreco.TabIndex = 8;
            // 
            // txtregiao
            // 
            this.txtregiao.Location = new System.Drawing.Point(140, 153);
            this.txtregiao.Name = "txtregiao";
            this.txtregiao.Size = new System.Drawing.Size(133, 20);
            this.txtregiao.TabIndex = 9;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(140, 188);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(133, 20);
            this.txttotal.TabIndex = 10;
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(33, 249);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(129, 29);
            this.btncalc.TabIndex = 11;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(188, 249);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(129, 29);
            this.btnlimpar.TabIndex = 12;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(341, 249);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(129, 29);
            this.btnsair.TabIndex = 13;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblnordeste
            // 
            this.lblnordeste.AutoSize = true;
            this.lblnordeste.Location = new System.Drawing.Point(564, 353);
            this.lblnordeste.Name = "lblnordeste";
            this.lblnordeste.Size = new System.Drawing.Size(123, 13);
            this.lblnordeste.TabIndex = 16;
            this.lblnordeste.Text = "Nordeste: 12% número 2";
            // 
            // lblnorte
            // 
            this.lblnorte.AutoSize = true;
            this.lblnorte.Location = new System.Drawing.Point(564, 329);
            this.lblnorte.Name = "lblnorte";
            this.lblnorte.Size = new System.Drawing.Size(103, 13);
            this.lblnorte.TabIndex = 17;
            this.lblnorte.Text = "Norte: 5% número  1";
            // 
            // lblcentro
            // 
            this.lblcentro.AutoSize = true;
            this.lblcentro.Location = new System.Drawing.Point(564, 379);
            this.lblcentro.Name = "lblcentro";
            this.lblcentro.Size = new System.Drawing.Size(140, 13);
            this.lblcentro.TabIndex = 18;
            this.lblcentro.Text = "Centro-oeste: 20% número 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sudeste: 7% número 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Sul: 15% número 5";
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.Location = new System.Drawing.Point(564, 307);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(105, 13);
            this.lblreg.TabIndex = 21;
            this.lblreg.Text = "Descontos de região";
            // 
            // frmdesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblreg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblcentro);
            this.Controls.Add(this.lblnorte);
            this.Controls.Add(this.lblnordeste);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtregiao);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblregiao);
            this.Controls.Add(this.lblcp);
            this.Controls.Add(this.lblproduto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmdesconto";
            this.Text = "Desconto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.Label lblcp;
        private System.Windows.Forms.Label lblregiao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtregiao;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblnordeste;
        private System.Windows.Forms.Label lblnorte;
        private System.Windows.Forms.Label lblcentro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblreg;
    }
}

