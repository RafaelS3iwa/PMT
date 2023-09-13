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

namespace PMT
{
    public partial class FrmLoginEmpresa : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;

        public FrmLoginEmpresa()
        {
            InitializeComponent();
            InitializeComponent();
            conexaoString = "Data Source=DESKTOP-GTEHLVQ;Initial Catalog=PMT;Integrated Security=True";
            conexaoDB = new SqlConnection(conexaoString);
        }

        private void BtnConfirmarLoginEmpresa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TxtLoginEmpresaEmail.Text) || string.IsNullOrWhiteSpace(TxtLoginEmpresaSenha.Text))
            {
                MessageBox.Show("Por favor, preencha os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    string sql = "SELECT nome_empresa, cnpj, data_abertura, responsavel_legal, inscricao_estadual, email_corporativo, senha, telefone, celular, logotipo, logradouro, bairro, numero, cep, cidade, estado, complemento FROM Empresas WHERE email_corporativo=@email_corporativo AND senha=@senha"; 
                    conexaoDB.Open();
                    SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                    sqlCmd.Parameters.AddWithValue("@email_corporativo", TxtLoginEmpresaEmail.Text);
                    sqlCmd.Parameters.AddWithValue("@senha", TxtLoginEmpresaSenha.Text); 

                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    if (reader.Read())
                    {

                    }
                    else
                    {
                        MessageBox.Show("E-mail ou Senha estão incorretos, por favor, tente novamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }catch(Exception ex)
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

    }
}
