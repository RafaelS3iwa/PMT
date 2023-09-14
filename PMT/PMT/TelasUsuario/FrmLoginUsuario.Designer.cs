namespace PMT
{
    partial class FrmLoginUsuario
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
            this.panelLoginUsuario = new System.Windows.Forms.Panel();
            this.CkManterConectado = new System.Windows.Forms.CheckBox();
            this.BtnConfirmarLoginUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LLblCadastrar = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLoginUsuarioSenha = new System.Windows.Forms.TextBox();
            this.TxtLoginUsuarioEmail = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLoginUsuario.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLoginUsuario
            // 
            this.panelLoginUsuario.Controls.Add(this.CkManterConectado);
            this.panelLoginUsuario.Controls.Add(this.BtnConfirmarLoginUsuario);
            this.panelLoginUsuario.Controls.Add(this.label3);
            this.panelLoginUsuario.Controls.Add(this.LLblCadastrar);
            this.panelLoginUsuario.Controls.Add(this.label2);
            this.panelLoginUsuario.Controls.Add(this.label1);
            this.panelLoginUsuario.Controls.Add(this.TxtLoginUsuarioSenha);
            this.panelLoginUsuario.Controls.Add(this.TxtLoginUsuarioEmail);
            this.panelLoginUsuario.Controls.Add(this.LblTitulo);
            this.panelLoginUsuario.Location = new System.Drawing.Point(2, 1);
            this.panelLoginUsuario.Name = "panelLoginUsuario";
            this.panelLoginUsuario.Size = new System.Drawing.Size(292, 437);
            this.panelLoginUsuario.TabIndex = 0;
            // 
            // CkManterConectado
            // 
            this.CkManterConectado.AutoSize = true;
            this.CkManterConectado.Location = new System.Drawing.Point(29, 248);
            this.CkManterConectado.Name = "CkManterConectado";
            this.CkManterConectado.Size = new System.Drawing.Size(128, 17);
            this.CkManterConectado.TabIndex = 8;
            this.CkManterConectado.Text = "Manter-se Conectado";
            this.CkManterConectado.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmarLoginUsuario
            // 
            this.BtnConfirmarLoginUsuario.Location = new System.Drawing.Point(99, 287);
            this.BtnConfirmarLoginUsuario.Name = "BtnConfirmarLoginUsuario";
            this.BtnConfirmarLoginUsuario.Size = new System.Drawing.Size(63, 59);
            this.BtnConfirmarLoginUsuario.TabIndex = 7;
            this.BtnConfirmarLoginUsuario.Text = "->";
            this.BtnConfirmarLoginUsuario.UseVisualStyleBackColor = true;
            this.BtnConfirmarLoginUsuario.Click += new System.EventHandler(this.BtnConfirmarLoginUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Não possui uma conta?";
            // 
            // LLblCadastrar
            // 
            this.LLblCadastrar.AutoSize = true;
            this.LLblCadastrar.Location = new System.Drawing.Point(158, 380);
            this.LLblCadastrar.Name = "LLblCadastrar";
            this.LLblCadastrar.Size = new System.Drawing.Size(66, 13);
            this.LLblCadastrar.TabIndex = 5;
            this.LLblCadastrar.TabStop = true;
            this.LLblCadastrar.Text = "Cadastrar-se";
            this.LLblCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLblCadastrar_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "E-mail";
            // 
            // TxtLoginUsuarioSenha
            // 
            this.TxtLoginUsuarioSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLoginUsuarioSenha.Location = new System.Drawing.Point(29, 209);
            this.TxtLoginUsuarioSenha.Name = "TxtLoginUsuarioSenha";
            this.TxtLoginUsuarioSenha.Size = new System.Drawing.Size(220, 22);
            this.TxtLoginUsuarioSenha.TabIndex = 2;
            // 
            // TxtLoginUsuarioEmail
            // 
            this.TxtLoginUsuarioEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLoginUsuarioEmail.Location = new System.Drawing.Point(29, 146);
            this.TxtLoginUsuarioEmail.Name = "TxtLoginUsuarioEmail";
            this.TxtLoginUsuarioEmail.Size = new System.Drawing.Size(220, 22);
            this.TxtLoginUsuarioEmail.TabIndex = 1;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(23, 40);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(235, 31);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Insira sua conta PMT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(294, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 436);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 435);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLoginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLoginUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLoginUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoginUsuario";
            this.Load += new System.EventHandler(this.FrmLoginUsuario_Load);
            this.panelLoginUsuario.ResumeLayout(false);
            this.panelLoginUsuario.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoginUsuario;
        private System.Windows.Forms.TextBox TxtLoginUsuarioSenha;
        private System.Windows.Forms.TextBox TxtLoginUsuarioEmail;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.CheckBox CkManterConectado;
        private System.Windows.Forms.Button BtnConfirmarLoginUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LLblCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}