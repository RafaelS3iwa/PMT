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
    public partial class FrmTelaInicial : Form
    {
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmLoginUsuario formLoginUsuario = new FrmLoginUsuario();
            formLoginUsuario.Show();
            formLoginUsuario.MostrarPanelLoginUsuario();
            this.Hide();
        }
    }
}
