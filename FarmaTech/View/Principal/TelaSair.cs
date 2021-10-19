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

namespace FarmaTech
{
    public partial class TelaSair : Form
    {
        public TelaSair()
        {
            InitializeComponent();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            if (DAL.Model.Objetos.UsuarioStatic.Contato != null)
            {
                DAL.Model.Consultas.DBHibrido.ExecutarCommands();
            }
            MessageBox.Show("Obrigado por utilizar FarmaTech.");
            Application.Exit();
        }

        private void TelaSair_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);

        }
        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics; Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(94, 221, 231), Color.FromArgb(139, 148, 250), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

    }
}
