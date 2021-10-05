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

namespace FarmaTech.View.Requisicoes
{
    public partial class TelaNovaRequisicao : Form
    {
        public TelaNovaRequisicao()
        {
            InitializeComponent();
        }

        private void TelaNovaRequisicao_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString().Substring(0, 10);
            lblFilial.Text = DAL.Model.Objetos.UsuarioStatic.Filial;
            lblUsuario.Text = DAL.Model.Objetos.UsuarioStatic.Nome;
        }

        private void TelaNovaRequisicao_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void TelaNovaRequisicao_Paint(object sender, PaintEventArgs e)
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int resultado = BAL.Control.Requisicoes_BAL.AdicionaRequisicao(lblUsuario.Text, lblFilial.Text, DateTime.Now.ToString().Substring(0,10), txtAssunto.Text, txtDescricao.Text);
            if(resultado == 0)
            {
                MessageBox.Show("Requisicao registrada");
            }
            else if (resultado == 1)
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else if(resultado == 2)
            {
                MessageBox.Show("Houve um erro desconhecido");
            }
            else
            {
                MessageBox.Show("A mensagem é muito grande");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
    }
}
