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
    public partial class TelaMovimentacaoFinanceira : Form
    {
        public TelaMovimentacaoFinanceira()
        {
            InitializeComponent();
        }

        private void TelaMovimentacaoFinanceira_Load(object sender, EventArgs e)
        {
            if (rbReceber.Checked)
            {
                AtualizaDG(1);
            }
            else if (rbPagar.Checked)
            {
                AtualizaDG(2);
            }
            else
            {
                AtualizaDG(3);
            }
                
                
        }

        private void TelaMovimentacaoFinanceira_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void TelaMovimentacaoFinanceira_Paint(object sender, PaintEventArgs e)
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

        private void btnContasPagar_Click(object sender, EventArgs e)
        {
            new TelaCadastroContasPagar().Show();
        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(116, 186, 241), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);

        }

        public void AtualizaDG(int num)
        {
          
            if (num == 1)
            {
                List<DAL.Model.Objetos.ContasReceber> lista = BAL.Control.ContasReceber_BAL.GetContasReceber();

                foreach (var item in lista)
                {
                    dgMovimentacao.Rows.Add(item.NomeFornecedor, item.Valor, "", item.Vencimento);
                }
            }
            else if (num == 2)
            {
                List<DAL.Model.Objetos.ContasPagar> lista = BAL.Control.ContasPagar_BAL.GetContasPagar();

                foreach (var item in lista)
                {
                    dgMovimentacao.Rows.Add(item.NomeFornecedor, "", item.Valor, item.Vencimento);
                }
            }
            else if(num == 3)
            {
                List<DAL.Model.Objetos.ContasReceber> lista = BAL.Control.ContasReceber_BAL.GetContasReceber();

                foreach (var item in lista)
                {
                    dgMovimentacao.Rows.Add(item.NomeFornecedor, item.Valor, "", item.Vencimento);
                }

                List<DAL.Model.Objetos.ContasPagar> lista1 = BAL.Control.ContasPagar_BAL.GetContasPagar();

                foreach (var item in lista1)
                {
                    dgMovimentacao.Rows.Add(item.NomeFornecedor, "", item.Valor, item.Vencimento);
                }
            }
        }
    }
}
