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
    public partial class TelaCadastroFiliais : Form
    {
        public TelaCadastroFiliais()
        {
            InitializeComponent();
        }

        private void TelaCadastroFiliais_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovoFilial);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoFilial);
            tabControl1.TabPages.Remove(tabFiliais);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastroFiliais_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
