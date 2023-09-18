using PMT.Classes;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace PMT.TelasUsuario
{
    public partial class FrmCadastroCandidato : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;


        public FrmCadastroCandidato()
        {
            InitializeComponent();

            //conexaoString = "Data Source=MAR0625641W10-1;Initial Catalog=PMT;Integrated Security=True";
            conexaoString = "Data Source=DESKTOP-GTEHLVQ;Initial Catalog=PMT;Integrated Security=True";
            conexaoDB = new SqlConnection(conexaoString);

            CbFoto.Items.Add("Foto");
            CbFoto.Items.Add("Adicionar Foto");
            CbFoto.Items.Add("Remover Foto");
            CbFoto.SelectedIndex = 0;
        }

        private void CbFoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbFoto.SelectedItem.ToString() == "Adicionar Foto")
            {
                CbFoto.SelectedIndex = 0;
                
                OpenFileDialog openFile = new OpenFileDialog(); 
                if(openFile.ShowDialog() == DialogResult.OK)
                {
                    PbFoto.Image = new Bitmap(openFile.FileName);
                }
            }
            else if (CbFoto.SelectedItem.ToString() == "Remover Foto")
            {
                CbFoto.SelectedIndex = 0;
                PbFoto.Image = null;
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtCpf.Text) || string.IsNullOrWhiteSpace(TxtCelular.Text) || string.IsNullOrWhiteSpace(TxtEscolaridade.Text) || string.IsNullOrWhiteSpace(TxtNacionalidade.Text) || string.IsNullOrWhiteSpace(TxtEstadoCivil.Text) || PbFoto.Image == null || string.IsNullOrWhiteSpace(TxtCep.Text) || string.IsNullOrWhiteSpace(TxtLogradouro.Text) || string.IsNullOrWhiteSpace(TxtBairro.Text) || string.IsNullOrWhiteSpace(TxtBairro.Text) || string.IsNullOrWhiteSpace(TxtNumero.Text) || string.IsNullOrWhiteSpace(TxtCidade.Text) || string.IsNullOrWhiteSpace(TxtEstado.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios para realizar o cadastro.", "Aviso", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    string sql = "INSERT INTO Candidatos (id_usuario, id_area_interesse, cpf, telefone, genero, celular, experiencias, conhecimentos, biografia, escolaridade, nacionalidade, estado_civil, foto, cep, logradouro, bairro, numero, cidade, estado) VALUES (@id_usuario, @id_area_interesse, @cpf, @telefone, @genero, @celular, @experiencias, @conhecimentos, @biografia, @escolaridade, @nacionalidade, @estado_civil, @foto, @cep, @logradouro, @bairro, @numero, @cidade, @estado)";
                    conexaoDB.Open();
                    SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                    Usuario usuario = SessaoUsuario.UsuarioAtual;

                    AreaInteresse areaInteresse = new AreaInteresse();
                    areaInteresse.iniciarAreaInteresse();

                    int idArea = areaInteresse.getId();

                    sqlCmd.Parameters.AddWithValue("@id_usuario", usuario.getId());
                    sqlCmd.Parameters.AddWithValue("@id_area_interesse", areaInteresse.getId()); 
                    sqlCmd.Parameters.AddWithValue("@cpf", TxtCpf.Text);
                    sqlCmd.Parameters.AddWithValue("@telefone", TxtTelefone.Text);
                    sqlCmd.Parameters.AddWithValue("@genero", TxtGenero.Text);
                    sqlCmd.Parameters.AddWithValue("@celular", TxtCelular.Text);
                    sqlCmd.Parameters.AddWithValue("@experiencias", TxtExperiencia.Text);
                    sqlCmd.Parameters.AddWithValue("@conhecimentos", TxtConhecimentos.Text);
                    sqlCmd.Parameters.AddWithValue("@biografia", TxtBiografia.Text);
                    sqlCmd.Parameters.AddWithValue("@escolaridade", TxtEscolaridade.Text);
                    sqlCmd.Parameters.AddWithValue("@nacionalidade", TxtNacionalidade.Text);
                    sqlCmd.Parameters.AddWithValue("@estado_civil", TxtEstadoCivil.Text);

                    sqlCmd.Parameters.AddWithValue("@foto", getFoto());

                    sqlCmd.Parameters.AddWithValue("@cep", TxtCep.Text);
                    sqlCmd.Parameters.AddWithValue("@logradouro", TxtLogradouro.Text);
                    sqlCmd.Parameters.AddWithValue("@bairro", TxtBairro.Text);

                    int numero; 
                    if(int.TryParse(TxtNumero.Text, out numero))
                    {
                        sqlCmd.Parameters.AddWithValue("@numero", numero);
                    }

                    sqlCmd.Parameters.AddWithValue("@cidade", TxtCidade.Text);
                    sqlCmd.Parameters.AddWithValue("@estado", TxtEstado.Text);
                   
                    sqlCmd.ExecuteNonQuery();

                    AdicionarCandidato();

                    MessageBox.Show("Cadastro realizado com sucesso!");
               

                    Pausa();
                    FrmUsuarioIndex frmUsuarioIndex = new FrmUsuarioIndex();
                    frmUsuarioIndex.Show();
                    this.Hide();
                 }
              
            }catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Inserir os Dados: {ex}");
            }
            finally
            {
                if (conexaoDB != null && conexaoDB.State == ConnectionState.Open)
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
                conexaoDB.Open();

                Usuario usuario = SessaoUsuario.UsuarioAtual;
                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

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
                    reader.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Erro ao Inserir os Dados: {ex}");
            }
        }

        private byte[] getFoto()
        {
            MemoryStream ms = new MemoryStream();
            PbFoto.Image.Save(ms, PbFoto.Image.RawFormat);
            return ms.GetBuffer();
        }

        async void Pausa()
        {
            await Task.Delay(2000); ;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmUsuarioIndex frmUsuarioIndex = new FrmUsuarioIndex();

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja cancelar?", "Aviso", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                frmUsuarioIndex.Show();
                this.Hide();
            }

        }
    }
}
