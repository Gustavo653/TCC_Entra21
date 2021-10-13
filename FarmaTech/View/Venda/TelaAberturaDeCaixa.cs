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
            int resultado = BAL.Control.Caixa_BAL.AbreCaixa(DateTime.Now.ToString().Substring(0, 10), lblNumCaixa.Text, cbUsuario.Text, txtValorAberturaCaixa.Text, DAL.Model.Objetos.UsuarioStatic.Filial);
            if (resultado == 0)
            {
                new TelaVenda().Show();
                this.Hide();
            }
            else if (resultado == 1)
            {
                MessageBox.Show("Verifique se tudo esta preenchido");
            }
            else
            {
                MessageBox.Show("Erro desconhecido!");
            }
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
            lblNumCaixa.Text = BAL.Control.Caixa_BAL.GetCaixa(1, cbUsuario.Text).ToString();
            IEnumerable<string> nomesUsuarios = BAL.Control.Usuarios_BAL.GetUsuarios().Select(x => x.Nome);
            cbUsuario.DataSource = nomesUsuarios.ToArray();
            cbUsuario.SelectedItem = DAL.Model.Objetos.UsuarioStatic.Nome;
            lblDataSistema.Text = DateTime.Now.ToString();
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
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
