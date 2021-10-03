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
    public partial class TelaCadastroCliente : Form
    {
        public static int ValorSalvar { get; set; }
        public TelaCadastroCliente()
        {
            InitializeComponent();
        }

        private void TelaCadastroCliente_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovoCliente);
            cboEstados.DataSource = Enum.GetValues(typeof(DAL.Model.Enums.Estados));
            AtualizaDG();

            btnSalvar.Enabled = false;

        }

        private void TelaCadastroCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgClientes.Rows.Count > 0)
            {
                if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 1 || DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp != DAL.Model.Objetos.UsuarioStatic.NivelAcesso)
                {
                    tabControl1.TabPages.Remove(tabClientes);
                    tabControl1.TabPages.Add(tabNovoCliente);
                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    ValorSalvar = 0;

                    int indiceSelecionado = dgClientes.CurrentRow.Index;
                    List<DAL.Model.Objetos.Endereco> endereco = new List<DAL.Model.Objetos.Endereco>();
                    if (rbCpf.Checked)
                    {
                        endereco = BAL.Control.Enderecos_BAL.GetEnderecoPorNome(Convert.ToInt32(DAL.Model.Enums.Enderecos.Clientes), dgClientes.Rows[indiceSelecionado].Cells[0].Value.ToString());
                        txtRazaoSocial.Text = endereco[0].NomeFantasia;
                        rbFisica.Checked = true;
                        rbJuridica.Checked = false;
                    }
                    else
                    {
                        endereco = BAL.Control.Enderecos_BAL.GetEnderecoPorNome(Convert.ToInt32(DAL.Model.Enums.Enderecos.Clientes), dgClientes.Rows[indiceSelecionado].Cells[1].Value.ToString());
                        txtRazaoSocial.Text = endereco[0].RazaoSocial;
                        rbFisica.Checked = false;
                        rbJuridica.Checked = true;
                    }
                    txtNomeFantasia.Text = endereco[0].NomeFantasia;
                    txtCnpj.Text = endereco[0].CNPJCPF;
                    txtContato.Text = endereco[0].Contato;
                    txtEndereco.Text = endereco[0].Rua;
                    txtNumero.Text = endereco[0].Numero;
                    txtCompl.Text = endereco[0].Complemento;
                    txtCidade.Text = endereco[0].Cidade;
                    cboEstados.Text = endereco[0].Estado;
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Deseja aumentar o nivel de acesso?", "Nivel Acesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string login = Interaction.InputBox("Insira seu login", "Login", "", 200, 200);
                        string senha = Interaction.InputBox("Insira seu login", "Login", "", 200, 200);
                        if (BAL.Control.NivelAcessoUsuario_BAL.VerificaPermissao(login, senha))
                        {
                            DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp++;
                        }
                    }
                }
            }
        }


        public void AtualizaDG()
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 1 || DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp != DAL.Model.Objetos.UsuarioStatic.NivelAcesso)
            {
                if (rbCpf.Checked)
                {
                    if (!string.IsNullOrEmpty(txtPesquisaUsuario.Text)) //Filtrar por razao social
                    {
                        List<DAL.Model.Objetos.Endereco> lista = BAL.Control.Enderecos_BAL.GetEnderecoPorNome(Convert.ToInt32(DAL.Model.Enums.Enderecos.Clientes), txtPesquisaUsuario.Text);
                        List<EnderecoParcial> listaParcial = new List<EnderecoParcial>();
                        foreach (var item in lista)
                        {
                            if (item.RazaoSocial == "pessoaFisica")
                            {
                                EnderecoParcial endereco = new EnderecoParcial(item.NomeFantasia, item.CNPJCPF, item.Contato, item.Rua, item.Numero, item.Complemento, item.Cidade, item.Estado);
                                listaParcial.Add(endereco);
                            }
                        }
                        dgClientes.DataSource = listaParcial;
                    }
                    else
                    {
                        List<DAL.Model.Objetos.Endereco> lista = BAL.Control.Enderecos_BAL.GetEndereco(Convert.ToInt32(DAL.Model.Enums.Enderecos.Clientes));
                        List<EnderecoParcial> listaParcial = new List<EnderecoParcial>();
                        foreach (var item in lista)
                        {
                            if (item.RazaoSocial == "pessoaFisica")
                            {
                                EnderecoParcial endereco = new EnderecoParcial(item.NomeFantasia, item.CNPJCPF, item.Contato, item.Rua, item.Numero, item.Complemento, item.Cidade, item.Estado);
                                listaParcial.Add(endereco);
                            }
                        }
                        dgClientes.DataSource = listaParcial;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtPesquisaUsuario.Text)) //Filtrar por razao social
                    {
                        List<DAL.Model.Objetos.Endereco> lista = BAL.Control.Enderecos_BAL.GetEnderecoPorNome(Convert.ToInt32(DAL.Model.Enums.Enderecos.Clientes), txtPesquisaUsuario.Text);
                        lista.RemoveAll(x => x.RazaoSocial == "pessoaFisica");
                        dgClientes.DataSource = lista;
                    }
                    else
                    {
                        List<DAL.Model.Objetos.Endereco> lista = BAL.Control.Enderecos_BAL.GetEndereco(Convert.ToInt32(DAL.Model.Enums.Enderecos.Clientes));
                        lista.RemoveAll(x => x.RazaoSocial == "pessoaFisica");
                        dgClientes.DataSource = lista;
                    }
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja aumentar o nivel de acesso?", "Nivel Acesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string login = Interaction.InputBox("Insira seu login", "Login", "", 200, 200);
                    string senha = Interaction.InputBox("Insira seu login", "Login", "", 200, 200);
                    if (BAL.Control.NivelAcessoUsuario_BAL.VerificaPermissao(login, senha))
                    {
                        DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp++;
                    }
                }
            }
        }
        private void txtPesquisaUsuario_TextChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblRazaoSocial.Text = "Razão Social:";
            lblNomeFantasia.Visible = true;
            txtNomeFantasia.Visible = true;
            lblCnpj.Text = "CNPJ:";

        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblRazaoSocial.Text = "Nome:";
            lblNomeFantasia.Visible = false;
            txtNomeFantasia.Visible = false;
            lblCnpj.Text = "CPF:";

        }

        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }

        private void rbCnpj_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }

        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(103, 23, 205), Color.FromArgb(108, 226, 252), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void TelaCadastroCliente_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabNovoCliente))
            {
                tabControl1.TabPages.Remove(tabNovoCliente);
                tabControl1.TabPages.Add(tabClientes);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgClientes.Rows.Count > 0)
            {
                if (MessageBox.Show("Confirma a exclusão do registro?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceSelecionado = dgClientes.CurrentRow.Index;
                    BAL.Control.Enderecos_BAL.RemoveEndereco(dgClientes.Rows[indiceSelecionado].Cells[3].Value.ToString());
                    if (DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp != DAL.Model.Objetos.UsuarioStatic.NivelAcesso)
                    {
                        DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp--;
                    }
                    AtualizaDG();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValorSalvar == 0) //Alterar
            {
                if (DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp != DAL.Model.Objetos.UsuarioStatic.NivelAcesso)
                {
                    DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp--;
                }
                int indiceSelecionado = dgClientes.CurrentRow.Index;

                int resultado = 1;
                if (rbJuridica.Checked)
                {
                    resultado = BAL.Control.Enderecos_BAL.AtualizaEndereco(txtRazaoSocial.Text, txtNomeFantasia.Text, txtCnpj.Text, txtContato.Text, txtEndereco.Text, txtNumero.Text, txtCompl.Text, txtCidade.Text, cboEstados.Text, dgClientes.Rows[indiceSelecionado].Cells[3].Value.ToString());
                }
                if (rbFisica.Checked)
                {
                    resultado = BAL.Control.Enderecos_BAL.AtualizaEndereco("pessoaFisica", txtNomeFantasia.Text, txtCnpj.Text, txtContato.Text, txtEndereco.Text, txtNumero.Text, txtCompl.Text, txtCidade.Text, cboEstados.Text, dgClientes.Rows[indiceSelecionado].Cells[3].Value.ToString());
                }

                if (resultado == 0)
                {
                    MessageBox.Show("Cliente atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else if (ValorSalvar == 1) //Adicionar
            {
                int resultado = 1;
                if (rbJuridica.Checked)
                {
                    resultado = BAL.Control.Enderecos_BAL.AdicionarEndereco(Convert.ToInt32(DAL.Model.Enums.Enderecos.Clientes), txtRazaoSocial.Text, txtNomeFantasia.Text, txtCnpj.Text, txtContato.Text, txtEndereco.Text, txtNumero.Text, txtCompl.Text, txtCidade.Text, cboEstados.Text);
                }
                if (rbFisica.Checked)
                {
                    resultado = BAL.Control.Enderecos_BAL.AdicionarEndereco(Convert.ToInt32(DAL.Model.Enums.Enderecos.Clientes), "pessoaFisica", txtRazaoSocial.Text, txtCnpj.Text, txtContato.Text, txtEndereco.Text, txtNumero.Text, txtCompl.Text, txtCidade.Text, cboEstados.Text);
                }

                if (resultado == 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



            tabControl1.TabPages.Remove(tabNovoCliente);
            tabControl1.TabPages.Add(tabClientes);
            btnSalvar.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoCliente);
            tabControl1.TabPages.Remove(tabClientes);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            ValorSalvar = 1;
            txtRazaoSocial.Clear();
            txtNomeFantasia.Clear();
            txtCnpj.Clear();
            txtContato.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtCompl.Clear();
            txtCidade.Clear();
            cboEstados.SelectedIndex = 0;
        }
    }
    public class EnderecoParcial
    {
        public string RazaoSocial { get; set; }
        public string CNPJCPF { get; set; }
        public string Contato { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public EnderecoParcial(string razaoSocial, string cNPJCPF, string contato, string rua, string numero, string complemento, string cidade, string estado)
        {
            RazaoSocial = razaoSocial;
            CNPJCPF = cNPJCPF;
            Contato = contato;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
