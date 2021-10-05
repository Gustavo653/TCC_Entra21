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
    public partial class TelaSobre : Form
    {
        public TelaSobre()
        {
            InitializeComponent();
        }

        private void TelaSobre_FormClosed(object sender, FormClosedEventArgs e)
        {
            new TelaLogin().Show();
            this.Hide();
        }

        private void TelaSobre_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);

        }
        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics; Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(94, 221, 231), Color.FromArgb(139, 148, 250), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }
    }
}
