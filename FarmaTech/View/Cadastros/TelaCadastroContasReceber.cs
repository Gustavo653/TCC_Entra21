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

namespace FarmaTech.View.Principal
{
    public partial class TelaCadastroContasReceber : Form
    {
        public static int ValorSalvar { get; set; }
        public TelaCadastroContasReceber()
        {
            InitializeComponent();
        }

        private void TelaContasReceber_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovoContaReceber);
            btnSalvar.Enabled = false;
            dtpVencimento.Value = DateTime.Now.Date;
            AtualizaDG();
        }

        private void TelaContasReceber_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void TelaContasReceber_Paint(object sender, PaintEventArgs e)
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabNovoContaReceber))
            {
                tabControl1.TabPages.Remove(tabNovoContaReceber);
                tabControl1.TabPages.Add(tabContasReceber);
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnNovo.Enabled = true;
            }
            else
            {
                this.Hide();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoContaReceber);
            tabControl1.TabPages.Remove(tabContasReceber);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            txtNomeFornecedor.Clear();
            txtValor.Clear();
            dtpVencimento.Value = DateTime.Now.Date;

            ValorSalvar = 1;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabContasReceber);
            tabControl1.TabPages.Add(tabNovoContaReceber);
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

            ValorSalvar = 0;
            int indiceSelecionado = dgContasReceber.CurrentRow.Index;
            List<DAL.Model.Objetos.ContasReceber> contas = BAL.Control.ContasReceber_BAL.GetContasReceberPorNome(dgContasReceber.Rows[indiceSelecionado].Cells[0].Value.ToString());
            if (contas.Count > 0)
            {
                txtNomeFornecedor.Text = contas[0].NomeFornecedor;
                txtValor.Text = contas[0].Valor;
                dtpVencimento.Value = Convert.ToDateTime(contas[0].Vencimento);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do registro?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int indiceSelecionado = dgContasReceber.CurrentRow.Index;
                BAL.Control.ContasReceber_BAL.RemoveContasReceber(dgContasReceber.Rows[indiceSelecionado].Cells[0].Value.ToString(), dgContasReceber.Rows[indiceSelecionado].Cells[1].Value.ToString(), dgContasReceber.Rows[indiceSelecionado].Cells[2].Value.ToString());
                AtualizaDG();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {          
            if (ValorSalvar == 1)
            {
                int resultado = BAL.Control.ContasReceber_BAL.AdicionarContasReceber(txtNomeFornecedor.Text, txtValor.Text, dtpVencimento.Value.ToString().Substring(0, 10));

                if (resultado == 0)
                {
                    MessageBox.Show("Conta a receber cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Usuário sem filial!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int indiceSelecionado = dgContasReceber.CurrentRow.Index;
                int resultado = BAL.Control.ContasReceber_BAL.AtualizaContasReceber(txtNomeFornecedor.Text, txtValor.Text, dtpVencimento.Value.ToString().Substring(0, 10), dgContasReceber.Rows[indiceSelecionado].Cells[0].Value.ToString(), dgContasReceber.Rows[indiceSelecionado].Cells[1].Value.ToString());

                if (resultado == 0)
                {
                    MessageBox.Show("Conta a receber atualizada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Conta a receber já existente!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            tabControl1.TabPages.Remove(tabNovoContaReceber);
            tabControl1.TabPages.Add(tabContasReceber);
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        private void txtPesquisaUsuario_TextChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }
        public void AtualizaDG()
        {
            while (dgContasReceber.Rows.Count > 0)
            {
                dgContasReceber.Rows.RemoveAt(0);
            }
            if (!string.IsNullOrEmpty(txtPesquisaUsuario.Text))
            {
                List<DAL.Model.Objetos.ContasReceber> lista = BAL.Control.ContasReceber_BAL.GetContasReceberPorNome(txtPesquisaUsuario.Text);

                foreach (var item in lista)
                {
                    dgContasReceber.Rows.Add(item.NomeFornecedor, item.Valor, item.Vencimento);
                }
            }
            else
            {
                List<DAL.Model.Objetos.ContasReceber> lista = BAL.Control.ContasReceber_BAL.GetContasReceber();

                foreach (var item in lista)
                {
                    dgContasReceber.Rows.Add(item.NomeFornecedor, item.Valor, item.Vencimento);
                }
            }
        }

        private void txtNomeFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text.Length > 50)
            {
                txtNomeFornecedor.Text = txtNomeFornecedor.Text.Substring(0, txtNomeFornecedor.TextLength - 1);
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtValor.Text.Length > 12)
            {
                txtValor.Text = txtValor.Text.Substring(0, txtValor.TextLength - 1);
            }
        }
    }
}
