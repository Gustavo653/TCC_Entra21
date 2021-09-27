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
    public partial class TelaCadastroUsuarios : Form
    {
        public TelaCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void TelaCadastroUsuarios_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovoUsuario);
            AtualizaDG();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoUsuario);
            tabControl1.TabPages.Remove(tabUsuarios);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int resultado = 1;
            if (!string.IsNullOrEmpty(cbUsuarioFilial.Text) && !string.IsNullOrEmpty(nUDNivelAcesso.Value.ToString()))
            {
                resultado = BAL.Control.CRUD_Usuarios_BAL.AdicionarUsuario(txtNome.Text, cbUsuarioFilial.Text, cbUsuarioCargo.Text, txtContato.Text, nUDNivelAcesso.Value.ToString(), txtLogin.Text, txtSenha.Text);
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = dgUsuarios.CurrentRow.Index;
            string nome = Interaction.InputBox("Insira o nome", "Atualiza Usuario", "", 200, 200);
            string filial = Interaction.InputBox("Insira a filial", "Atualiza Usuario", "", 200, 200);
            string cargo = Interaction.InputBox("Insira o cargo", "Atualiza Usuario", "", 200, 200);
            string contato = Interaction.InputBox("Insira o contato", "Atualiza Usuario", "", 200, 200);
            string nivelAcesso = Interaction.InputBox("Insira o nível de acesso", "Atualiza Usuario", "", 200, 200);
            string login = Interaction.InputBox("Insira o login", "Atualiza Usuario", "", 200, 200);
            string senha = Interaction.InputBox("Insira a senha", "Atualiza Usuario", "", 200, 200);
            int resultado = 1;
            if (!string.IsNullOrEmpty(filial) && !string.IsNullOrEmpty(nivelAcesso))
            {
                resultado = BAL.Control.CRUD_Usuarios_BAL.AtualizaUsuario(nome, filial, cargo, contato, nivelAcesso, login, senha, dgUsuarios.Rows[indiceSelecionado].Cells[3].Value.ToString());
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = dgUsuarios.CurrentRow.Index;
            BAL.Control.CRUD_Usuarios_BAL.RemoveUsuario(dgUsuarios.Rows[indiceSelecionado].Cells[3].Value.ToString());
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
                List<DAL.Model.Objetos.Usuario> lista = BAL.Control.CRUD_Usuarios_BAL.GetUsuariosPorNome(txtPesquisaUsuario.Text);
                dgUsuarios.DataSource = lista;
            }
            else
            {
                List<DAL.Model.Objetos.Usuario> lista = BAL.Control.CRUD_Usuarios_BAL.GetUsuarios();
                dgUsuarios.DataSource = lista;
            }
        }
    }
}
