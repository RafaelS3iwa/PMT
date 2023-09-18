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
    public partial class FrmEditarUsuarioSimples : Form
    {

        public string conexaoString;
        private SqlConnection conexaoDB;

        public FrmEditarUsuarioSimples()
        {
            InitializeComponent();
            //conexaoString = "Data Source=MAR0625641W10-1;Initial Catalog=PMT;Integrated Security=True";
            conexaoString = "Data Source=DESKTOP-GTEHLVQ;Initial Catalog=PMT;Integrated Security=True";
            conexaoDB = new SqlConnection(conexaoString);

            Usuario usuario = SessaoUsuario.UsuarioAtual;
            TxtNome.Text = usuario.getnomeCompleto();
            TxtNomeSocial.Text = usuario.getnomeSocial();
            TxtEmail.Text = usuario.getEmail();
            TxtDataNascimento.Text = usuario.getDataNascimento().ToString("dd/MM/yyyy");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FrmPerfilUsuario frmPerfilUsuario = new FrmPerfilUsuario();
            frmPerfilUsuario.Show();
            this.Hide();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = SessaoUsuario.UsuarioAtual;

                string sql = "UPDATE Usuarios SET nome_completo=@nome_completo, nome_social=@nome_social, data_nascimento=@data_nascimento, email=@email WHERE id_usuario=@id_usuario";
                conexaoDB.Open();

                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);
                sqlCmd.Parameters.AddWithValue("id_usuario", usuario.getId());
                sqlCmd.Parameters.AddWithValue("@nome_completo", TxtNome.Text);
                sqlCmd.Parameters.AddWithValue("@nome_social", TxtNomeSocial.Text);
                sqlCmd.Parameters.AddWithValue("@email", TxtEmail.Text); ;

                DateTime dataNascimento;
                DateTime.TryParse(TxtDataNascimento.Text, out dataNascimento);

                sqlCmd.Parameters.AddWithValue("@data_nascimento", dataNascimento);
                sqlCmd.ExecuteNonQuery();
                conexaoDB.Close();

                AdicionarUsuario();

                Pausa();

                MessageBox.Show("Edição realizado com sucesso!");
                FrmPerfilUsuario frmPerfilUsuario = new FrmPerfilUsuario();
                frmPerfilUsuario.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao Inserir os Dados: {ex}");
            }
        }

        private void AdicionarUsuario()
        {
            try
            {
                string sql = "SELECT id_usuario, nome_completo, nome_social, data_nascimento, email, senha FROM Usuarios WHERE id_usuario=@id_usuario";
                conexaoDB.Open();

                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);
                Usuario usuario = SessaoUsuario.UsuarioAtual;

                sqlCmd.Parameters.AddWithValue("@id_usuario", usuario.getId());
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    int idUsuario = reader.GetInt32(reader.GetOrdinal("id_usuario"));
                    string nomeCompleto = reader.GetString(reader.GetOrdinal("nome_completo"));
                    string nomeSocial = reader.GetString(reader.GetOrdinal("nome_social"));
                    DateTime dataNascimento = reader.GetDateTime(reader.GetOrdinal("data_nascimento"));
                    string email = reader.GetString(reader.GetOrdinal("email"));
                    string senha = reader.GetString(reader.GetOrdinal("senha"));

                    Usuario usuarioEditado = new Usuario(idUsuario, nomeCompleto, nomeSocial, dataNascimento, email, senha);
                    SessaoUsuario.DefiniroUsuarioAtual(usuarioEditado);
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Inserir os Dados: {ex}");
            }
        }


        async void Pausa()
        {
            await Task.Delay(2000); ;
        }
    }
}
