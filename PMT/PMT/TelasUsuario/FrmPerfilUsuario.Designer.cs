namespace PMT.TelasUsuario
{
    partial class FrmPerfilUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblNomeSocial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnCadastrarCandidato = new System.Windows.Forms.Button();
            this.BtnExcluirConta = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblDataNascimento);
            this.panel1.Controls.Add(this.LblEmail);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Controls.Add(this.LblNomeSocial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 163);
            this.panel1.TabIndex = 0;
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Location = new System.Drawing.Point(156, 121);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(35, 13);
            this.LblDataNascimento.TabIndex = 13;
            this.LblDataNascimento.Text = "label2";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(70, 85);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 12;
            this.LblEmail.Text = "label2";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(66, 12);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 11;
            this.LblNome.Text = "label2";
            this.LblNome.Click += new System.EventHandler(this.LblNome_Click);
            // 
            // LblNomeSocial
            // 
            this.LblNomeSocial.AutoSize = true;
            this.LblNomeSocial.Location = new System.Drawing.Point(111, 49);
            this.LblNomeSocial.Name = "LblNomeSocial";
            this.LblNomeSocial.Size = new System.Drawing.Size(35, 13);
            this.LblNomeSocial.TabIndex = 11;
            this.LblNomeSocial.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome Social:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Data de Nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "E-mail:";
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(186, 196);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(92, 30);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnCadastrarCandidato
            // 
            this.BtnCadastrarCandidato.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarCandidato.Location = new System.Drawing.Point(297, 196);
            this.BtnCadastrarCandidato.Name = "BtnCadastrarCandidato";
            this.BtnCadastrarCandidato.Size = new System.Drawing.Size(173, 30);
            this.BtnCadastrarCandidato.TabIndex = 2;
            this.BtnCadastrarCandidato.Text = "Cadastrar como Candidato";
            this.BtnCadastrarCandidato.UseVisualStyleBackColor = true;
            this.BtnCadastrarCandidato.Click += new System.EventHandler(this.BtnCadastrarCandidato_Click);
            // 
            // BtnExcluirConta
            // 
            this.BtnExcluirConta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluirConta.Location = new System.Drawing.Point(489, 196);
            this.BtnExcluirConta.Name = "BtnExcluirConta";
            this.BtnExcluirConta.Size = new System.Drawing.Size(92, 30);
            this.BtnExcluirConta.TabIndex = 3;
            this.BtnExcluirConta.Text = "Excluir Conta";
            this.BtnExcluirConta.UseVisualStyleBackColor = true;
            this.BtnExcluirConta.Click += new System.EventHandler(this.BtnExcluirConta_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(9, 196);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(92, 30);
            this.BtnVoltar.TabIndex = 4;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FrmPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 267);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnExcluirConta);
            this.Controls.Add(this.BtnCadastrarCandidato);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPerfilUsuario";
            this.Text = "FrmPerfilUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblDataNascimento;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblNomeSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnCadastrarCandidato;
        private System.Windows.Forms.Button BtnExcluirConta;
        private System.Windows.Forms.Button BtnVoltar;
    }
}