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
    public partial class TelaNovaFormaPag : Form
    {
        public TelaNovaFormaPag()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void TelaNovaFormaPag_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
