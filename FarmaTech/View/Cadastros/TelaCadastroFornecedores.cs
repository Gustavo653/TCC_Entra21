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
    public partial class TelaCadastroFornecedores : Form
    {
        public TelaCadastroFornecedores()
        {
            InitializeComponent();
        }

        private void TelaCadastroFornecedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void TelaCadastroFornecedores_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovoFornecedor);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoFornecedor);
            tabControl1.TabPages.Remove(tabFornecedores);
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
    }
}
