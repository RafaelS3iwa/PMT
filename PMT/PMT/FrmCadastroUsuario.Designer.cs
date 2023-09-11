namespace PMT
{
    partial class FrmCadastroUsuario
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
            this.panelCadastroUsuario = new System.Windows.Forms.Panel();
            this.LlblLogin = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.TxtSenhaConfUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.TxtEmailUsuario = new System.Windows.Forms.TextBox();
            this.TxtNomeSocUsuario = new System.Windows.Forms.TextBox();
            this.TxtNomeUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.LblAguarde = new System.Windows.Forms.Label();
            this.panelCadastroUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro PMT";
            // 
            // panelCadastroUsuario
            // 
            this.panelCadastroUsuario.Controls.Add(this.LblAguarde);
            this.panelCadastroUsuario.Controls.Add(this.TxtDataNascimento);
            this.panelCadastroUsuario.Controls.Add(this.LlblLogin);
            this.panelCadastroUsuario.Controls.Add(this.label8);
            this.panelCadastroUsuario.Controls.Add(this.BtnCancelar);
            this.panelCadastroUsuario.Controls.Add(this.BtnConfirmar);
            this.panelCadastroUsuario.Controls.Add(this.TxtSenhaConfUsuario);
            this.panelCadastroUsuario.Controls.Add(this.TxtSenhaUsuario);
            this.panelCadastroUsuario.Controls.Add(this.TxtEmailUsuario);
            this.panelCadastroUsuario.Controls.Add(this.TxtNomeSocUsuario);
            this.panelCadastroUsuario.Controls.Add(this.TxtNomeUsuario);
            this.panelCadastroUsuario.Controls.Add(this.label7);
            this.panelCadastroUsuario.Controls.Add(this.label6);
            this.panelCadastroUsuario.Controls.Add(this.label5);
            this.panelCadastroUsuario.Controls.Add(this.label4);
            this.panelCadastroUsuario.Controls.Add(this.label3);
            this.panelCadastroUsuario.Controls.Add(this.label2);
            this.panelCadastroUsuario.Location = new System.Drawing.Point(12, 62);
            this.panelCadastroUsuario.Name = "panelCadastroUsuario";
            this.panelCadastroUsuario.Size = new System.Drawing.Size(752, 459);
            this.panelCadastroUsuario.TabIndex = 1;
            // 
            // LlblLogin
            // 
            this.LlblLogin.AutoSize = true;
            this.LlblLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlblLogin.Location = new System.Drawing.Point(407, 411);
            this.LlblLogin.Name = "LlblLogin";
            this.LlblLogin.Size = new System.Drawing.Size(42, 16);
            this.LlblLogin.TabIndex = 15;
            this.LlblLogin.TabStop = true;
            this.LlblLogin.Text = "Entrar";
            this.LlblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblLogin_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(274, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Já possui uma conta?";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(143, 290);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(210, 43);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(401, 290);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(219, 43);
            this.BtnConfirmar.TabIndex = 12;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // TxtSenhaConfUsuario
            // 
            this.TxtSenhaConfUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenhaConfUsuario.Location = new System.Drawing.Point(401, 212);
            this.TxtSenhaConfUsuario.Name = "TxtSenhaConfUsuario";
            this.TxtSenhaConfUsuario.Size = new System.Drawing.Size(336, 26);
            this.TxtSenhaConfUsuario.TabIndex = 11;
            // 
            // TxtSenhaUsuario
            // 
            this.TxtSenhaUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenhaUsuario.Location = new System.Drawing.Point(26, 212);
            this.TxtSenhaUsuario.Name = "TxtSenhaUsuario";
            this.TxtSenhaUsuario.Size = new System.Drawing.Size(327, 26);
            this.TxtSenhaUsuario.TabIndex = 10;
            // 
            // TxtEmailUsuario
            // 
            this.TxtEmailUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailUsuario.Location = new System.Drawing.Point(26, 123);
            this.TxtEmailUsuario.Name = "TxtEmailUsuario";
            this.TxtEmailUsuario.Size = new System.Drawing.Size(711, 26);
            this.TxtEmailUsuario.TabIndex = 9;
            // 
            // TxtNomeSocUsuario
            // 
            this.TxtNomeSocUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeSocUsuario.Location = new System.Drawing.Point(302, 52);
            this.TxtNomeSocUsuario.Name = "TxtNomeSocUsuario";
            this.TxtNomeSocUsuario.Size = new System.Drawing.Size(239, 26);
            this.TxtNomeSocUsuario.TabIndex = 7;
            // 
            // TxtNomeUsuario
            // 
            this.TxtNomeUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeUsuario.Location = new System.Drawing.Point(26, 52);
            this.TxtNomeUsuario.Name = "TxtNomeUsuario";
            this.TxtNomeUsuario.Size = new System.Drawing.Size(235, 26);
            this.TxtNomeUsuario.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(397, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Confirme sua Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Crie sua Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Completo";
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDataNascimento.Location = new System.Drawing.Point(573, 52);
            this.TxtDataNascimento.Mask = "00/00/0000";
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.Size = new System.Drawing.Size(164, 26);
            this.TxtDataNascimento.TabIndex = 16;
            this.TxtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // LblAguarde
            // 
            this.LblAguarde.AutoSize = true;
            this.LblAguarde.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAguarde.Location = new System.Drawing.Point(322, 374);
            this.LblAguarde.Name = "LblAguarde";
            this.LblAguarde.Size = new System.Drawing.Size(86, 19);
            this.LblAguarde.TabIndex = 17;
            this.LblAguarde.Text = "Aguarde...";
            // 
            // FrmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 533);
            this.Controls.Add(this.panelCadastroUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroUsuario";
            this.panelCadastroUsuario.ResumeLayout(false);
            this.panelCadastroUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCadastroUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSenhaConfUsuario;
        private System.Windows.Forms.TextBox TxtSenhaUsuario;
        private System.Windows.Forms.TextBox TxtEmailUsuario;
        private System.Windows.Forms.TextBox TxtNomeSocUsuario;
        private System.Windows.Forms.TextBox TxtNomeUsuario;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.LinkLabel LlblLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox TxtDataNascimento;
        private System.Windows.Forms.Label LblAguarde;
    }
}