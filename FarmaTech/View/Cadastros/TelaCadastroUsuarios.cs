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
            dgUsuarios.DataSource = BAL.Control.CRUD_Usuarios_BAL.GetUsuarios();
            tabControl1.TabPages.Remove(tabNovoUsuario);
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
            int resultado = 3;
            try
            {
                resultado = BAL.Control.CRUD_Usuarios_BAL.AdicionarUsuario(txtNome.Text, Convert.ToInt32(cbUsuarioFilial.Text), cbUsuarioCargo.Text, txtContato.Text, Convert.ToInt32(nUDNivelAcesso.Value), txtLogin.Text, txtSenha.Text);
            }
            catch(Exception erro)
            {
                MessageBox.Show("gerando log");
                //DAL.Model.Consultas.LogErros.GerarErro(erro); //Corrigir bug de caminho do arquivo
            }
            if(resultado == 0)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(resultado == 1)
            {
                MessageBox.Show("Preencha todos os campos!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resultado == 2)
            {
                MessageBox.Show("Usuário já existente!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Houve um erro desconhecido!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastroUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
