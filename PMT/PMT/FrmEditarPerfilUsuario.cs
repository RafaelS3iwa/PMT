using PMT.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMT
{
    public partial class FrmEditarPerfilUsuario : Form
    {
        public FrmEditarPerfilUsuario()
        {
            InitializeComponent();
            Usuario usuario = SessaoUsuario.UsuarioAtual;
            LblNome.Text = usuario.getnomeCompleto();
            LblNomeSocial.Text = usuario.getnomeSocial();
            LblEmail.Text = usuario.getEmail();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmUsuarioIndex frmUsuarioIndex = new FrmUsuarioIndex();
            frmUsuarioIndex.Show();
            this.Hide(); 
        }
    }
}
