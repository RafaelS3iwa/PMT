using PMT.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            TxtDataNascimento.Text = usuario.getDataNascimento().ToString("dd/MM/yyyy");


            Candidato candidato = SessaoUsuario.CandidatoAtual;

            byte[] dadosDaFoto = candidato.getFoto();

            if (dadosDaFoto != null && dadosDaFoto.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(dadosDaFoto))
                {
                    PbFoto.Image = Image.FromStream(ms);
                }
            }

            TxtTelefone.Text = candidato.getTelefone();
            TxtCelular.Text = candidato.getCelular();
            TxtNacionalidade.Text = candidato.getNacionalidade();
            TxtCpf.Text = candidato.getCpf();
            TxtEstadoCivil.Text = candidato.getEstadoCivil();
            TxtGenero.Text = candidato.getGenero();
            TxtCep.Text = candidato.getCep().ToString();
            TxtCidade.Text = candidato.getCidade();
            TxtEstado.Text = candidato.getEstado();
            TxtLogradouro.Text = candidato.getLogradouro();
            TxtBairro.Text = candidato.getBairro();
            TxtNumero.Text = candidato.getNumero().ToString();
            TxtConhecimentos.Text = candidato.getConhecimento();
            TxtExperiencia.Text = candidato.getExperiencia();
            TxtEscolaridade.Text = candidato.getEscolaridade();
            TxtBiografia.Text = candidato.getBiografia();


            CbFoto.Items.Add("Foto");
            CbFoto.Items.Add("Adicionar Foto");
            CbFoto.Items.Add("Remover Foto"); 
            CbFoto.SelectedIndex = 0;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmUsuarioIndex frmUsuarioIndex = new FrmUsuarioIndex();
            frmUsuarioIndex.Show();
            this.Hide(); 
        }


        private void CbFoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbFoto.SelectedItem.ToString() == "Adicionar Foto")
            {
                CbFoto.SelectedIndex = 0;
            }
            else if(CbFoto.SelectedItem.ToString() == "Remover Foto")
            {
                CbFoto.SelectedIndex = 0;
            }
        }

        private void FrmEditarPerfilUsuario_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void TxtBiografia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
