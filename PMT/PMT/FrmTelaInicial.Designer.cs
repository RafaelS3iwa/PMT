namespace PMT
{
    partial class FrmTelaInicial
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
            this.panelTelaInicial = new System.Windows.Forms.Panel();
            this.BtnEmpresa = new System.Windows.Forms.Button();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTelaInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTelaInicial
            // 
            this.panelTelaInicial.Controls.Add(this.BtnEmpresa);
            this.panelTelaInicial.Controls.Add(this.BtnUsuario);
            this.panelTelaInicial.Location = new System.Drawing.Point(72, 67);
            this.panelTelaInicial.Name = "panelTelaInicial";
            this.panelTelaInicial.Size = new System.Drawing.Size(453, 257);
            this.panelTelaInicial.TabIndex = 0;
            // 
            // BtnEmpresa
            // 
            this.BtnEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpresa.Location = new System.Drawing.Point(35, 147);
            this.BtnEmpresa.Name = "BtnEmpresa";
            this.BtnEmpresa.Size = new System.Drawing.Size(379, 50);
            this.BtnEmpresa.TabIndex = 1;
            this.BtnEmpresa.Text = "Entrar como Empresa";
            this.BtnEmpresa.UseVisualStyleBackColor = true;
            this.BtnEmpresa.Click += new System.EventHandler(this.BtnEmpresa_Click);
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuario.Location = new System.Drawing.Point(35, 50);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(379, 50);
            this.BtnUsuario.TabIndex = 0;
            this.BtnUsuario.Text = "Entrar como Usuário";
            this.BtnUsuario.UseVisualStyleBackColor = true;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "PMT";
            // 
            // FrmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTelaInicial);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PMT";
            this.panelTelaInicial.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTelaInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEmpresa;
        private System.Windows.Forms.Button BtnUsuario;
    }
}

