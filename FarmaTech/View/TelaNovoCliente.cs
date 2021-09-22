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
    public partial class TelaNovoCliente : Form
    {
        public TelaNovoCliente()
        {
            InitializeComponent();
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked)
            {
                lblRazaoSocial.Text = "Nome:";
                lblNomeFantasia.Visible = false;
                txtNomeFantasia.Visible = false;
                lblCnpj.Text = "CPF:";          

            }
            else if (rbJuridica.Checked)
            {
                lblRazaoSocial.Text = "Razão Social:";
                lblNomeFantasia.Visible = true;
                txtNomeFantasia.Visible = true;
                lblCnpj.Text = "CNPJ:";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void TelaNovoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
