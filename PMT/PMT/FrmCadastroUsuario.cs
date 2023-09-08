using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMT
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        public void MostrarPanelCadastroUsuario()
        {
            panelCadastroUsuario.Visible = true; 
        }

        private void LlblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLoginUsuario frmLoginUsuario = new FrmLoginUsuario();
            frmLoginUsuario.Show();
            frmLoginUsuario.MostrarPanelLoginUsuario();
            this.Hide(); 
        }
    }
}
