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
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(94, 221, 231), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabResposta))
            {
                tabControl1.TabPages.Remove(tabResposta);
                tabControl1.TabPages.Add(tabRequisicoes);
           
            }
            else
            {
                this.Hide();
            }
        }


        private void TelaRequisicoes_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabResposta);
            AtualizaDG();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabRequisicoes);
            tabControl1.TabPages.Add(tabResposta);
        }
        public void AtualizaDG()
        {
            if (!string.IsNullOrEmpty(txtPesquisaUsuario.Text))
            {
                dgRequisicoes.DataSource = BAL.Control.Requisicoes_BAL.GetRequisicoesPorNome(txtPesquisaUsuario.Text);
            }
            else
            {
                dgRequisicoes.DataSource = BAL.Control.Requisicoes_BAL.GetRequisicoes();
            }
        }

        private void txtPesquisaUsuario_TextChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = BAL.Control.Requisicoes_BAL.RespondeRequisicao(txtResposta.Text, lblUsuario.Text, txtAssunto.Text);
            if (resultado == 0)
            {
                MessageBox.Show("Requisicao respondida");
            }
            else if (resultado == 1)
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else if (resultado == 2)
            {
                MessageBox.Show("Houve um erro desconhecido");
            }
            else
            {
                MessageBox.Show("A mensagem é muito grande");
            }
            AtualizaDG();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabRequisicoes);
            tabControl1.TabPages.Add(tabResposta);

            int indiceSelecionado = dgRequisicoes.CurrentRow.Index;
            List<DAL.Model.Objetos.Requisicao> lista = BAL.Control.Requisicoes_BAL.GetRequisicoesPorNome(dgRequisicoes.Rows[indiceSelecionado].Cells[0].Value.ToString());
            lblData.Text = lista[0].Data;
            lblUsuario.Text = lista[0].Nome;
            lblFilial.Text = lista[0].Filial;
            txtAssunto.Text = lista[0].Assunto;
            txtDescricao.Text = lista[0].Solicitacao;
        }
    }
}
