namespace Descontos
{
    partial class frmfatorizacao
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
            this.btnwhile = new System.Windows.Forms.Button();
            this.btndo = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(112, 291);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(89, 27);
            this.btnwhile.TabIndex = 0;
            this.btnwhile.Text = "While";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndo
            // 
            this.btndo.Location = new System.Drawing.Point(247, 291);
            this.btndo.Name = "btndo";
            this.btndo.Size = new System.Drawing.Size(89, 27);
            this.btndo.TabIndex = 1;
            this.btndo.Text = "Do-while";
            this.btndo.UseVisualStyleBackColor = true;
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(377, 291);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(89, 23);
            this.btnfor.TabIndex = 2;
            this.btnfor.Text = "For";
            this.btnfor.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(164, 353);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(89, 25);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(323, 355);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(89, 23);
            this.btnvoltar.TabIndex = 4;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(59, 93);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(92, 13);
            this.lblnum.TabIndex = 5;
            this.lblnum.Text = "Digite um número:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(58, 149);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(58, 13);
            this.lblresult.TabIndex = 6;
            this.lblresult.Text = "Resultado:";
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtnum.Location = new System.Drawing.Point(164, 86);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(130, 20);
            this.txtnum.TabIndex = 8;
            // 
            // txtresult
            // 
            this.txtresult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtresult.Location = new System.Drawing.Point(165, 146);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(129, 23);
            this.txtresult.TabIndex = 9;
            // 
            // frmfatorizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btndo);
            this.Controls.Add(this.btnwhile);
            this.Name = "frmfatorizacao";
            this.Text = "Fatorização";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btndo;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtresult;
    }
}