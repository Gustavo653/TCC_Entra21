using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTech
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            new TelaCadUsuarios().Show();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            new TelaSair().Show();
        }

        private void MenuFiliais_Click(object sender, EventArgs e)
        {
            new TelaCadFiliais().Show();
        }

        private void MenuUnidades_Click(object sender, EventArgs e)
        {
            new TelaCadUnidades().Show();
        }

        private void MenuPdv_Click(object sender, EventArgs e)
        {
            new TelaVenda().Show();
        }

        private void MenuFormaPag_Click(object sender, EventArgs e)
        {
            new TelaFormPag().Show();
        }

        private void MenuFornecedores_Click(object sender, EventArgs e)
        {
            new TelaCadFornecedores().Show();
        }
    }
}
