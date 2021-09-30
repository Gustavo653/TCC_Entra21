using FarmaTech.View;
using FarmaTech.View.Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

            lblDataSitema.Text = DateTime.Now.ToString();
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
            StreamWriter cupomText = new StreamWriter("C:\\Temp\\CupomText.txt");
            cupomText.WriteLine("............................CUPOM FISCAL............................");
            cupomText.WriteLine();
            cupomText.WriteLine("Número: 00000");
            cupomText.WriteLine();
            cupomText.WriteLine("Fornecedor:  FarmaTech    " + "Filial:   " + "CNPJ: ");
            cupomText.WriteLine("-------------------------------------------------------------------- ");
            cupomText.WriteLine("-------------------------------------------------------------------- ");
            cupomText.WriteLine("Cliente: " + txtRazaoSocial.Text + "\tCPF/CNPJ: " + txtCnpj.Text);
            cupomText.WriteLine("=====================================================================");
            cupomText.WriteLine("Produto:                       Quant.:          Unit. R$:            ");
            cupomText.WriteLine(txtProduto.Text + "\t" + txtQuant.Text + "\t" + txtValorParcial.Text);
            cupomText.WriteLine();
            cupomText.WriteLine("Valor Total: R$ " + txtFormaValorTotal.Text);
            cupomText.WriteLine("Forma de Pagamento: " + txtFormaPag.Text);
            cupomText.WriteLine("=====================================================================");
            cupomText.WriteLine("Volte sempre - Obrigado");
            cupomText.WriteLine("FarmaTech by Query Lab - 2021®");
            cupomText.Close();         

            Process.Start(@"C:\\Temp\\CupomText.txt");
                        
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
