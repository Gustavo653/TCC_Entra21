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

namespace FarmaTech.View
{
    public partial class TelaCadastroContasPagar : Form
    {
        public TelaCadastroContasPagar()
        {
            InitializeComponent();
        }

        private void TelaCadastroContasPagar_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovoContaPagar);
        }

        private void TelaCadastroContasPagar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
             this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoContaPagar);
            tabControl1.TabPages.Remove(tabContasPagar);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastroContasPagar_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }
        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics; Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(108, 226, 252), Color.FromArgb(103, 23, 205), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }
    }
}
