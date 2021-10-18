using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTech.View.Principal
{
    public partial class TelaBancoDados : Form
    {
        public TelaBancoDados()
        {
            InitializeComponent();
        }

        private async void btnSincronizar_Click(object sender, EventArgs e)
        {
            DAL.Model.Consultas.DBHibrido.EnviarDados();
            MessageBox.Show("OK");

            progressBar1.Value = 0;
            var progress = new Progress<int>(percent =>
            {
                progressBar1.Value = percent;

            });
            await Task.Run(() => DoSomething(progress));


        }

        public void DoSomething(IProgress<int> progress)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(100);
                if (progress != null)
                    progress.Report(i);
            }
        }

        private void TelaBancoDados_Paint(object sender, PaintEventArgs e)
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

    }

}


