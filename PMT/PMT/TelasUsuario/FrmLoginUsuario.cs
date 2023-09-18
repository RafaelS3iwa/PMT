using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMT.Classes;

namespace PMT
{
    public partial class FrmLoginUsuario : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;

        public FrmLoginUsuario()
        {
            InitializeComponent();
            //conexaoString = "Data Source=MAR0625641W10-1;Initial Catalog=PMT;Integrated Security=True";
            conexaoString = "Data Source=DESKTOP-GTEHLVQ;Initial Catalog=PMT;Integrated Security=True";
            conexaoDB = new SqlConnection(conexaoString);
        }

        private void LLblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastroUsuario formCadastroUsuario = new FrmCadastroUsuario();
            formCadastroUsuario.Show();
            this.Hide(); 
        }

        public bool VerificarUsuarioCandidato(int idUsuario)
        {
            string sql = "SELECT COUNT(*) FROM Candidatos WHERE id_usuario = @id_usuario";

            SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

            sqlCmd.Parameters.AddWithValue("@id_usuario", idUsuario);
            try
            {
                conexaoDB.Open();
                int quantidadeRegistro = (int)sqlCmd.ExecuteScalar();
                return quantidadeRegistro > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar se o usuário é um candidato: " + ex.Message);
                return false;
            }
        }

        private void BtnConfirmarLoginUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtLoginUsuarioEmail.Text) || string.IsNullOrWhiteSpace(TxtLoginUsuarioSenha.Text))
            {
                MessageBox.Show("Por favor, preencha os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    string sql = "SELECT id_usuario, nome_completo, nome_social, data_nascimento, email, senha FROM Usuarios WHERE email=@email AND senha=@senha";
                    conexaoDB.Open();

                    SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                    sqlCmd.Parameters.AddWithValue("@email", TxtLoginUsuarioEmail.Text);
                    sqlCmd.Parameters.AddWithValue("@senha", TxtLoginUsuarioSenha.Text); 
                    
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int idUsuario = reader.GetInt32(reader.GetOrdinal("id_usuario"));
                        string nomeCompleto = reader.GetString(reader.GetOrdinal("nome_completo"));
                        string nomeSocial = reader.GetString(reader.GetOrdinal("nome_social"));
                        DateTime dataNascimento = reader.GetDateTime(reader.GetOrdinal("data_nascimento"));
                        string email = reader.GetString(reader.GetOrdinal("email"));
                        string senha = reader.GetString(reader.GetOrdinal("senha")); 

                        Usuario usuario = new Usuario(idUsuario, nomeCompleto, nomeSocial, dataNascimento, email, senha);
                        SessaoUsuario.DefiniroUsuarioAtual(usuario);
                        reader.Close();

                        bool usuarioCandidato = VerificarUsuarioCandidato(idUsuario);
                        if (!usuarioCandidato)
                        {
                            AdicionarCandidato();
                            reader.Close();
                            Candidato candidato = SessaoUsuario.CandidatoAtual;
                            MessageBox.Show($"O login foi realizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show($"O login foi realizado com sucesso!");
                        }

                        Pausa();
                        FrmUsuarioIndex frmUsuarioIndex = new FrmUsuarioIndex();
                        frmUsuarioIndex.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("E-mail ou Senha estão incorretos, por favor, tente novamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao Inserir os Dados: {ex}");
                }
                finally
                {
                    conexaoDB.Close();
                }
            }
        }

        private void AdicionarCandidato()
        {
            try
            {
                string sql = "SELECT * FROM Candidatos WHERE id_usuario=@id_usuario";
                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                Usuario usuario = SessaoUsuario.UsuarioAtual;
                int idUsuarioLogin = usuario.getId();
                sqlCmd.Parameters.AddWithValue("@id_usuario", idUsuarioLogin);

                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    int idCandidato = reader.GetInt32(reader.GetOrdinal("id_candidato"));
                    int idUsuario = reader.GetInt32(reader.GetOrdinal("id_usuario"));
                    int idAreaInteresse = reader.GetInt32(reader.GetOrdinal("id_area_interesse"));
                    string cpf = reader.GetString(reader.GetOrdinal("cpf"));
                    string telefone = reader.GetString(reader.GetOrdinal("telefone"));
                    string celular = reader.GetString(reader.GetOrdinal("celular"));
                    string genero = reader.GetString(reader.GetOrdinal("genero"));
                    string experiencia = reader.GetString(reader.GetOrdinal("experiencias"));
                    string conhecimento = reader.GetString(reader.GetOrdinal("conhecimentos"));
                    string biografia = reader.GetString(reader.GetOrdinal("biografia"));
                    string escolaridade = reader.GetString(reader.GetOrdinal("escolaridade"));
                    string nacionalidade = reader.GetString(reader.GetOrdinal("nacionalidade"));
                    string estadoCivil = reader.GetString(reader.GetOrdinal("estado_civil"));

                    byte[] foto = (byte[])reader["foto"];

                    string cep = reader.GetString(reader.GetOrdinal("cep"));

                    string logradouro = reader.GetString(reader.GetOrdinal("logradouro"));
                    string bairro = reader.GetString(reader.GetOrdinal("bairro"));

                    int numero = reader.GetInt32(reader.GetOrdinal("numero"));

                    string cidade = reader.GetString(reader.GetOrdinal("cidade"));
                    string estado = reader.GetString(reader.GetOrdinal("estado"));

                    Candidato candidato = new Candidato(idCandidato, idUsuario, idAreaInteresse, cpf, telefone, celular, genero, experiencia, conhecimento, biografia, escolaridade, nacionalidade, estadoCivil, foto, cep, logradouro, bairro, numero, cidade, estado);
                    SessaoUsuario.DefinirCandidatoAtual(candidato);
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

        private void FrmLoginUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
