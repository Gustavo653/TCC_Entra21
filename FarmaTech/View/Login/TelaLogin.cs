using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DAL;
using FarmaTech;
using Microsoft.VisualBasic;

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
            VerificaLogin();
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
        public void VerificaLogin()
        {

            DAL.Model.Consultas.DBHibrido.EscolhaBD = 1;
            DAL.Model.Consultas.DbConnection.EstadoPrograma = 0;
            DAL.Model.Consultas.DbConnection.SetConnectionString();
            DAL.Model.Consultas.DBHibrido.GerarDBTabelas(DAL.Model.Consultas.DBHibrido.EscolhaBD.ToString());
            DAL.Model.Consultas.DBHibrido.ExecutarCommands();
            DAL.Model.Consultas.DBHibrido.ReceberDados();
            DAL.Model.Consultas.DbConnection.EstadoPrograma = 1;
            if (!string.IsNullOrEmpty(txtLogin.Text) && !string.IsNullOrEmpty(txtSenha.Text))
            {
                if (BAL.Control.Login_BAL.ValidaCredenciais(txtLogin.Text, txtSenha.Text))
                {
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
        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerificaLogin();
            }
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Users\Public\Documents\FarmaTech\Commands");
            Directory.CreateDirectory(@"C:\Users\Public\Documents\FarmaTech\Erros");
            Directory.CreateDirectory(@"C:\Users\Public\Documents\FarmaTech\Cupom");
        }
    }
}
