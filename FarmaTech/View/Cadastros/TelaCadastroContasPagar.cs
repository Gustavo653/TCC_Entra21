using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTech.View
{
    public partial class TelaCadastroContasPagar : Form
    {
        public static int ValorSalvar { get; set; }
        public TelaCadastroContasPagar()
        {
            InitializeComponent();
        }

        private void TelaCadastroContasPagar_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovoContaPagar);
            btnSalvar.Enabled = false;
            dtpVencimento.Value = DateTime.Now.Date;
            AtualizaDG();
        }

        private void TelaCadastroContasPagar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabNovoContaPagar))
            {
                tabControl1.TabPages.Remove(tabNovoContaPagar);
                tabControl1.TabPages.Add(tabContasPagar);
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnNovo.Enabled = true;
            }
            else
            {
                this.Hide();
            }
            lblContas.Text = "Contas a pagar";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoContaPagar);
            tabControl1.TabPages.Remove(tabContasPagar);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            ValorSalvar = 1;

            lblContas.Text = "Nova Conta";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValorSalvar == 1)
            {
                int resultado = BAL.Control.ContasPagar_BAL.AdicionarContasPagar(txtNomeFornecedor.Text, txtValor.Text, dtpVencimento.Value.ToString().Substring(0, 10));

                if (resultado == 0)
                {
                    MessageBox.Show("Conta a pagar cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Conta a pagar já existente!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 3)
                {
                    MessageBox.Show("Houve um erro desconhecido!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 4)
                {
                    MessageBox.Show("Verifique se os dados inseridos estão no formato correto!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                AtualizaDG();
            }
            else
            {
                int indiceSelecionado = dgContas.CurrentRow.Index;
                int resultado = BAL.Control.ContasPagar_BAL.AtualizaContasPagar(txtNomeFornecedor.Text, txtValor.Text, dtpVencimento.Value.ToString().Substring(0, 10), dgContas.Rows[indiceSelecionado].Cells[0].Value.ToString(), dgContas.Rows[indiceSelecionado].Cells[1].Value.ToString());

                if (resultado == 0)
                {
                    MessageBox.Show("Conta a pagar atualizada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Conta a pagar já existente!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 3)
                {
                    MessageBox.Show("Houve um erro desconhecido!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 4)
                {
                    MessageBox.Show("Verifique se os dados inseridos estão no formato correto!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                AtualizaDG();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabContasPagar);
            tabControl1.TabPages.Add(tabNovoContaPagar);
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;

            ValorSalvar = 0;

            int indiceSelecionado = dgContas.CurrentRow.Index;
            List<DAL.Model.Objetos.ContasPagar> contas = BAL.Control.ContasPagar_BAL.GetContasPagarPorNome(dgContas.Rows[indiceSelecionado].Cells[0].Value.ToString());
            txtNomeFornecedor.Text = contas[0].NomeFornecedor;
            txtValor.Text = contas[0].Valor;
            dtpVencimento.Value = Convert.ToDateTime(contas[0].Vencimento);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = dgContas.CurrentRow.Index;
            BAL.Control.ContasPagar_BAL.RemoveContasPagar(dgContas.Rows[indiceSelecionado].Cells[0].Value.ToString(), dgContas.Rows[indiceSelecionado].Cells[1].Value.ToString(), dgContas.Rows[indiceSelecionado].Cells[2].Value.ToString());
            AtualizaDG();
        }

        private void TelaCadastroContasPagar_Paint(object sender, PaintEventArgs e)
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

        private void txtPesquisaUsuario_TextChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }
        public void AtualizaDG()
        {
            if (!string.IsNullOrEmpty(txtPesquisaUsuario.Text))
            {
                List<DAL.Model.Objetos.ContasPagar> lista = BAL.Control.ContasPagar_BAL.GetContasPagarPorNome(txtPesquisaUsuario.Text);
                dgContas.DataSource = lista;
            }
            else
            {
                List<DAL.Model.Objetos.ContasPagar> lista = BAL.Control.ContasPagar_BAL.GetContasPagar();
                dgContas.DataSource = lista;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(116, 186, 241), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void lblCadastroClientes_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabContasPagar_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);

        }

        private void tabNovoContaPagar_Paint(object sender, PaintEventArgs e)
        {

            SetBackColorDegrade(sender, e);
        }
    }
}
