using Microsoft.VisualBasic;
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

namespace FarmaTech.View.Venda
{
    public partial class TelaConsultaProduto : Form
    {
        public TelaConsultaProduto()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TelaConsultaProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void TelaConsultaProduto_Paint(object sender, PaintEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(94, 221, 231), Color.FromArgb(139, 148, 250), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        public void AtualizaDG()
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 1 || DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp != DAL.Model.Objetos.UsuarioStatic.NivelAcesso)
            {

                if (!string.IsNullOrEmpty(txtPesquisaProduto.Text)) //Filtrar por razao social
                {
                    List<DAL.Model.Objetos.Produto> lista = BAL.Control.Produtos_BAL.GetProdutosPorNome(txtPesquisaProduto.Text);
                    dgProdutos.DataSource = lista;
                }
                else
                {
                    List<DAL.Model.Objetos.Produto> lista = BAL.Control.Produtos_BAL.GetProdutos();
                    dgProdutos.DataSource = lista;
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja aumentar o nivel de acesso?", "Nivel Acesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string login = Interaction.InputBox("Insira seu login", "Login", "", 200, 200);
                    string senha = Interaction.InputBox("Insira seu login", "Login", "", 200, 200);
                    if (BAL.Control.NivelAcessoUsuario_BAL.VerificaPermissao(login, senha))
                    {
                        DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp++;
                    }
                }
            }
        }

        private void TelaConsultaProduto_Load(object sender, EventArgs e)
        {
            AtualizaDG();
        }

        private void txtPesquisaProduto_TextChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }
    }
}
