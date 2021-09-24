using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTech.View
{
    public partial class TelaCadastroCliente : Form
    {
        public TelaCadastroCliente()
        {
            InitializeComponent();
        }

        private void TelaCadastroCliente_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovoCliente);
        }

        private void TelaCadastroCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovoCliente);
            tabControl1.TabPages.Remove(tabClientes);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            
            
            

            if (rbJuridica.Checked)
            {
                lblRazaoSocial.Text = "Razão Social:";
                lblNomeFantasia.Visible = true;
                txtNomeFantasia.Visible = true;
                lblCnpj.Text = "CNPJ:";
            }
            if(rbFisica.Checked)
            {
              
                lblRazaoSocial.Text = "Nome:";
                lblNomeFantasia.Visible = false;
                txtNomeFantasia.Visible = false;
                lblCnpj.Text = "CPF:";
            }



        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
