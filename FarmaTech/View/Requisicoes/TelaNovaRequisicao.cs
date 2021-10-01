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
            Graphics graphics = e.Graphics; Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            //RGB vermelho verde azul
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(103, 23, 205), Color.FromArgb(108, 226, 252), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
