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

            TxtNome.Text = usuario.getnomeCompleto();
            TxtNomeSocial.Text = usuario.getnomeSocial();
            TxtEmail.Text = usuario.getEmail();
            TxtDataNascimento.Text = usuario.getDataNascimento();

            CbFoto.Items.Add("Foto");
            CbFoto.Items.Add("Adicionar Foto");
            CbFoto.Items.Add("Remover Foto"); 
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmUsuarioIndex frmUsuarioIndex = new FrmUsuarioIndex();
            frmUsuarioIndex.Show();
            this.Hide(); 
        }


        private void CbFoto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
