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
    public partial class TelaCadastroContasReceber : Form
    {
        public TelaCadastroContasReceber()
        {
            InitializeComponent();
        }

        private void TelaContasReceber_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovoContaReceber);
            btnSalvar.Enabled = false;
        }

        private void TelaContasReceber_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void TelaContasReceber_Paint(object sender, PaintEventArgs e)
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
            if (tabControl1.TabPages.Contains(tabNovoContaReceber))
            {
                tabControl1.TabPages.Remove(tabNovoContaReceber);
                tabControl1.TabPages.Add(tabContasReceber);
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnNovo.Enabled = true;
            }
            else
            {
                this.Hide();
            }
            lblContas.Text = "Contas a receber";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoContaReceber);
            tabControl1.TabPages.Remove(tabContasReceber);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            lblContas.Text = "Nova Conta";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabContasReceber);
            tabControl1.TabPages.Add(tabNovoContaReceber);
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do registro?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {           

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            tabControl1.TabPages.Remove(tabNovoContaReceber);
            tabControl1.TabPages.Add(tabContasReceber);
            btnSalvar.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void tabContasReceber_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void tabNovoContaReceber_Paint(object sender, PaintEventArgs e)
        {

            SetBackColorDegrade(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(116, 186, 241), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }
    }
}
