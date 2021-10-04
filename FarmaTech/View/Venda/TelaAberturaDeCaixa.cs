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
    public partial class TelaAberturaDeCaixa : Form
    {
        public TelaAberturaDeCaixa()
        {
            InitializeComponent();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            new TelaVenda().Show();
            this.Hide();
        }

        private void TelaAberturaDeCaixa_Paint(object sender, PaintEventArgs e)
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

        private void TelaAberturaDeCaixa_Load(object sender, EventArgs e)
        {
            lblDataSistema.Text = DateTime.Now.ToString();
        }
    }
}
