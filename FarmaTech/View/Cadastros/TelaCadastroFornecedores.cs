using Microsoft.VisualBasic;
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
            btnSalvar.Enabled = false;
            cboEstados.DataSource = Enum.GetValues(typeof(DAL.Model.Enums.Estados));
            AtualizaDG();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoFornecedor);
            tabControl1.TabPages.Remove(tabFornecedores);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabFornecedores);
            tabControl1.TabPages.Add(tabNovoFornecedor);
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;


            int indiceSelecionado = dgUsuarios.CurrentRow.Index;
            string razaoSocial = Interaction.InputBox("Insira a razão social", "Atualiza Fornecedor", "", 200, 200);
            string nomeFantasia = Interaction.InputBox("Insira o nome fantasia", "Atualiza Fornecedor", "", 200, 200);
            string cNPJCPF = Interaction.InputBox("Insira o cpf/cnpj", "Atualiza Fornecedor", "", 200, 200);
            string contato = Interaction.InputBox("Insira o contato", "Atualiza Fornecedor", "", 200, 200);
            string rua = Interaction.InputBox("Insira a rua", "Atualiza Fornecedor", "", 200, 200);
            string numero = Interaction.InputBox("Insira o numero", "Atualiza Fornecedor", "", 200, 200);
            string complemento = Interaction.InputBox("Insira o complemento", "Atualiza Fornecedor", "", 200, 200);
            string cidade = Interaction.InputBox("Insira a cidade", "Atualiza Fornecedor", "", 200, 200);
            string estado = Interaction.InputBox("Insira o estado", "Atualiza Fornecedor", "", 200, 200);
            int resultado = BAL.Control.Enderecos_BAL.AtualizaEndereco(razaoSocial, nomeFantasia, cNPJCPF, contato, rua, numero, complemento, cidade, estado, dgUsuarios.Rows[indiceSelecionado].Cells[3].Value.ToString());
           
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = dgUsuarios.CurrentRow.Index;
            BAL.Control.Enderecos_BAL.RemoveEndereco(dgUsuarios.Rows[indiceSelecionado].Cells[3].Value.ToString());
            AtualizaDG();
        }
        public void AtualizaDG()
        {
            if (!string.IsNullOrEmpty(txtPesquisaUsuario.Text))
            {
                List<DAL.Model.Objetos.Endereco> lista = BAL.Control.Enderecos_BAL.GetEnderecoPorNome(Convert.ToInt32(DAL.Model.Enums.Enderecos.Fornecedores), txtPesquisaUsuario.Text);
                dgUsuarios.DataSource = lista;
            }
            else
            {
                List<DAL.Model.Objetos.Endereco> lista = BAL.Control.Enderecos_BAL.GetEndereco(Convert.ToInt32(DAL.Model.Enums.Enderecos.Fornecedores));
                dgUsuarios.DataSource = lista;
            }
        }

        private void txtPesquisaUsuario_TextChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }
    }
}
