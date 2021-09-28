using FarmaTech.View;
using FarmaTech.View.Principal;
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
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();
        }

        private void TelaVenda_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabVenda);
            tabControl1.TabPages.Remove(tabFormaPagamento);
                                    
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabCliente);
            tabControl1.TabPages.Add(tabVenda);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            new TelaCadastroCliente().Show();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            new TelaCadastroProdutos().Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCpf.Text = "CPF:";
            lblNome.Text = "Nome:";
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCpf.Text = "CNPJ:";
            lblNome.Text = "Razão Social:";
            
        }

        private void btnVoltarVenda_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabFormaPagamento);
            tabControl1.TabPages.Add(tabVenda);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venda Finalizada");
            tabControl1.TabPages.Remove(tabFormaPagamento);
            tabControl1.TabPages.Add(tabCliente);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new TelaConfirmacaoCancelamento().Show();
        }

        private void btnContinarVenda_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabVenda);
            tabControl1.TabPages.Add(tabFormaPagamento);
        }
    }
}
