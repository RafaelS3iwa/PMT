using PMT.Classes;
using PMT.TelasUsuario;
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
    public partial class FrmUsuarioIndex : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;

        public FrmUsuarioIndex()
        {
            InitializeComponent();

            //conexaoString = "Data Source=MAR0625641W10-1;Initial Catalog=PMT;Integrated Security=True";
            conexaoString = "Data Source=DESKTOP-GTEHLVQ;Initial Catalog=PMT;Integrated Security=True";
            conexaoDB = new SqlConnection(conexaoString);
        }

        private void FrmUsuarioIndex_Load(object sender, EventArgs e)
        {
            cbUsuarioSettings.Items.Add("Usuário");
            cbUsuarioSettings.Items.Add("Visualizar Perfil");
            cbUsuarioSettings.Items.Add("Sair");

            cbUsuarioSettings.SelectedIndex = 0;
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
                conexaoDB.Close();
                return quantidadeRegistro > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar se o usuário é um candidato: " + ex.Message);
                conexaoDB.Close();
                return false;
            }
        }

        private void cbUsuarioSeting_DropDown(object sender, EventArgs e)
        {
            if (cbUsuarioSettings.SelectedItem.ToString() == "Visualizar Perfil")
            {
                cbUsuarioSettings.SelectedIndex = 0;

                Usuario usuario = SessaoUsuario.UsuarioAtual;
 
                int idUsuario = usuario.getId();
                bool usuarioCandidato = VerificarUsuarioCandidato(idUsuario); 
                if (usuarioCandidato)
                {
                    FrmPerfilCandidato frmPerfilCandidato = new FrmPerfilCandidato();
                    frmPerfilCandidato.Show();
                    this.Hide();
                }
                else
                {
                    FrmPerfilUsuario frmPerfilUsuario = new FrmPerfilUsuario();
                    frmPerfilUsuario.Show();
                    this.Hide();
                }

            }
            else if (cbUsuarioSettings.SelectedItem.ToString() == "Sair")
            {
                cbUsuarioSettings.SelectedIndex = 0;

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    FrmLoginUsuario frmLoginUsuario = new FrmLoginUsuario();
                    frmLoginUsuario.Show();
                    this.Hide();
                }
            }
        }
    }
}