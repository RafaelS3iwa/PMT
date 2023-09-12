namespace PMT
{
    partial class FrmEditarPerfilUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblNomeSocial = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(77, 39);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "label2";
            // 
            // LblNomeSocial
            // 
            this.LblNomeSocial.AutoSize = true;
            this.LblNomeSocial.Location = new System.Drawing.Point(105, 89);
            this.LblNomeSocial.Name = "LblNomeSocial";
            this.LblNomeSocial.Size = new System.Drawing.Size(35, 13);
            this.LblNomeSocial.TabIndex = 3;
            this.LblNomeSocial.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome Social:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(77, 139);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 5;
            this.LblEmail.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "E-mail:";
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Location = new System.Drawing.Point(146, 191);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(35, 13);
            this.LblDataNascimento.TabIndex = 7;
            this.LblDataNascimento.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Data de Nascimento:";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(44, 296);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 8;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FrmEditarPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 558);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.LblDataNascimento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblNomeSocial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditarPerfilUsuario";
            this.Text = "EditarPerfilUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblNomeSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblDataNascimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnVoltar;
    }
}