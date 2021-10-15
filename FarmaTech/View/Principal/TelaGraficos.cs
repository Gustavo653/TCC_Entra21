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

namespace FarmaTech.View.Principal
{
    public partial class TelaGraficos : Form
    {
        public TelaGraficos()
        {
            InitializeComponent();
        }

        private void TelaGraficos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void TelaGraficos_Paint(object sender, PaintEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(116, 186, 241), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void TelaGraficos_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToString().Substring(0, 10);
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso == 2)
            {
                cbFilial.Text = DAL.Model.Objetos.UsuarioStatic.Filial;
            }
            else
            {
                cbFilial.DataSource = BAL.Control.Enderecos_BAL.GetEndereco(Convert.ToInt32(DAL.Model.Enums.Enderecos.Filiais)).Select(x => x.NomeFantasia).ToList();
            }
        }
        public void AtualizaControles()
        {
            txtReceitaFuncionario.Text = BAL.Control.Graficos_BAL.LucroPorFuncionario(txtData.Text, cbFilial.Text);
            txtFuncionarioMaisVendas.Text = BAL.Control.Graficos_BAL.FuncionarioComMaisVendas(txtData.Text, cbFilial.Text);
            Dictionary<string, int> produtosMaisVendidos = BAL.Control.Graficos_BAL.ProdutosMaisVendidos(txtData.Text, cbFilial.Text);
            lstProdMaisVendidos.Items.Clear();
            foreach (var item in produtosMaisVendidos)
            {
                lstProdMaisVendidos.Items.Add("Nome: " + item.Key + " - Quantidade: " + item.Value);
            }
            Dictionary<string, string> receitaFuncionarios = BAL.Control.Graficos_BAL.ReceitaPorFuncionario(txtData.Text, cbFilial.Text);
            lstReceitaFuncionario.Items.Clear();
            foreach (var item in receitaFuncionarios)
            {
                lstReceitaFuncionario.Items.Add("Nome: " + item.Key + " - Receita: R$" + item.Value);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizaControles();
        }
    }
}

