using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DAL;
using FarmaTech;

namespace FarmaTech
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            new TelaSobre().Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (BAL.Control.Login_BAL.ValidaCredenciais(txtLogin.Text, txtSenha.Text))
            {
                MessageBox.Show(DateTime.Now.ToString());
                MessageBox.Show($"Nome: {DAL.Model.Objetos.UsuarioStatic.Nome}" +
                    $"\nFilial: {DAL.Model.Objetos.UsuarioStatic.Filial}" +
                    $"\nCargo: {DAL.Model.Objetos.UsuarioStatic.Cargo}" +
                    $"\nContato: {DAL.Model.Objetos.UsuarioStatic.Contato}" +
                    $"\nNivel de acesso: {DAL.Model.Objetos.UsuarioStatic.NivelAcesso}");
                new TelaPrincipal().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Inválido!");
                txtSenha.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new TelaSair().Show();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                btnNaoVer.BringToFront();
                txtSenha.PasswordChar = '\0';
            }
        }

        private void btnNaoVer_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '\0')
            {
                btnVer.BringToFront();
                txtSenha.PasswordChar = '*';
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (BAL.Control.Login_BAL.ValidaCredenciais(txtLogin.Text, txtSenha.Text))
                {
                    MessageBox.Show(DateTime.Now.ToString());
                    MessageBox.Show($"Nome: {DAL.Model.Objetos.UsuarioStatic.Nome}" +
                        $"\nFilial: {DAL.Model.Objetos.UsuarioStatic.Filial}" +
                        $"\nCargo: {DAL.Model.Objetos.UsuarioStatic.Cargo}" +
                        $"\nContato: {DAL.Model.Objetos.UsuarioStatic.Contato}" +
                        $"\nNivel de acesso: {DAL.Model.Objetos.UsuarioStatic.NivelAcesso}");
                    new TelaPrincipal().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Inválido!");
                    txtSenha.Clear();
                }
            }
        }
    }
}
