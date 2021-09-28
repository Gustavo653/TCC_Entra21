using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTech.View.Principal
{
    public partial class TelaAberturaDeCaixa : Form
    {
        public TelaAberturaDeCaixa()
        {
            InitializeComponent();
        }

        private void TelaAberturaDeCaixa_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            new TelaVenda().Show();
            this.Hide();
        }
    }
}
