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
            if (TelaLoginController.ValidaCredenciais(txtLogin.Text, txtSenha.Text))
            {
                MessageBox.Show(DateTime.Now.ToString());
                MessageBox.Show($"Nome: {UsuarioStatic.Nome}" +
                    $"\nFilial: {UsuarioStatic.Filial}" +
                    $"\nCargo: {UsuarioStatic.Cargo}" +
                    $"\nContato: {UsuarioStatic.Contato}" +
                    $"\nNivel de acesso: {UsuarioStatic.NivelAcesso}");
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
    }
}
