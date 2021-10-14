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
            cbConvenio.DataSource = BAL.Control.Convenios_BAL.GetConvenios().Select(x => x.Nome).ToList();

            IEnumerable<DAL.Model.Objetos.Endereco> listaClientes = BAL.Control.Enderecos_BAL.GetEndereco(2);
            cbNomeCliente.DataSource = listaClientes.Select(x => x.NomeFantasia).ToList();
            cbCliente.DataSource = listaClientes.Select(x => x.CNPJCPF).ToList();
            cbVendedor.DataSource = BAL.Control.Usuarios_BAL.GetUsuarios().Select(x => x.Nome).ToList();
            txtDesconto.Text = "0,00";
            txtValorTotal.Text = "0,00";
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (cbCliente.Text != "" && cbNomeCliente.Text != "")
            {
                tabControl1.TabPages.Remove(tabCliente);
                tabControl1.TabPages.Add(tabVenda);

                lblDataSitema.Text = DateTime.Now.ToString();
                cbVendedor.Text = DAL.Model.Objetos.UsuarioStatic.Nome;

                IEnumerable<string> listaNome = BAL.Control.Produtos_BAL.GetProdutos().Select(x => x.Nome);

                cbProdutoVenda.DataSource = listaNome.ToArray();
            }
            else
            {
                MessageBox.Show("Preencha um cliente");
            }
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
            DAL.Model.Consultas.LogErros.GerarCupom(BAL.Control.Vendas_BAL.Cupom, "Vendas_GerarCupom", cbNomeCliente.Text, cbCliente.Text, cbProdutoVenda.Text, cbQuantidade.Text, txtPrecoUnitario.Text, txtPrecoTotalProduto.Text, txtValorTotal.Text, cbFormaPagamento.Text);

            int resultado = BAL.Control.Vendas_BAL.InsereCupom(cbVendedor.Text, cbNomeCliente.Text, txtFormaValorTotal.Text, cbFormaPagamento.Text);
            if (resultado == 0)
            {
                MessageBox.Show("Cupom finalizado");
            }
            else if (resultado == 1)
            {
                MessageBox.Show("preencha todos os campos");
            }
            else if (resultado == 2)
            {
                MessageBox.Show("houve algum erro inesperado!");
            }
            tabControl1.TabPages.Remove(tabFormaPagamento);
            tabControl1.TabPages.Add(tabCliente);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja cancelar a venda?", "Cancelar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                foreach (DataGridViewRow dataGridViewRow in dgVenda.Rows)
                {
                    BAL.Control.Vendas_BAL.CancelaVenda(dataGridViewRow.Cells["QuantidadeCol"].Value.ToString(), dataGridViewRow.Cells["NomeCol"].Value.ToString());
                }
                while (dgVenda.Rows.Count > 0)
                {
                    dgVenda.Rows.RemoveAt(0);
                }
                BAL.Control.Vendas_BAL.CancelaCupom();
                tabControl1.TabPages.Remove(tabVenda);
                tabControl1.TabPages.Add(tabCliente);
                txtValorTotal.Text = "0,00";
            }
        }

        private void btnContinarVenda_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabVenda);
            tabControl1.TabPages.Add(tabFormaPagamento);

            txtValorCompra.Text = txtValorTotal.Text;
            txtFormaValorParcial.Text = txtValorTotal.Text;
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
            IEnumerable<DAL.Model.Objetos.Produto> produtos = BAL.Control.Produtos_BAL.GetProdutosPorNome(cbProdutoVenda.Text);
            List<int> quantidades = new List<int>();
            if (produtos.Select(x => x.Quantidade).ElementAt(0) < 30)
            {
                for (int i = 1; i <= produtos.Select(x => x.Quantidade).ElementAt(0); i++)
                {
                    quantidades.Add(i);
                }
            }
            else
            {
                for (int i = 1; i <= 30; i++)
                {
                    quantidades.Add(i);
                }
            }
            txtPrecoUnitario.Text = produtos.Select(x => x.PrecoUnitario).ElementAt(0);
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
            new TelaConsultaCliente().Show();
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
            if (cbQuantidade.Items.Count == 0 || cbQuantidade.Text == "0")
            {
                MessageBox.Show("Este produto nao pode ser vendido, pois sua quantidade é 0");
            }
            else
            {
                txtPrecoTotalProduto.Text = Convert.ToDouble(BAL.Control.Vendas_BAL.ValorTotal(cbQuantidade.Text, txtPrecoUnitario.Text, txtDesconto.Text)).ToString("F2");
                int resultado = BAL.Control.Vendas_BAL.InsereVenda(cbProdutoVenda.Text, cbQuantidade.Text, txtPrecoUnitario.Text);
                if (resultado == 0)
                {
                    dgVenda.Rows.Add(cbProdutoVenda.Text, cbQuantidade.Text, txtPrecoUnitario.Text, txtPrecoTotalProduto.Text);
                    txtValorTotal.Text = (Convert.ToDouble(txtValorTotal.Text) + Convert.ToDouble(txtPrecoTotalProduto.Text)).ToString();
                    MessageBox.Show("item adicionado");
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("preencha todos os campos");
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("houve algum erro inesperado!");
                }
            }
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
            if (dgVenda.Rows.Count != 0)
            {
                int indiceSelecionado = dgVenda.CurrentRow.Index;
                int resultado = BAL.Control.Vendas_BAL.CancelaVenda(dgVenda.Rows[indiceSelecionado].Cells[1].Value.ToString(), dgVenda.Rows[indiceSelecionado].Cells[0].Value.ToString());
                if (resultado == 0)
                {
                    txtValorTotal.Text = (Convert.ToDouble(txtValorTotal.Text) - Convert.ToDouble(dgVenda.Rows[indiceSelecionado].Cells[3].Value.ToString())).ToString();
                    dgVenda.Rows.RemoveAt(indiceSelecionado);
                    MessageBox.Show("item removido");
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("preencha todos os campos");
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("houve algum erro inesperado!");
                }
            }
            else
            {
                MessageBox.Show("Não há nenhuma venda para excluir!");
            }
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
        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtDesconto_KeyUp(object sender, KeyEventArgs e)
        {
            txtDesconto.Text = txtDesconto.Text.Replace("-", "");
        }

        private void cbConvenio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valorTotalConvenio = BAL.Control.Vendas_BAL.CalculaTotalConvenio(txtFormaValorParcial.Text, cbConvenio.Text);
            if (valorTotalConvenio == null)
                MessageBox.Show("Houve um erro inesperado!");
            else
                txtFormaValorTotal.Text = BAL.Control.Vendas_BAL.CalculaTotalConvenio(txtFormaValorParcial.Text, cbConvenio.Text);
        }
    }
}
