using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMT.Classes
{
    internal class AreaInteresse
    {
        private int id;
        private string areaInteresseNome;
        public string conexaoString;
        private SqlConnection conexaoDB;

        public int getId()
        {
            return id;
        }

        public string getAreaInteresseNome()
        {  
            return areaInteresseNome; 
        }

        public void iniciarAreaInteresse()
        {
            //conexaoString = "Data Source=MAR0625641W10-1;Initial Catalog=PMT;Integrated Security=True";
            conexaoString = "Data Source=DESKTOP-GTEHLVQ;Initial Catalog=PMT;Integrated Security=True";
            conexaoDB = new SqlConnection(conexaoString);

            try
            {
                string sql = "SELECT * FROM Area_Interesses";
                conexaoDB.Open();

                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    id = reader.GetInt32(reader.GetOrdinal("id_area_interesse"));
                    areaInteresseNome = reader.GetString(reader.GetOrdinal("area_interesse_nome"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Inserir os Dados: {ex}");
            }
        }
    }
}
