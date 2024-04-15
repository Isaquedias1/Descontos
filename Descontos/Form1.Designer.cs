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
            this.lblproduto = new System.Windows.Forms.Label();
            this.lblcp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtregiao = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblvldesc = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.lblregiao = new System.Windows.Forms.Label();
            this.txtr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preço total:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(140, 118);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(133, 20);
            this.txtpreco.TabIndex = 8;
            // 
            // txtregiao
            // 
            this.txtregiao.Location = new System.Drawing.Point(140, 78);
            this.txtregiao.Name = "txtregiao";
            this.txtregiao.Size = new System.Drawing.Size(133, 20);
            this.txtregiao.TabIndex = 9;
            this.txtregiao.TextChanged += new System.EventHandler(this.txtregiao_TextChanged_1);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(140, 221);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(133, 20);
            this.txttotal.TabIndex = 10;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(33, 276);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(129, 29);
            this.btncalc.TabIndex = 11;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(189, 276);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(129, 29);
            this.btnlimpar.TabIndex = 12;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(340, 276);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(129, 29);
            this.btnsair.TabIndex = 13;
            this.btnsair.Text = "Voltar ao menu";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblvldesc
            // 
            this.lblvldesc.AutoSize = true;
            this.lblvldesc.Location = new System.Drawing.Point(29, 194);
            this.lblvldesc.Name = "lblvldesc";
            this.lblvldesc.Size = new System.Drawing.Size(93, 13);
            this.lblvldesc.TabIndex = 23;
            this.lblvldesc.Text = "Valor descontado:";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(139, 187);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.ReadOnly = true;
            this.txtdesc.Size = new System.Drawing.Size(133, 20);
            this.txtdesc.TabIndex = 24;
            // 
            // lblregiao
            // 
            this.lblregiao.AutoSize = true;
            this.lblregiao.Location = new System.Drawing.Point(30, 156);
            this.lblregiao.Name = "lblregiao";
            this.lblregiao.Size = new System.Drawing.Size(44, 13);
            this.lblregiao.TabIndex = 3;
            this.lblregiao.Text = "Região:";
            this.lblregiao.Click += new System.EventHandler(this.lblregiao_Click);
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(140, 153);
            this.txtr.Name = "txtr";
            this.txtr.ReadOnly = true;
            this.txtr.Size = new System.Drawing.Size(133, 20);
            this.txtr.TabIndex = 25;
            // 
            // frmdesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.lblvldesc);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtregiao);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblregiao);
            this.Controls.Add(this.lblcp);
            this.Controls.Add(this.lblproduto);
            this.Name = "frmdesconto";
            this.Text = "Desconto";
            this.Load += new System.EventHandler(this.frmdesconto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.Label lblcp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtregiao;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblvldesc;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label lblregiao;
        private System.Windows.Forms.TextBox txtr;
    }
}

