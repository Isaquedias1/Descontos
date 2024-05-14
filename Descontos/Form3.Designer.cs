namespace Descontos
{
    partial class frmidioma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcdp = new System.Windows.Forms.Label();
            this.lblidioma = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcdp = new System.Windows.Forms.TextBox();
            this.txtidioma = new System.Windows.Forms.TextBox();
            this.lblpais = new System.Windows.Forms.Label();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.btnchecar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(69, 39);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            // 
            // lblcdp
            // 
            this.lblcdp.AutoSize = true;
            this.lblcdp.Location = new System.Drawing.Point(25, 75);
            this.lblcdp.Name = "lblcdp";
            this.lblcdp.Size = new System.Drawing.Size(82, 13);
            this.lblcdp.TabIndex = 1;
            this.lblcdp.Text = "Código do país:";
            // 
            // lblidioma
            // 
            this.lblidioma.AutoSize = true;
            this.lblidioma.Location = new System.Drawing.Point(34, 115);
            this.lblidioma.Name = "lblidioma";
            this.lblidioma.Size = new System.Drawing.Size(73, 13);
            this.lblidioma.TabIndex = 2;
            this.lblidioma.Text = "Idioma nativo:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(141, 36);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(192, 20);
            this.txtnome.TabIndex = 3;
            // 
            // txtcdp
            // 
            this.txtcdp.Location = new System.Drawing.Point(141, 72);
            this.txtcdp.Name = "txtcdp";
            this.txtcdp.Size = new System.Drawing.Size(192, 20);
            this.txtcdp.TabIndex = 4;
            // 
            // txtidioma
            // 
            this.txtidioma.Location = new System.Drawing.Point(141, 112);
            this.txtidioma.Name = "txtidioma";
            this.txtidioma.ReadOnly = true;
            this.txtidioma.Size = new System.Drawing.Size(255, 20);
            this.txtidioma.TabIndex = 5;
            // 
            // lblpais
            // 
            this.lblpais.AutoSize = true;
            this.lblpais.Location = new System.Drawing.Point(75, 157);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(32, 13);
            this.lblpais.TabIndex = 6;
            this.lblpais.Text = "País:";
            // 
            // txtpais
            // 
            this.txtpais.Location = new System.Drawing.Point(141, 154);
            this.txtpais.Name = "txtpais";
            this.txtpais.ReadOnly = true;
            this.txtpais.Size = new System.Drawing.Size(255, 20);
            this.txtpais.TabIndex = 7;
            // 
            // btnchecar
            // 
            this.btnchecar.Location = new System.Drawing.Point(28, 218);
            this.btnchecar.Name = "btnchecar";
            this.btnchecar.Size = new System.Drawing.Size(132, 35);
            this.btnchecar.TabIndex = 8;
            this.btnchecar.Text = "Checar";
            this.btnchecar.UseVisualStyleBackColor = true;
            this.btnchecar.Click += new System.EventHandler(this.btnchecar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(352, 218);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(132, 35);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(189, 218);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(132, 35);
            this.btnlimpar.TabIndex = 10;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // frmidioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnchecar);
            this.Controls.Add(this.txtpais);
            this.Controls.Add(this.lblpais);
            this.Controls.Add(this.txtidioma);
            this.Controls.Add(this.txtcdp);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblidioma);
            this.Controls.Add(this.lblcdp);
            this.Controls.Add(this.lblnome);
            this.Name = "frmidioma";
            this.Text = "Cidadania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcdp;
        private System.Windows.Forms.Label lblidioma;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcdp;
        private System.Windows.Forms.TextBox txtidioma;
        private System.Windows.Forms.Label lblpais;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.Button btnchecar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
    }
}