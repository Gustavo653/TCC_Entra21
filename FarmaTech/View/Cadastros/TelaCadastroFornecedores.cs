using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTech.View
{
    public partial class TelaCadastroFornecedores : Form
    {
        public static int ValorSalvar { get; set; }
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
            btnSalvar.Enabled = false;
            cboEstados.DataSource = Enum.GetValues(typeof(DAL.Model.Enums.Estados));
            AtualizaDG();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabNovoFornecedor))
            {
                tabControl1.TabPages.Remove(tabNovoFornecedor);
                tabControl1.TabPages.Add(tabFornecedores);
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnNovo.Enabled = true;
            }
            else
            {
                this.Hide();
            }
            lblFornecedores.Text = "Fornecedores";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoFornecedor);
            tabControl1.TabPages.Remove(tabFornecedores);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            ValorSalvar = 1;

            lblFornecedores.Text = "Novo\nFornecedor";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValorSalvar == 1)
            {
                int resultado = BAL.Control.Enderecos_BAL.AdicionarEndereco(Convert.ToInt32(DAL.Model.Enums.Enderecos.Fornecedores), txtRazaoSocial.Text, txtNomeFantasia.Text, txtCnpj.Text, txtContato.Text, txtEndereco.Text, txtNumero.Text, txtCompl.Text, txtCidade.Text, cboEstados.Text);

                if (resultado == 0)
                {
                    MessageBox.Show("Fornecedor cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Usuário já existente!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int indiceSelecionado = dgFornecedores.CurrentRow.Index;
                int resultado = BAL.Control.Enderecos_BAL.AtualizaEndereco(txtRazaoSocial.Text, txtNomeFantasia.Text, txtCnpj.Text, txtContato.Text, txtEndereco.Text, txtNumero.Text, txtCompl.Text, txtCidade.Text, cboEstados.Text, dgFornecedores.Rows[indiceSelecionado].Cells[6].Value.ToString());

                if (resultado == 0)
                {
                    MessageBox.Show("Fornecedor atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Fornecedor já existente!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            tabControl1.TabPages.Remove(tabNovoFornecedor);
            tabControl1.TabPages.Add(tabFornecedores);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabFornecedores);
            tabControl1.TabPages.Add(tabNovoFornecedor);
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;


            ValorSalvar = 0;

            int indiceSelecionado = dgFornecedores.CurrentRow.Index;
            List<DAL.Model.Objetos.Endereco> endereco = BAL.Control.Enderecos_BAL.GetEnderecoPorNome(Convert.ToInt32(DAL.Model.Enums.Enderecos.Fornecedores), dgFornecedores.Rows[indiceSelecionado].Cells[0].Value.ToString());
            if (endereco.Count > 0)
            {
                txtRazaoSocial.Text = endereco[0].RazaoSocial;
                txtNomeFantasia.Text = endereco[0].NomeFantasia;
                txtCnpj.Text = endereco[0].CNPJCPF;
                txtContato.Text = endereco[0].Contato;
                txtEndereco.Text = endereco[0].Rua;
                txtNumero.Text = endereco[0].Numero;
                txtCompl.Text = endereco[0].Complemento;
                txtCidade.Text = endereco[0].Cidade;
                cboEstados.Text = endereco[0].Estado;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do registro?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgFornecedores.Rows.Count > 0)
                {
                    int indiceSelecionado = dgFornecedores.CurrentRow.Index;
                    BAL.Control.Enderecos_BAL.RemoveEndereco(dgFornecedores.Rows[indiceSelecionado].Cells[6].Value.ToString());
                    AtualizaDG();
                }
            }
        }
        public void AtualizaDG()
        {
            while (dgFornecedores.Rows.Count > 0)
            {
                dgFornecedores.Rows.RemoveAt(0);
            }

            if (!string.IsNullOrEmpty(txtPesquisaUsuario.Text))
            {
                List<DAL.Model.Objetos.Endereco> lista = BAL.Control.Enderecos_BAL.GetEnderecoPorNome(Convert.ToInt32(DAL.Model.Enums.Enderecos.Fornecedores), txtPesquisaUsuario.Text);

                foreach (var item in lista)
                {
                    dgFornecedores.Rows.Add(item.NomeFantasia, item.CNPJCPF, item.Rua, item.Numero, item.Cidade, item.Estado, item.Contato);
                }
                //dgFornecedores.DataSource = lista;
            }
            else
            {
                List<DAL.Model.Objetos.Endereco> lista = BAL.Control.Enderecos_BAL.GetEndereco(Convert.ToInt32(DAL.Model.Enums.Enderecos.Fornecedores));

                foreach (var item in lista)
                {
                    dgFornecedores.Rows.Add(item.NomeFantasia, item.CNPJCPF, item.Rua, item.Numero, item.Cidade, item.Estado, item.Contato);
                }

                //dgFornecedores.DataSource = lista;
            }
        }

        private void txtPesquisaUsuario_TextChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }

        private void TelaCadastroFornecedores_Paint(object sender, PaintEventArgs e)
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

        private void tabFornecedores_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void tabNovoFornecedor_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(116, 186, 241), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }
    }
}
