using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMT
{
    public partial class FrmUsuarioIndex : Form
    {
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

        private void cbUsuarioSeting_DropDown(object sender, EventArgs e)
        {
            if(cbUsuarioSettings.SelectedItem.ToString() == "Editar")
            {
                cbUsuarioSettings.SelectedIndex = 0;
                MessageBox.Show("Ai minha voida");
            }
            else if (cbUsuarioSettings.SelectedItem.ToString() == "Sair")
            {
                cbUsuarioSettings.SelectedIndex = 0;
                MessageBox.Show("Ai minha voida");
            }
        }
    }
}
