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

namespace FarmaTech.View
{
    public partial class TelaCadastroConvenios : Form
    {
        public static int ValorSalvar { get; set; }
        public TelaCadastroConvenios()
        {
            InitializeComponent();
        }

        private void TelaCadastroConvenios_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovoConvenio);
            btnSalvar.Enabled = false;
            AtualizaDG();
        }

        private void TelaCadastroConvenios_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabNovoConvenio))
            {
                tabControl1.TabPages.Remove(tabNovoConvenio);
                tabControl1.TabPages.Add(tabConvenios);
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnNovo.Enabled = true;
            }
            else
            {
                this.Hide();
            }

            lblConv.Text = "Convênios";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoConvenio);
            tabControl1.TabPages.Remove(tabConvenios);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;

            ValorSalvar = 1;
            lblConv.Text = "Novo\nConvênio";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValorSalvar == 1)
            {
                int resultado = BAL.Control.Convenios_BAL.AdicionarConvenio(txtNome.Text, txtDesconto.Text);

                if (resultado == 0)
                {
                    MessageBox.Show("Convenio cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Convenio já existente!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 3)
                {
                    MessageBox.Show("Houve um erro desconhecido!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 4)
                {
                    MessageBox.Show("Verifique se os dados inseridos estão no formato correto!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                AtualizaDG();
            }
            else
            {
                int indiceSelecionado = dgConvenios.CurrentRow.Index;
                int resultado = BAL.Control.Convenios_BAL.AtualizaConvenio(txtNome.Text, txtDesconto.Text, dgConvenios.Rows[indiceSelecionado].Cells[0].Value.ToString());

                if (resultado == 0)
                {
                    MessageBox.Show("Convenio atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Preencha todos os campos!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Convenio já existente!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 3)
                {
                    MessageBox.Show("Houve um erro desconhecido!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == 4)
                {
                    MessageBox.Show("Verifique se os dados inseridos estão no formato correto!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                AtualizaDG();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabConvenios);
            tabControl1.TabPages.Add(tabNovoConvenio);
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;

            ValorSalvar = 0;

            int indiceSelecionado = dgConvenios.CurrentRow.Index;
            List<DAL.Model.Objetos.Convenio> convenio = BAL.Control.Convenios_BAL.GetConveniosPorNome(dgConvenios.Rows[indiceSelecionado].Cells[0].Value.ToString());
            txtNome.Text = convenio[0].Nome;
            txtDesconto.Text = convenio[0].Desconto;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = dgConvenios.CurrentRow.Index;
            BAL.Control.Convenios_BAL.RemoveConvenio(dgConvenios.Rows[indiceSelecionado].Cells[0].Value.ToString());
            AtualizaDG();
        }

        private void TelaCadastroConvenios_Paint(object sender, PaintEventArgs e)
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

        private void txtPesquisaUsuario_TextChanged(object sender, EventArgs e)
        {
            AtualizaDG();
        }
        public void AtualizaDG()
        {
            if (!string.IsNullOrEmpty(txtPesquisaUsuario.Text))
            {
                List<DAL.Model.Objetos.Convenio> lista = BAL.Control.Convenios_BAL.GetConveniosPorNome(txtPesquisaUsuario.Text);
                dgConvenios.DataSource = lista;
            }
            else
            {
                List<DAL.Model.Objetos.Convenio> lista = BAL.Control.Convenios_BAL.GetConvenios();
                dgConvenios.DataSource = lista;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(116, 186, 241), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(116, 186, 241), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void tabConvenios_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void tabNovoConvenio_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }
    }
}
