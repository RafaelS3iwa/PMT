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
                        MessageBox.Show("O login foi realizado com sucesso!");


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
        async void Pausa()
        {
            await Task.Delay(2000); ;
        }

        private void FrmLoginUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
