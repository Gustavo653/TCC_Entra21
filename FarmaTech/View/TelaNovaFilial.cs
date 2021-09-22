using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaTech
{
    public partial class TelaNovaFilial : Form
    {
        public TelaNovaFilial()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void TelaNovaFilial_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
