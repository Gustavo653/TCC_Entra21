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
    public partial class TelaRequisicoes : Form
    {
        public TelaRequisicoes()
        {
            InitializeComponent();
        }

        private void TelaRequisicoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void TelaRequisicoes_Paint(object sender, PaintEventArgs e)
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
            if (tabControl1.TabPages.Contains(tabNovaRequisicao))
            {
                tabControl1.TabPages.Remove(tabNovaRequisicao);
                tabControl1.TabPages.Add(tabRequisicoes);
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnNovo.Enabled = true;
            }
            else
            {
                this.Hide();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovaRequisicao);
            tabControl1.TabPages.Remove(tabRequisicoes);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabRequisicoes);
            tabControl1.TabPages.Add(tabNovaRequisicao);
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do registro?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                          
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovaRequisicao);
            tabControl1.TabPages.Add(tabRequisicoes);
        }

        private void TelaRequisicoes_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovaRequisicao);           
            btnSalvar.Enabled = false;
        }
    }
}
