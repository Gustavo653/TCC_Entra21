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
    public partial class TelaCadastroUnidades : Form
    {
        public static int ValorSalvar { get; set; }
        public TelaCadastroUnidades()
        {
            InitializeComponent();
        }

        private void TelaCadastroUnidades_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovaUnidade);
            btnSalvar.Enabled = false;
            AtualizaDG();
        }

        private void TelaCadastroUnidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovaUnidade);
            tabControl1.TabPages.Remove(tabUnidades);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            ValorSalvar = 1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValorSalvar == 1)
            {
                int resultado = BAL.Control.Unidades_BAL.AdicionarUnidade(txtNome.Text);
                if (resultado == 0)
                {
                    MessageBox.Show("Unidade cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Unidade já existente!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp--;
                int indiceSelecionado = dgUnidades.CurrentRow.Index;
                int resultado = BAL.Control.Unidades_BAL.AtualizaUnidade(txtNome.Text, dgUnidades.Rows[indiceSelecionado].Cells[0].Value.ToString());
                if (resultado == 0)
                {
                    MessageBox.Show("Unidade atualizada com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Unidade já existente!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (dgUnidades.Rows.Count > 0)
            {


                if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 1 || DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp != DAL.Model.Objetos.UsuarioStatic.NivelAcesso)
                {
                    tabControl1.TabPages.Remove(tabUnidades);
                    tabControl1.TabPages.Add(tabNovaUnidade);
                    btnSalvar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnNovo.Enabled = false;

                    ValorSalvar = 0;

                    int indiceSelecionado = dgUnidades.CurrentRow.Index;
                    txtNome.Text = dgUnidades.Rows[indiceSelecionado].Cells[0].Value.ToString();
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
            if (dgUnidades.Rows.Count > 0)
            {
                int indiceSelecionado = dgUnidades.CurrentRow.Index;
                BAL.Control.Unidades_BAL.RemoveUnidade(dgUnidades.Rows[indiceSelecionado].Cells[0].Value.ToString());
                DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp--;
                AtualizaDG();
            }
        }
        public void AtualizaDG()
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 1 || DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp != DAL.Model.Objetos.UsuarioStatic.NivelAcesso)
            {
                int tamanhoDG = dgUnidades.Rows.Count;
                while (tamanhoDG > 0)
                {
                    dgUnidades.Rows.RemoveAt(0);
                    tamanhoDG--;
                }
                if (!string.IsNullOrEmpty(txtPesquisaUsuario.Text))
                {
                    List<string> lista = BAL.Control.Unidades_BAL.GetUnidadesPorNome(txtPesquisaUsuario.Text);
                    foreach (var item in lista)
                    {
                        dgUnidades.Rows.Add(item);
                    }
                }
                else
                {
                    List<string> lista = BAL.Control.Unidades_BAL.GetUnidades();
                    foreach (var item in lista)
                    {
                        dgUnidades.Rows.Add(item);
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

        private void TelaCadastroUnidades_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }
        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics; Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(108, 226, 252), Color.FromArgb(103, 23, 205), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void txtPesquisaUsuario_TextChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }
    }
}
