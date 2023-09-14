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
        }

        private void FrmUsuarioIndex_Load(object sender, EventArgs e)
        {
            cbUsuarioSettings.Items.Add("Usuário");
            cbUsuarioSettings.Items.Add("Editar");
            cbUsuarioSettings.Items.Add("Sair");

            cbUsuarioSettings.SelectedIndex = 0;
        }

        public bool VerificarUsuarioCliente(int idUsuario)
        {
            //conexaoString = "Data Source=MAR0625641W10-1;Initial Catalog=PMT;Integrated Security=True";
            conexaoString = "Data Source=DESKTOP-GTEHLVQ;Initial Catalog=PMT;Integrated Security=True";

            string sql = "SELECT COUNT(*) FROM Candidadto WHERE id_usuario = @id_usuario";
            SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

            sqlCmd.Parameters.AddWithValue("id_usuario", idUsuario);
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

        private void cbUsuarioSeting_DropDown(object sender, EventArgs e)
        {
            if (cbUsuarioSettings.SelectedItem.ToString() == "Editar")
            {
                cbUsuarioSettings.SelectedIndex = 0;

                Usuario usuario = SessaoUsuario.UsuarioAtual;
 
                int idUsuario = usuario.getId();
                bool usuarioCandidato = VerificarUsuarioCliente(idUsuario); 
                if (usuarioCandidato)
                {
                    FrmEditarPerfilUsuario frmEditarPerfilUsuario = new FrmEditarPerfilUsuario();
                    frmEditarPerfilUsuario.Show();
                    this.Hide();
                }
                else
                {
                    FrmCadastroCandidato frmCadastroCandidato = new FrmCadastroCandidato();
                    frmCadastroCandidato.Show();
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