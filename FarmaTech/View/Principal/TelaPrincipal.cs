using FarmaTech.View;
using FarmaTech.View.Principal;
using FarmaTech.View.Requisicoes;
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
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 2)
            {
                MessageBox.Show("Você não é autorizado!");
            }
            else
            {
                new TelaCadastroUsuarios().Show();
            }
        }

        private void MenuFiliais_Click(object sender, EventArgs e)
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 3)
            {
                MessageBox.Show("Você não é autorizado!");
            }
            else
            {
                new TelaCadastroFiliais().Show();
            }
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
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 2)
            {
                MessageBox.Show("Você não é autorizado!");
            }
            else
            {
                new TelaCadastroFornecedores().Show();
            }
        }

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            new TelaCadastroCliente().Show();
        }

        private void MenuPdv_Click_1(object sender, EventArgs e)
        {
            bool estadoCaixa = BAL.Control.Caixa_BAL.GetEstadoCaixa(DAL.Model.Objetos.UsuarioStatic.Filial);
            if (!estadoCaixa)
            {
                if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 2)
                {
                    MessageBox.Show("Você não é autorizado!");
                }
                else
                {
                    new TelaAberturaDeCaixa().Show();
                }
            }
            else
            {
                if (estadoCaixa)
                    new TelaVenda().Show();
            }
        }
        private void MenuProdutos_Click(object sender, EventArgs e)
        {
            new TelaCadastroProdutos().Show();
        }

        private void MenuContasPagar_Click(object sender, EventArgs e)
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 2)
            {
                MessageBox.Show("Você não é autorizado!");
            }
            else
            {
                new TelaCadastroContasPagar().Show();
            }
        }

        private void MenuConvenios_Click(object sender, EventArgs e)
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 2)
            {
                MessageBox.Show("Você não é autorizado!");
            }
            else
            {
                new TelaCadastroConvenios().Show();
            }
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = DAL.Model.Objetos.UsuarioStatic.Nome;
            List<DAL.Model.Objetos.Requisicao> lista = BAL.Control.Requisicoes_BAL.VerificaSeUsuarioTemRequisicaoRespondida();
            if (lista != null)
            {
                MessageBox.Show($"Sua solicitacao foi respondida!" +
                    $"\nData: {lista[0].Data}" +
                    $"\nAssunto: {lista[0].Assunto}" +
                    $"\nSolicitacao: {lista[0].Solicitacao}" +
                    $"\nResposta: {lista[0].Resposta}");

            }
        }

        private void TelaPrincipal_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics; Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(94, 221, 231), Color.FromArgb(139, 148, 250), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void MenuRequisicao_Click(object sender, EventArgs e)
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 2)
            {
                MessageBox.Show("Você não é autorizado!");
            }
            else
            {
                new TelaRequisicoes().Show();
            }
        }

        private void MenuMovimentacaoFinanceira_Click(object sender, EventArgs e)
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 2)
            {
                MessageBox.Show("Você não é autorizado!");
            }
            else
            {
                new TelaMovimentacaoFinanceira().Show();
            }
        }

        private void MenuContasReceber_Click(object sender, EventArgs e)
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 2)
            {
                MessageBox.Show("Você não é autorizado!");
            }
            else
            {
                new TelaCadastroContasReceber().Show();
            }
        }

        private void MenuNovaRequisicao_Click(object sender, EventArgs e)
        {
            new TelaNovaRequisicao().Show();
        }

        private void MenuGraficos_Click(object sender, EventArgs e)
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 2)
            {
                MessageBox.Show("Você não é autorizado!");
            }
            else
            {
                new TelaGraficos().Show();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TelaSair().Show();
            //Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void MenuFechamentoCaixa_Click(object sender, EventArgs e)
        {
            bool estadoCaixa = BAL.Control.Caixa_BAL.GetEstadoCaixa(DAL.Model.Objetos.UsuarioStatic.Filial);
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 1)
                if (estadoCaixa)
                    new TelaFechamentoCaixa().Show();
                else
                    MessageBox.Show("O caixa nao esta aberto");
            else
                MessageBox.Show("Você não possui autorizacao");
        }
    }
}
