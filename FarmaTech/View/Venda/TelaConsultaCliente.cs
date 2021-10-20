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

namespace FarmaTech.View.Venda
{
    public partial class TelaConsultaCliente : Form
    {
        public TelaConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TelaConsultaCliente_Paint(object sender, PaintEventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(94, 221, 231), Color.FromArgb(139, 148, 250), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        public void AtualizaDG() //Traz todos os registros do BD, dependendo de pessoa fisica ou juridica, e se o usuario tem acesso
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 1 || DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp != DAL.Model.Objetos.UsuarioStatic.NivelAcesso)
            {
                if (rbCpf.Checked)
                {
                    if (!string.IsNullOrEmpty(txtPesquisaCliente.Text)) //Filtrar por razao social
                    {
                        List<DAL.Model.Objetos.Endereco> lista = BAL.Control.Enderecos_BAL.GetEnderecoPorNome(Convert.ToInt32(DAL.Model.Enums.Enderecos.Clientes), txtPesquisaCliente.Text);
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
                    if (!string.IsNullOrEmpty(txtPesquisaCliente.Text)) //Filtrar por razao social
                    {
                        List<DAL.Model.Objetos.Endereco> lista = BAL.Control.Enderecos_BAL.GetEnderecoPorNome(Convert.ToInt32(DAL.Model.Enums.Enderecos.Clientes), txtPesquisaCliente.Text);
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

        private void TelaConsultaCliente_Load(object sender, EventArgs e)
        {             
            AtualizaDG();
        }

        private void txtPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }

        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }

        private void rbCnpj_CheckedChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }
    }
}
