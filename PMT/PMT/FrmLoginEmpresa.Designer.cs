namespace PMT
{
    partial class FrmLoginEmpresa
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLoginEmpresa = new System.Windows.Forms.Panel();
            this.CkManterConectado = new System.Windows.Forms.CheckBox();
            this.BtnConfirmarLoginEmpresa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LLblCadastrar = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLoginEmpresaSenha = new System.Windows.Forms.TextBox();
            this.TxtLoginEmpresaEmail = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLoginEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(292, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 436);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 435);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelLoginEmpresa
            // 
            this.panelLoginEmpresa.Controls.Add(this.CkManterConectado);
            this.panelLoginEmpresa.Controls.Add(this.BtnConfirmarLoginEmpresa);
            this.panelLoginEmpresa.Controls.Add(this.label3);
            this.panelLoginEmpresa.Controls.Add(this.LLblCadastrar);
            this.panelLoginEmpresa.Controls.Add(this.label2);
            this.panelLoginEmpresa.Controls.Add(this.label1);
            this.panelLoginEmpresa.Controls.Add(this.TxtLoginEmpresaSenha);
            this.panelLoginEmpresa.Controls.Add(this.TxtLoginEmpresaEmail);
            this.panelLoginEmpresa.Controls.Add(this.LblTitulo);
            this.panelLoginEmpresa.Location = new System.Drawing.Point(0, 2);
            this.panelLoginEmpresa.Name = "panelLoginEmpresa";
            this.panelLoginEmpresa.Size = new System.Drawing.Size(292, 437);
            this.panelLoginEmpresa.TabIndex = 2;
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
            // BtnConfirmarLoginEmpresa
            // 
            this.BtnConfirmarLoginEmpresa.Location = new System.Drawing.Point(99, 287);
            this.BtnConfirmarLoginEmpresa.Name = "BtnConfirmarLoginEmpresa";
            this.BtnConfirmarLoginEmpresa.Size = new System.Drawing.Size(63, 59);
            this.BtnConfirmarLoginEmpresa.TabIndex = 7;
            this.BtnConfirmarLoginEmpresa.Text = "->";
            this.BtnConfirmarLoginEmpresa.UseVisualStyleBackColor = true;
            this.BtnConfirmarLoginEmpresa.Click += new System.EventHandler(this.BtnConfirmarLoginEmpresa_Click);
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
            // TxtLoginEmpresaSenha
            // 
            this.TxtLoginEmpresaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLoginEmpresaSenha.Location = new System.Drawing.Point(29, 209);
            this.TxtLoginEmpresaSenha.Name = "TxtLoginEmpresaSenha";
            this.TxtLoginEmpresaSenha.Size = new System.Drawing.Size(220, 22);
            this.TxtLoginEmpresaSenha.TabIndex = 2;
            // 
            // TxtLoginEmpresaEmail
            // 
            this.TxtLoginEmpresaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLoginEmpresaEmail.Location = new System.Drawing.Point(29, 146);
            this.TxtLoginEmpresaEmail.Name = "TxtLoginEmpresaEmail";
            this.TxtLoginEmpresaEmail.Size = new System.Drawing.Size(220, 22);
            this.TxtLoginEmpresaEmail.TabIndex = 1;
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
            // FrmLoginEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLoginEmpresa);
            this.Name = "FrmLoginEmpresa";
            this.Text = "FrmLoginEmpresa";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLoginEmpresa.ResumeLayout(false);
            this.panelLoginEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLoginEmpresa;
        private System.Windows.Forms.CheckBox CkManterConectado;
        private System.Windows.Forms.Button BtnConfirmarLoginEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LLblCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLoginEmpresaSenha;
        private System.Windows.Forms.TextBox TxtLoginEmpresaEmail;
        private System.Windows.Forms.Label LblTitulo;
    }
}