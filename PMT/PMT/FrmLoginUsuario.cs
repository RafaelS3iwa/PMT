using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMT
{
    public partial class FrmLoginUsuario : Form
    {
        public FrmLoginUsuario()
        {
            InitializeComponent();
        }
        
        public void MostrarPanelLoginUsuario()
        {
            panelLoginUsuario.Visible = true;
        }

        private void LLblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastroUsuario formCadastroUsuario = new FrmCadastroUsuario();
            formCadastroUsuario.Show();
            formCadastroUsuario.MostrarPanelCadastroUsuario();
            this.Hide(); 
        }
    }
}
