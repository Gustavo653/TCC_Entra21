using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTech.View
{
    public partial class TelaCadCliente : Form
    {
        public TelaCadCliente()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new TelaNovoCliente().Show();
        }

        private void TelaCadCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
