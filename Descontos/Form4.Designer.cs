namespace Descontos
{
    partial class frmfatorial
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
            this.lblnum = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnwhile = new System.Windows.Forms.Button();
            this.btndo = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(31, 99);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(138, 20);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "Digite um número:";
            this.lblnum.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(31, 167);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(86, 20);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "Resultado:";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(175, 99);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(158, 20);
            this.txtnum.TabIndex = 2;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(175, 167);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(158, 78);
            this.txtresult.TabIndex = 3;
            // 
            // btnwhile
            // 
            this.btnwhile.BackColor = System.Drawing.Color.White;
            this.btnwhile.Location = new System.Drawing.Point(35, 273);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(118, 45);
            this.btnwhile.TabIndex = 4;
            this.btnwhile.Text = "Calcular com while";
            this.btnwhile.UseVisualStyleBackColor = false;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btndo
            // 
            this.btndo.BackColor = System.Drawing.Color.White;
            this.btndo.Location = new System.Drawing.Point(175, 273);
            this.btndo.Name = "btndo";
            this.btndo.Size = new System.Drawing.Size(118, 45);
            this.btndo.TabIndex = 5;
            this.btndo.Text = "Calcular com do";
            this.btndo.UseVisualStyleBackColor = false;
            this.btndo.Click += new System.EventHandler(this.btndo_Click);
            // 
            // btnfor
            // 
            this.btnfor.BackColor = System.Drawing.Color.White;
            this.btnfor.Location = new System.Drawing.Point(324, 273);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(118, 45);
            this.btnfor.TabIndex = 6;
            this.btnfor.Text = "Calcular com for";
            this.btnfor.UseVisualStyleBackColor = false;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.White;
            this.btnlimpar.Location = new System.Drawing.Point(35, 370);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(118, 45);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.White;
            this.btnvoltar.Location = new System.Drawing.Point(324, 370);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(118, 45);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar\r\n";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmfatorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btndo);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblnum);
            this.Name = "frmfatorial";
            this.Text = "Fatoração";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btndo;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}