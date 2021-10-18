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
    public partial class TelaCadastroProdutos : Form
    {
        public static int ValorSalvar { get; set; }
        public TelaCadastroProdutos()
        {
            InitializeComponent();
        }

        private void TelaCadastroProdutos_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovoProduto);
            btnSalvar.Enabled = false;
            AtualizaDG();
            cboUnidade.DataSource = BAL.Control.Produtos_BAL.GetUnidades();
        }

        private void TelaCadastroProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabNovoProduto))
            {
                tabControl1.TabPages.Remove(tabNovoProduto);
                tabControl1.TabPages.Add(tabProdutos);
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnNovo.Enabled = true;
            }
            else
            {
                this.Hide();
                lblProd.Text = "Produtos";
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoProduto);
            tabControl1.TabPages.Remove(tabProdutos);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            ValorSalvar = 1;
            txtNome.Clear();
            txtCodigo.Clear();
            txtGrupo.Clear();
            txtLaboratorio.Clear();
            txtPrecoCusto.Clear();
            txtPrecoUnitario.Clear();
            txtQuantidade.Clear();

            lblProd.Text = "Novo\nProduto";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValorSalvar == 0) //Alterar
            {
                if (DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp != DAL.Model.Objetos.UsuarioStatic.NivelAcesso)
                {
                    DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp--;
                }
                int indiceSelecionado = dgProdutos.CurrentRow.Index;
                int resultado = BAL.Control.Produtos_BAL.AtualizaProduto(txtNome.Text, cboUnidade.Text, txtQuantidade.Text, txtCodigo.Text, txtLaboratorio.Text, txtPrecoCusto.Text, txtPrecoUnitario.Text, txtGrupo.Text);
                if (resultado == 0)
                {
                    MessageBox.Show("Produto atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Produto já existente!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int resultado = BAL.Control.Produtos_BAL.AdicionarProduto(txtNome.Text, cboUnidade.Text, txtQuantidade.Text, txtCodigo.Text, txtLaboratorio.Text, txtPrecoCusto.Text, txtPrecoUnitario.Text, txtGrupo.Text);
                if (resultado == 0)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Produto já existente!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            tabControl1.TabPages.Remove(tabNovoProduto);
            tabControl1.TabPages.Add(tabProdutos);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgProdutos.Rows.Count > 0)
            {
                if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 1 || DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp != DAL.Model.Objetos.UsuarioStatic.NivelAcesso)
                {
                    tabControl1.TabPages.Remove(tabProdutos);
                    tabControl1.TabPages.Add(tabNovoProduto);
                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    ValorSalvar = 0;

                    int indiceSelecionado = dgProdutos.CurrentRow.Index;
                    List<DAL.Model.Objetos.Produto> produtos = new List<DAL.Model.Objetos.Produto>();
                    produtos = BAL.Control.Produtos_BAL.GetProdutosPorNome(dgProdutos.Rows[indiceSelecionado].Cells[0].Value.ToString());
                    if (produtos.Count > 0)
                    {
                        txtCodigo.Text = produtos[0].Codigo;
                        txtGrupo.Text = produtos[0].Grupo.ToString();
                        txtLaboratorio.Text = produtos[0].Laboratorio;
                        txtNome.Text = produtos[0].Nome;
                        txtPrecoCusto.Text = produtos[0].PrecoCusto;
                        txtPrecoUnitario.Text = produtos[0].PrecoUnitario;
                        txtQuantidade.Text = produtos[0].Quantidade.ToString();
                        cboUnidade.SelectedItem = produtos[0].Unidade;
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
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // NÃO ESTÁ EXCLUINDO ************************

            if (dgProdutos.Rows.Count > 0)
            {
                if (MessageBox.Show("Confirma a exclusão do registro?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceSelecionado = dgProdutos.CurrentRow.Index;
                    BAL.Control.Produtos_BAL.RemoveProduto(dgProdutos.Rows[indiceSelecionado].Cells[4].Value.ToString());
                    if (DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp != DAL.Model.Objetos.UsuarioStatic.NivelAcesso)
                    {
                        DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp--;
                    }
                    AtualizaDG();
                }
            }
        }

        private void TelaCadastroProdutos_Paint(object sender, PaintEventArgs e)
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
            while (dgProdutos.Rows.Count > 0)
            {
                dgProdutos.Rows.RemoveAt(0);
            }
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 1 || DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp != DAL.Model.Objetos.UsuarioStatic.NivelAcesso)
            {

                if (!string.IsNullOrEmpty(txtPesquisaUsuario.Text)) //Filtrar por razao social
                {
                    List<DAL.Model.Objetos.Produto> lista = BAL.Control.Produtos_BAL.GetProdutosPorNome(txtPesquisaUsuario.Text);

                    foreach (var item in lista)
                    {
                        dgProdutos.Rows.Add(item.Nome, item.Laboratorio, item.Quantidade, item.PrecoUnitario, item.Codigo);
                    }                  
                }
                else
                {
                    List<DAL.Model.Objetos.Produto> lista = BAL.Control.Produtos_BAL.GetProdutos();

                    foreach (var item in lista)
                    {
                        dgProdutos.Rows.Add(item.Nome, item.Laboratorio, item.Quantidade, item.PrecoUnitario, item.Codigo);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void tabNovoProduto_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void tabProdutos_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(116, 186, 241), 45f);
            graphics.FillRectangle(br, gradient_rect);

        }

        private void lblProd_Click(object sender, EventArgs e)
        {

        }

        private void lblPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }
    }
}
