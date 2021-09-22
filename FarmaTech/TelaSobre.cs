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
    }
}
