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
            cbNivelAcesso.DataSource = Enum.GetValues(typeof(DAL.Model.Enums.NivelAcesso));
            cbNivelAcesso.SelectedIndex = 0;
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
            cbNivelAcesso.SelectedIndex = 0;
            if (cbUsuarioFilial.Items.Count > 0)
                cbUsuarioFilial.SelectedIndex = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabNovoUsuario))
            {
                tabControl1.TabPages.Remove(tabNovoUsuario);
                tabControl1.TabPages.Add(tabUsuarios);
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValorSalvar == 0)
            {
                int indiceSelecionado = dgUsuarios.CurrentRow.Index;
                int resultado = 1;
                if (!string.IsNullOrEmpty(cbUsuarioFilial.Text))
                {
                    if (dgUsuarios.Rows[indiceSelecionado].Cells[2].Value.ToString() != DAL.Model.Objetos.UsuarioStatic.Contato)
                        resultado = BAL.Control.Usuarios_BAL.AtualizaUsuario(txtNome.Text, cbUsuarioFilial.Text, txtContato.Text, cbNivelAcesso.Text, txtLogin.Text, txtSenha.Text, dgUsuarios.Rows[indiceSelecionado].Cells[2].Value.ToString());
                    else
                        MessageBox.Show("Você não pode atualizar o usuário ativo!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!string.IsNullOrEmpty(cbUsuarioFilial.Text))
                {
                    resultado = BAL.Control.Usuarios_BAL.AdicionarUsuario(txtNome.Text, cbUsuarioFilial.Text, txtContato.Text, cbNivelAcesso.Text, txtLogin.Text, txtSenha.Text);
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

            tabControl1.TabPages.Remove(tabNovoUsuario);
            tabControl1.TabPages.Add(tabUsuarios);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
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

            if (lista.Count > 0)
            {
                txtNome.Text = lista[0].Nome;
                txtLogin.Text = lista[0].Login;
                txtSenha.Text = lista[0].Senha;
                txtContato.Text = lista[0].Contato;
                cbNivelAcesso.SelectedIndex = 0;
                cbUsuarioFilial.SelectedItem = lista[0].Filial.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do registro?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int indiceSelecionado = dgUsuarios.CurrentRow.Index;
                if (dgUsuarios.Rows[indiceSelecionado].Cells[2].Value.ToString() != DAL.Model.Objetos.UsuarioStatic.Contato)
                    BAL.Control.Usuarios_BAL.RemoveUsuario(dgUsuarios.Rows[indiceSelecionado].Cells[2].Value.ToString());
                else
                    MessageBox.Show("Você não pode remover o usuário ativo!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AtualizaDG();
            }

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
            while (dgUsuarios.Rows.Count > 0)
            {
                dgUsuarios.Rows.RemoveAt(0);
            }
            if (!string.IsNullOrEmpty(txtPesquisaUsuario.Text))
            {
                List<DAL.Model.Objetos.Usuario> lista = BAL.Control.Usuarios_BAL.GetUsuariosPorNome(txtPesquisaUsuario.Text);

                foreach (var item in lista)
                {
                    dgUsuarios.Rows.Add(item.Nome, item.Filial, item.Contato, item.NivelAcesso, item.Login, item.Senha);
                }

            }
            else
            {
                List<DAL.Model.Objetos.Usuario> lista = BAL.Control.Usuarios_BAL.GetUsuarios();

                foreach (var item in lista)
                {
                    dgUsuarios.Rows.Add(item.Nome, item.Filial, item.Contato, item.NivelAcesso, item.Login, item.Senha);
                }


            }
        }

        private void TelaCadastroUsuarios_Paint(object sender, PaintEventArgs e)
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

        private void tabUsuarios_Paint(object sender, PaintEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void tabNovoUsuario_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void cbNivelAcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNivelAcesso.SelectedIndex > 1)
            {
                if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 3)
                {
                    MessageBox.Show("Você não pode inserir um usuário com nível maior que 2!");
                    cbNivelAcesso.SelectedIndex = 0;
                }
            }
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text.Length > 50)
            {
                txtNome.Text = txtNome.Text.Substring(0, txtNome.Text.Length - 1);
            }
        }
        private void txtContato_TextChanged(object sender, EventArgs e)
        {
            if (txtContato.Text.Length > 14)
            {
                txtContato.Text = txtContato.Text.Substring(0, txtContato.TextLength - 1);
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length > 50)
            {
                txtLogin.Text = txtLogin.Text.Substring(0, txtLogin.TextLength - 1);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text.Length > 128)
            {
                txtSenha.Text = txtSenha.Text.Substring(0, txtSenha.TextLength - 1);
            }
        }

        private void txtContato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }
    }
}
