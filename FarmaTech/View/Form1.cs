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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            new TelaSobre().Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            new TelaPrincipal().Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new TelaSair().Show();
        }
    }
}
