using PMT.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMT.TelasUsuario
{
    public partial class FrmPerfilUsuario : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;

        public FrmPerfilUsuario()
        {
            InitializeComponent();
            //conexaoString = "Data Source=MAR0625641W10-1;Initial Catalog=PMT;Integrated Security=True";
            conexaoString = "Data Source=DESKTOP-GTEHLVQ;Initial Catalog=PMT;Integrated Security=True";
            conexaoDB = new SqlConnection(conexaoString);

            Usuario usuario = SessaoUsuario.UsuarioAtual;
            LblNome.Text = usuario.getnomeCompleto();
            LblNomeSocial.Text = usuario.getnomeSocial();
            LblEmail.Text = usuario.getEmail();
            LblDataNascimento.Text = usuario.getDataNascimento().ToString("dd/MM/yyyy");
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmUsuarioIndex frmUsuarioIndex = new FrmUsuarioIndex();
            frmUsuarioIndex.Show();
            this.Hide();
        }

        private void BtnCadastrarCandidato_Click(object sender, EventArgs e)
        {
            FrmCadastroCandidato frmCadastroCandidato = new FrmCadastroCandidato();
            frmCadastroCandidato.Show();
            this.Hide();
        }

        private void BtnExcluirConta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir a sua conta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    Usuario usuario = SessaoUsuario.UsuarioAtual;
                    string sql = "DELETE FROM Usuarios WHERE id_usuario=@id_usuario";

                    conexaoDB.Open();
                    SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                    sqlCmd.Parameters.AddWithValue("id_usuario", usuario.getId());
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Conta exluída com sucesso.");
                    FrmTelaInicial frmTelaInicial = new FrmTelaInicial();   
                    frmTelaInicial.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao inserir os dados: {ex}");
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarUsuarioSimples frmEditarUsuarioSimples = new FrmEditarUsuarioSimples();
            frmEditarUsuarioSimples.Show();
            this.Hide();
        }

        private void LblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
