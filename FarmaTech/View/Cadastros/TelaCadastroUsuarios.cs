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
    public partial class TelaCadastroUsuarios : Form
    {
        public static int ValorSalvar { get; set; }
        public TelaCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void TelaCadastroUsuarios_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovoUsuario);
            btnSalvar.Enabled = false;
            AtualizaDG();
            IEnumerable<string> listaEnderecos = BAL.Control.Enderecos_BAL.GetEndereco(Convert.ToInt32(DAL.Model.Enums.Enderecos.Filiais)).Select(x => x.NomeFantasia);
            cbUsuarioFilial.DataSource = listaEnderecos.ToList();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoUsuario);
            tabControl1.TabPages.Remove(tabUsuarios);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            ValorSalvar = 1;
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtContato.Clear();
            cbUsuarioCargo.SelectedIndex = 0;
            cbUsuarioFilial.SelectedIndex = 0;
            nUDNivelAcesso.Value = 1;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValorSalvar == 0)
            {
                int indiceSelecionado = dgUsuarios.CurrentRow.Index;
                int resultado = 1;
                if (!string.IsNullOrEmpty(cbUsuarioFilial.Text) && !string.IsNullOrEmpty(nUDNivelAcesso.Value.ToString()))
                {
                    resultado = BAL.Control.Usuarios_BAL.AtualizaUsuario(txtNome.Text, cbUsuarioFilial.Text, cbUsuarioCargo.Text, txtContato.Text, nUDNivelAcesso.Value.ToString(), txtLogin.Text, txtSenha.Text, dgUsuarios.Rows[indiceSelecionado].Cells[3].Value.ToString());
                }
                if (resultado == 0)
                {
                    MessageBox.Show("Usuário atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Usuário já existente!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else
            {
                int resultado = 1;
                if (!string.IsNullOrEmpty(cbUsuarioFilial.Text) && !string.IsNullOrEmpty(nUDNivelAcesso.Value.ToString()))
                {
                    resultado = BAL.Control.Usuarios_BAL.AdicionarUsuario(txtNome.Text, cbUsuarioFilial.Text, cbUsuarioCargo.Text, txtContato.Text, nUDNivelAcesso.Value.ToString(), txtLogin.Text, txtSenha.Text);
                }
                if (resultado == 0)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabUsuarios);
            tabControl1.TabPages.Add(tabNovoUsuario);
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;

            ValorSalvar = 0;
            int indiceSelecionado = dgUsuarios.CurrentRow.Index;
            List<DAL.Model.Objetos.Usuario> lista = BAL.Control.Usuarios_BAL.GetUsuariosPorNome(dgUsuarios.Rows[indiceSelecionado].Cells[0].Value.ToString());

            txtNome.Text = lista[0].Nome;
            txtLogin.Text = lista[0].Login;
            txtSenha.Clear();
            txtContato.Text = lista[0].Contato;
            cbUsuarioCargo.SelectedItem = lista[0].Cargo;
            cbUsuarioFilial.SelectedItem = lista[0].Filial.ToString();
            nUDNivelAcesso.Value = lista[0].NivelAcesso;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = dgUsuarios.CurrentRow.Index;
            BAL.Control.Usuarios_BAL.RemoveUsuario(dgUsuarios.Rows[indiceSelecionado].Cells[3].Value.ToString());
            AtualizaDG();
        }

        private void TelaCadastroUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void txtPesquisaUsuario_TextChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }
        public void AtualizaDG()
        {
            if (!string.IsNullOrEmpty(txtPesquisaUsuario.Text))
            {
                List<DAL.Model.Objetos.Usuario> lista = BAL.Control.Usuarios_BAL.GetUsuariosPorNome(txtPesquisaUsuario.Text);
                dgUsuarios.DataSource = lista;
            }
            else
            {
                List<DAL.Model.Objetos.Usuario> lista = BAL.Control.Usuarios_BAL.GetUsuarios();
                dgUsuarios.DataSource = lista;
            }
        }

        private void TelaCadastroUsuarios_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }
        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics; Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(108, 226, 252), Color.FromArgb(103, 23, 205), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }
    }
}
