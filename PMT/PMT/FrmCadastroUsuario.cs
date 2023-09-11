using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PMT
{
    public partial class FrmCadastroUsuario : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;

        public FrmCadastroUsuario()
        {
            InitializeComponent();
            LblAguarde.Visible = false;
            conexaoString = "Data Source=DESKTOP-GTEHLVQ;Initial Catalog=PMT;Integrated Security=True";
            conexaoDB = new SqlConnection(conexaoString);
        }

        private void LlblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLoginUsuario frmLoginUsuario = new FrmLoginUsuario(); 
            frmLoginUsuario.Show();
            this.Hide(); 
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtNomeUsuario.Text) || string.IsNullOrWhiteSpace(TxtEmailUsuario.Text) || string.IsNullOrWhiteSpace(TxtDataNascimento.Text) || string.IsNullOrWhiteSpace(TxtSenhaUsuario.Text) || string.IsNullOrWhiteSpace(TxtSenhaConfUsuario.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios para realizar o cadastro.", "Aviso", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    if(TxtSenhaUsuario.Text != TxtSenhaConfUsuario.Text)
                    {
                        MessageBox.Show("As senhas tem que ser iguais!", "Erro", MessageBoxButtons.OK);
                        return; 
                    }
                    else
                    {
                        TxtSenhaConfUsuario.Text = TxtSenhaUsuario.Text;
                        string sql = "INSERT INTO Usuarios (nome_completo, nome_social, data_nascimento, email, senha) VALUES (@nome_completo, @nome_social, @data_nascimento, @email, @senha)";
                        conexaoDB.Open();

                        SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                        sqlCmd.Parameters.AddWithValue("@nome_completo", TxtNomeUsuario.Text);
                        sqlCmd.Parameters.AddWithValue("@nome_social", TxtNomeSocUsuario.Text);
                        sqlCmd.Parameters.AddWithValue("@email", TxtEmailUsuario.Text);
                        sqlCmd.Parameters.AddWithValue("@senha", TxtSenhaConfUsuario.Text);

                        DateTime dataNascimento;
                        DateTime.TryParse(TxtDataNascimento.Text, out dataNascimento);

                        sqlCmd.Parameters.AddWithValue("@data_nascimento", dataNascimento);
                        sqlCmd.ExecuteNonQuery();

                        conexaoDB.Close();
                        LblAguarde.Visible = true;
                        Pausa();

                        MessageBox.Show("Cadastro realizado com sucesso!");
                        FrmLoginUsuario frmLoginUsuario = new FrmLoginUsuario();
                        frmLoginUsuario.Show();
                        this.Hide();
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show($"Erro ao Inserir os Dados: {ex}");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FrmTelaInicial frmTelaInicial = new FrmTelaInicial();
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja cancelar?", "Aviso", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                frmTelaInicial.Show();
                this.Hide();
            }
        }

       async void Pausa()
        {
            await Task.Delay(2000);;
        }
    }
}
