﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (BAL.Control.Login_BAL.ValidaCredenciais("Admin", "Senha"))
            {
                new TelaPrincipal().Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BAL.Control.Login_BAL.ValidaCredenciais("a2", "a2"))
            {
                new TelaPrincipal().Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BAL.Control.Login_BAL.ValidaCredenciais("a", "a"))
            {
                new TelaPrincipal().Show();
                this.Hide();
            }
        }
    }
}
