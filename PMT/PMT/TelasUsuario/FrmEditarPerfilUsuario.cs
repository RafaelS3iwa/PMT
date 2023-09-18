using PMT.Classes;
using PMT.TelasUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public string conexaoString;
        private SqlConnection conexaoDB;

        public FrmEditarPerfilUsuario()
        {
            InitializeComponent();
            //conexaoString = "Data Source=MAR0625641W10-1;Initial Catalog=PMT;Integrated Security=True";
            conexaoString = "Data Source=DESKTOP-GTEHLVQ;Initial Catalog=PMT;Integrated Security=True";
            conexaoDB = new SqlConnection(conexaoString);

            Usuario usuario = SessaoUsuario.UsuarioAtual;
            Candidato candidato = SessaoUsuario.CandidatoAtual;

            TxtNome.Text = usuario.getnomeCompleto();
            TxtNomeSocial.Text = usuario.getnomeSocial();
            TxtEmail.Text = usuario.getEmail();
            TxtDataNascimento.Text = usuario.getDataNascimento().ToString("dd/MM/yyyy");

            PbFoto.Image = Image.FromStream(new MemoryStream(candidato.getFoto()));

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
            if (CbFoto.SelectedItem.ToString() == "Adicionar Foto")
            {
                CbFoto.SelectedIndex = 0;

                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
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

                AtualizarCandidato();

                AdicionarUsuario();

                AdicionarCandidato();

                MessageBox.Show("Atualização realizada com sucesso!");

                Pausa();

                FrmUsuarioIndex frmUsuarioIndex = new FrmUsuarioIndex();
                frmUsuarioIndex.Show();
                this.Hide();
            }
            catch (Exception ex)
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

        private void AtualizarCandidato()
        {
            try
            {
                string sql = "UPDATE Candidatos SET " +
                    "cpf=@cpf, " +
                    "telefone=@telefone, " +
                    "genero=@genero, " +
                    "celular=@celular, " +
                    "experiencias=@experiencias, " +
                    "conhecimentos=@conhecimentos, " +
                    "biografia=@biografia, " +
                    "escolaridade=@escolaridade, " +
                    "nacionalidade=@nacionalidade, " +
                    "estado_civil=@estado_civil, " +
                    "foto=@foto, " +
                    "cep=@cep, " +
                    "logradouro=@logradouro, " +
                    "bairro=@bairro, " +
                    "numero=@numero, " +
                    "cidade=@cidade, " +
                    "estado=@estado " +
                    "WHERE id_usuario=@id_usuario";

                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);
                Usuario usuario = SessaoUsuario.UsuarioAtual;

                sqlCmd.Parameters.AddWithValue("@id_usuario", usuario.getId());
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
                if (int.TryParse(TxtNumero.Text, out numero))
                {
                    sqlCmd.Parameters.AddWithValue("@numero", numero);
                }

                sqlCmd.Parameters.AddWithValue("@cidade", TxtCidade.Text);
                sqlCmd.Parameters.AddWithValue("@estado", TxtEstado.Text);

                sqlCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Inserir os Dados: {ex}");
            }
        }

        private void AdicionarCandidato()
        {
            try
            {
                string sql = "SELECT * FROM Candidatos WHERE id_usuario=@id_usuario";
                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Inserir os Dados: {ex}");
            }
        }

        private void AdicionarUsuario()
        {
            try
            {
                string sql = "SELECT id_usuario, nome_completo, nome_social, data_nascimento, email, senha FROM Usuarios WHERE id_usuario=@id_usuario";

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
            catch(Exception ex)
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

    }
}
