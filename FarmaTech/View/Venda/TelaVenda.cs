using FarmaTech.View;
using FarmaTech.View.Principal;
using FarmaTech.View.Venda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            cbFormaPagamento.DataSource = Enum.GetValues(typeof(DAL.Model.Enums.FormaPagamento));

            IEnumerable<DAL.Model.Objetos.Endereco> listaClientes = BAL.Control.Enderecos_BAL.GetEndereco(2);
            cbNomeCliente.DataSource = listaClientes.Select(x => x.NomeFantasia).ToList();
            cbCliente.DataSource = listaClientes.Select(x => x.CNPJCPF).ToList();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabCliente);
            tabControl1.TabPages.Add(tabVenda);

            lblDataSitema.Text = DateTime.Now.ToString();
            cbVendedor.Text = DAL.Model.Objetos.UsuarioStatic.Nome;

            IEnumerable<string> listaNome = BAL.Control.Produtos_BAL.GetProdutos().Select(x => x.Nome);

            cbProdutoVenda.DataSource = listaNome.ToArray();

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
            cupomText.WriteLine("Cliente: " + cbNomeCliente.Text + "\tCPF/CNPJ: " + cbCliente.Text);
            cupomText.WriteLine("=====================================================================");
            cupomText.WriteLine("Produto:                       Quant.:          Unit. R$:            ");
            cupomText.WriteLine(cbProdutoVenda.Text + "\t\t" + cbQuantidade.Text + "\t\t" + txtPrecoTotalProduto.Text);
            cupomText.WriteLine();
            cupomText.WriteLine("Valor Total: R$ " + txtFormaValorTotal.Text);
            cupomText.WriteLine("Forma de Pagamento: " + cbFormaPagamento.Text);
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

            txtValorCompra.Text = txtValorTotal.Text;

            //cboConsole.DataSource = Enum.GetValues(typeof(TipoConsole)); //Adiciona o enum de console na combobox console

            //cbFormaPagamento.DataSource = Enum.GetValues(typeof())
        }

        private void TelaVenda_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }
        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(94, 221, 231), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void cbProdutoVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<int> listaNome = BAL.Control.Produtos_BAL.GetProdutosPorNome(cbProdutoVenda.Text).Select(x => x.Quantidade);
            List<int> quantidades = new List<int>();
            for (int i = 1; i <= listaNome.ElementAt(0); i++)
            {
                quantidades.Add(i);
            }
            cbQuantidade.DataSource = quantidades;
        }

        private void tabCliente_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(116, 186, 241), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(116, 186, 241), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void tabVenda_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(116, 186, 241), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void tabCliente_Paint_1(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void tabVenda_Paint_1(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void tabFormaPagamento_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void btnPesquisaProduto_Click(object sender, EventArgs e)
        {
            new TelaCadastroProdutos().Show();
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            new TelaCadastroCliente().Show();
        }

        private void btnSangria_Click(object sender, EventArgs e)
        {
            new TelaSangria().Show();
        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            if (txtDesconto.Text == "")
            {
                txtDesconto.Text = 0.ToString("F2");
            }

            txtPrecoTotalProduto.Text = Convert.ToDouble(BAL.Control.Vendas_BAL.ValorTotalProduto(cbQuantidade.Text, txtPrecoUnitario.Text)).ToString("F2");
            txtValorTotal.Text = Convert.ToDouble(BAL.Control.Vendas_BAL.ValorTotal(cbQuantidade.Text, txtPrecoUnitario.Text, txtDesconto.Text)).ToString("F2");



        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {

            if (txtDesconto.Text == "")
            {
                txtDesconto.Text = 0.ToString("F2");
            }

            txtPrecoTotalProduto.Text = BAL.Control.Vendas_BAL.ValorTotal(cbQuantidade.Text, txtPrecoUnitario.Text, txtDesconto.Text).ToString();


        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNomeCliente.SelectedIndex = cbCliente.SelectedIndex;
        }

        private void cbNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCliente.Items.Count > 0)
                cbCliente.SelectedIndex = cbNomeCliente.SelectedIndex;
        }
    }
}
