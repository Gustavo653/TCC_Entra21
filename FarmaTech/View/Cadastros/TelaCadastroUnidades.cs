using Microsoft.VisualBasic;
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
    public partial class TelaCadastroUnidades : Form
    {
        public TelaCadastroUnidades()
        {
            InitializeComponent();
        }

        private void TelaCadastroUnidades_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabNovaUnidade);
            AtualizaDG();
        }

        private void TelaCadastroUnidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabNovaUnidade);
            tabControl1.TabPages.Remove(tabUnidades);
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int resultado = BAL.Control.CRUD_Unidades_BAL.AdicionarUnidade(txtNome.Text);            
            if (resultado == 0)
            {
                MessageBox.Show("Unidade cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultado == 1)
            {
                MessageBox.Show("Preencha todos os campos!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resultado == 2)
            {
                MessageBox.Show("Unidade já existente!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = dgUnidades.CurrentRow.Index;
            string nome = Interaction.InputBox("Insira o nome", "Atualiza Usuario", "", 200, 200);
            int resultado = BAL.Control.CRUD_Unidades_BAL.AtualizaUnidade(nome, dgUnidades.Rows[indiceSelecionado].Cells[0].Value.ToString());
            if (resultado == 0)
            {
                MessageBox.Show("Usuário atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultado == 1)
            {
                MessageBox.Show("Preencha todos os campos!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resultado == 2)
            {
                MessageBox.Show("Usuário já existente!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = dgUnidades.CurrentRow.Index;
            BAL.Control.CRUD_Unidades_BAL.RemoveUnidade(dgUnidades.Rows[indiceSelecionado].Cells[0].Value.ToString());
            AtualizaDG();
        }
        public void AtualizaDG()
        {
            int tamanhoDG = dgUnidades.Rows.Count;
            while(tamanhoDG > 0)
            {
                dgUnidades.Rows.RemoveAt(0);
                tamanhoDG--;
            }
            if (!string.IsNullOrEmpty(txtPesquisaUsuario.Text))
            {
                List<string> lista = BAL.Control.CRUD_Unidades_BAL.GetUnidadesPorNome(txtPesquisaUsuario.Text);
                foreach (var item in lista)
                {
                    dgUnidades.Rows.Add(item);
                }
            }
            else
            {
                List<string> lista = BAL.Control.CRUD_Unidades_BAL.GetUnidades();
                foreach (var item in lista)
                {
                    dgUnidades.Rows.Add(item);
                }
            }
        }
    }
}
