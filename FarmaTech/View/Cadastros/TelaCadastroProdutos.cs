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
    public partial class TelaCadastroProdutos : Form
    {
        public TelaCadastroProdutos()
        {
            InitializeComponent();
        }

        private void TelaCadastroProdutos_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovoProduto);
            btnSalvar.Enabled = false;
        }

        private void TelaCadastroProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoProduto);
            tabControl1.TabPages.Remove(tabProdutos);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabProdutos);
            tabControl1.TabPages.Add(tabNovoProduto);
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }


    }
}
