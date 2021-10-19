using Microsoft.VisualBasic;
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
    public partial class TelaCadastroFiliais : Form
    {
        public static int ValorSalvar { get; set; }
        public TelaCadastroFiliais()
        {
            InitializeComponent();
        }

        private void TelaCadastroFiliais_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovoFilial);
            btnSalvar.Enabled = false;
            cboEstados.DataSource = Enum.GetValues(typeof(DAL.Model.Enums.Estados));
            AtualizaDG();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabNovoFilial))
            {
                tabControl1.TabPages.Remove(tabNovoFilial);
                tabControl1.TabPages.Add(tabFiliais);
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnNovo.Enabled = true;
            }
            else
            {
                this.Hide();
            }
            lblFiliais.Text = "Filiais";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoFilial);
            tabControl1.TabPages.Remove(tabFiliais);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            ValorSalvar = 1;

            lblFiliais.Text = "Nova Filial";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValorSalvar == 1)
            {
                int resultado = BAL.Control.Enderecos_BAL.AdicionarEndereco(Convert.ToInt32(DAL.Model.Enums.Enderecos.Filiais), txtRazaoSocial.Text, txtNomeFantasia.Text, txtCnpj.Text, txtContato.Text, txtEndereco.Text, txtNumero.Text, txtCompl.Text, txtCidade.Text, cboEstados.Text);

                if (resultado == 0)
                {
                    MessageBox.Show("Filial cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Filial já existente!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int indiceSelecionado = dgFiliais.CurrentRow.Index;
                int resultado = BAL.Control.Enderecos_BAL.AtualizaEndereco(txtRazaoSocial.Text, txtNomeFantasia.Text, txtCnpj.Text, txtContato.Text, txtEndereco.Text, txtNumero.Text, txtCompl.Text, txtCidade.Text, cboEstados.Text, dgFiliais.Rows[indiceSelecionado].Cells[3].Value.ToString());

                if (resultado == 0)
                {
                    MessageBox.Show("Filial atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Filial já existente!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            tabControl1.TabPages.Remove(tabNovoFilial);
            tabControl1.TabPages.Add(tabFiliais);
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabFiliais);
            tabControl1.TabPages.Add(tabNovoFilial);
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;

            ValorSalvar = 0;

            int indiceSelecionado = dgFiliais.CurrentRow.Index;
            List<DAL.Model.Objetos.Endereco> endereco = BAL.Control.Enderecos_BAL.GetEnderecoPorNome(Convert.ToInt32(DAL.Model.Enums.Enderecos.Filiais), dgFiliais.Rows[indiceSelecionado].Cells[1].Value.ToString());
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
                int indiceSelecionado = dgFiliais.CurrentRow.Index;
                BAL.Control.Enderecos_BAL.RemoveEndereco(dgFiliais.Rows[indiceSelecionado].Cells[3].Value.ToString());
                BAL.Control.Enderecos_BAL.RemoveEnderecoTodasTabelas(dgFiliais.Rows[indiceSelecionado].Cells[1].Value.ToString());
                AtualizaDG();
            }
        }
        public void AtualizaDG()
        {
            while (dgFiliais.Rows.Count > 0)
            {
                dgFiliais.Rows.RemoveAt(0);
            }

            if (!string.IsNullOrEmpty(txtPesquisaUsuario.Text))
            {
                List<DAL.Model.Objetos.Endereco> lista = BAL.Control.Enderecos_BAL.GetEnderecoPorNome(Convert.ToInt32(DAL.Model.Enums.Enderecos.Filiais), txtPesquisaUsuario.Text);

                foreach (var item in lista)
                {
                    dgFiliais.Rows.Add(item.NomeFantasia, item.CNPJCPF, item.Contato, item.Rua, item.Numero, item.Cidade, item.Estado);
                }

            }
            else
            {
                List<DAL.Model.Objetos.Endereco> lista = BAL.Control.Enderecos_BAL.GetEndereco(Convert.ToInt32(DAL.Model.Enums.Enderecos.Filiais));

                foreach (var item in lista)
                {
                    dgFiliais.Rows.Add(item.NomeFantasia, item.CNPJCPF, item.Contato, item.Rua, item.Numero, item.Cidade, item.Estado);
                }
            }
        }
        private void TelaCadastroFiliais_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void txtPesquisaUsuario_TextChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }

        private void TelaCadastroFiliais_Paint(object sender, PaintEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(116, 186, 241), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void tabFiliais_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void tabNovoFilial_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void txtRazaoSocial_TextChanged(object sender, EventArgs e)
        {
            if (txtRazaoSocial.Text.Length > 50)
            {
                txtRazaoSocial.Text = txtRazaoSocial.Text.Substring(0, txtRazaoSocial.TextLength - 1);
            }
        }

        private void txtNomeFantasia_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeFantasia.Text.Length > 50)
            {
                txtNomeFantasia.Text = txtNomeFantasia.Text.Substring(0, txtNomeFantasia.TextLength - 1);
            }
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            if (txtEndereco.Text.Length > 30)
            {
                txtEndereco.Text = txtEndereco.Text.Substring(0, txtEndereco.TextLength - 1);
            }
        }

        private void txtCompl_TextChanged(object sender, EventArgs e)
        {
            if (txtCompl.Text.Length > 30)
            {
                txtCompl.Text = txtCompl.Text.Substring(0, txtCompl.TextLength - 1);
            }
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            if (txtCidade.Text.Length > 30)
            {
                txtCidade.Text = txtCidade.Text.Substring(0, txtCidade.TextLength - 1);
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text.Length > 4)
            {
                txtNumero.Text = txtNumero.Text.Substring(0, txtNumero.TextLength - 1);
            }
        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {
            if (txtCnpj.Text.Length > 14)
            {
                txtCnpj.Text = txtCnpj.Text.Substring(0, txtCnpj.TextLength - 1);
            }
        }

        private void txtContato_TextChanged(object sender, EventArgs e)
        {
            if (txtContato.Text.Length > 15)
            {
                txtContato.Text = txtContato.Text.Substring(0, txtContato.TextLength - 1);
            }
        }
    }
}
