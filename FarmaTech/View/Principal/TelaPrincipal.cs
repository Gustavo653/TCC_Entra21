using FarmaTech.View;
using FarmaTech.View.Principal;
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

namespace FarmaTech
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            new TelaCadastroUsuarios().Show();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            new TelaSair().Show();
        }

        private void MenuFiliais_Click(object sender, EventArgs e)
        {
            new TelaCadastroFiliais().Show();
        }

        private void MenuUnidades_Click(object sender, EventArgs e)
        {
            new TelaCadastroUnidades().Show();
        }

        private void MenuPdv_Click(object sender, EventArgs e)
        {
            new TelaVenda().Show();
        }

        private void MenuFornecedores_Click(object sender, EventArgs e)
        {
            new TelaCadastroFornecedores().Show();
        }

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            new TelaCadastroCliente().Show();
        }

        private void MenuPdv_Click_1(object sender, EventArgs e)
        {
            bool caixaAberto = false;

            if (!caixaAberto)
            {
                new TelaAberturaDeCaixa().Show();
            }
            else
            {
                new TelaVenda().Show();
            }

        }


        private void MenuProdutos_Click(object sender, EventArgs e)
        {
            new TelaCadastroProdutos().Show();
        }

        private void MenuContasPagar_Click(object sender, EventArgs e)
        {
            new TelaCadastroContasPagar().Show();
        }

        private void MenuConvenios_Click(object sender, EventArgs e)
        {
            new TelaCadastroConvenios().Show();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = DAL.Model.Objetos.UsuarioStatic.Nome;
        }

        private void TelaPrincipal_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics; Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            //RGB vermelho verde azul
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(108, 226, 252), Color.FromArgb(103, 23, 205), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

    }
}
