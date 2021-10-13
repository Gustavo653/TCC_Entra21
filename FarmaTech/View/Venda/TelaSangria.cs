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
    public partial class TelaSangria : Form
    {
        public TelaSangria()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            int resultado = BAL.Control.Caixa_BAL.AtualizaCaixa(DateTime.Now.ToString().Substring(0, 10), txtInserir.Text, txtRetirada.Text, cbUsuario.Text);
            if (resultado == 0)
            {
                this.Hide();
            }
            else if (resultado == 1)
            {
                MessageBox.Show("Verifique se tudo esta preenchido corretamente");
            }
            else
            {
                MessageBox.Show("Erro desconhecido!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
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

        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(94, 221, 231), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void TelaSangria_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void TelaSangria_Load(object sender, EventArgs e)
        {
            lblDataSistema.Text = DateTime.Now.ToString();
            IEnumerable<string> nomesUsuarios = BAL.Control.Usuarios_BAL.GetUsuarios().Select(x => x.Nome);
            cbUsuario.DataSource = nomesUsuarios.ToArray();
            cbUsuario.SelectedItem = DAL.Model.Objetos.UsuarioStatic.Nome;
        }
    }
}
