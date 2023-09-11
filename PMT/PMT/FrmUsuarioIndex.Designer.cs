namespace PMT
{
    partial class FrmUsuarioIndex
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbConfiguracoes = new System.Windows.Forms.ComboBox();
            this.BtnCurtir = new System.Windows.Forms.Button();
            this.BtnRejeitar = new System.Windows.Forms.Button();
            this.btnAindaNaoSei = new System.Windows.Forms.Button();
            this.PbVaga = new System.Windows.Forms.PictureBox();
            this.cbUsuarioSettings = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbVaga)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbUsuarioSettings);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbConfiguracoes);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 35);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "PMT";
            // 
            // cbConfiguracoes
            // 
            this.cbConfiguracoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConfiguracoes.FormattingEnabled = true;
            this.cbConfiguracoes.Location = new System.Drawing.Point(393, 7);
            this.cbConfiguracoes.Name = "cbConfiguracoes";
            this.cbConfiguracoes.Size = new System.Drawing.Size(121, 21);
            this.cbConfiguracoes.TabIndex = 1;
            // 
            // BtnCurtir
            // 
            this.BtnCurtir.Location = new System.Drawing.Point(348, 408);
            this.BtnCurtir.Name = "BtnCurtir";
            this.BtnCurtir.Size = new System.Drawing.Size(59, 45);
            this.BtnCurtir.TabIndex = 2;
            this.BtnCurtir.Text = "button1";
            this.BtnCurtir.UseVisualStyleBackColor = true;
            // 
            // BtnRejeitar
            // 
            this.BtnRejeitar.Location = new System.Drawing.Point(139, 408);
            this.BtnRejeitar.Name = "BtnRejeitar";
            this.BtnRejeitar.Size = new System.Drawing.Size(59, 45);
            this.BtnRejeitar.TabIndex = 3;
            this.BtnRejeitar.Text = "button2";
            this.BtnRejeitar.UseVisualStyleBackColor = true;
            // 
            // btnAindaNaoSei
            // 
            this.btnAindaNaoSei.Location = new System.Drawing.Point(247, 408);
            this.btnAindaNaoSei.Name = "btnAindaNaoSei";
            this.btnAindaNaoSei.Size = new System.Drawing.Size(59, 45);
            this.btnAindaNaoSei.TabIndex = 3;
            this.btnAindaNaoSei.Text = "button2";
            this.btnAindaNaoSei.UseVisualStyleBackColor = true;
            // 
            // PbVaga
            // 
            this.PbVaga.Location = new System.Drawing.Point(158, 84);
            this.PbVaga.Name = "PbVaga";
            this.PbVaga.Size = new System.Drawing.Size(236, 307);
            this.PbVaga.TabIndex = 4;
            this.PbVaga.TabStop = false;
            // 
            // cbUsuarioSettings
            // 
            this.cbUsuarioSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarioSettings.FormattingEnabled = true;
            this.cbUsuarioSettings.Location = new System.Drawing.Point(13, 7);
            this.cbUsuarioSettings.Name = "cbUsuarioSettings";
            this.cbUsuarioSettings.Size = new System.Drawing.Size(121, 21);
            this.cbUsuarioSettings.TabIndex = 3;
            this.cbUsuarioSettings.SelectedIndexChanged += new System.EventHandler(this.cbUsuarioSeting_DropDown);
            // 
            // FrmUsuarioIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 481);
            this.Controls.Add(this.PbVaga);
            this.Controls.Add(this.btnAindaNaoSei);
            this.Controls.Add(this.BtnRejeitar);
            this.Controls.Add(this.BtnCurtir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmUsuarioIndex";
            this.Text = "FrmUsuarioIndex";
            this.Load += new System.EventHandler(this.FrmUsuarioIndex_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbVaga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbConfiguracoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCurtir;
        private System.Windows.Forms.Button BtnRejeitar;
        private System.Windows.Forms.Button btnAindaNaoSei;
        private System.Windows.Forms.PictureBox PbVaga;
        private System.Windows.Forms.ComboBox cbUsuarioSettings;
    }
}