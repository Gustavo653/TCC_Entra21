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
using System.Windows.Forms.DataVisualization.Charting;

namespace FarmaTech.View.Principal
{
    public partial class TelaGraficos : Form
    {
        public TelaGraficos()
        {
            InitializeComponent();
        }

        private void TelaGraficos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void TelaGraficos_Paint(object sender, PaintEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(139, 148, 250), Color.FromArgb(116, 186, 241), 45f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void TelaGraficos_Load(object sender, EventArgs e)
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 3)
            {
                chkTodasFiliais.Visible = false;
            }
            txtData.Text = DateTime.Now.ToString().Substring(0, 10);
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso == 2)
            {
                cbFilial.Text = DAL.Model.Objetos.UsuarioStatic.Filial;
            }
            else
            {
                cbFilial.DataSource = BAL.Control.Enderecos_BAL.GetEndereco(Convert.ToInt32(DAL.Model.Enums.Enderecos.Filiais)).Select(x => x.NomeFantasia).ToList();
            }
        }
        public void AtualizaControles()
        {
            txtReceitaFuncionario.Text = BAL.Control.Graficos_BAL.LucroPorFuncionario(txtData.Text, cbFilial.Text);

            txtFuncionarioMaisVendas.Text = BAL.Control.Graficos_BAL.FuncionarioComMaisVendas(txtData.Text, cbFilial.Text);

            Dictionary<string, int> produtosMaisVendidos = BAL.Control.Graficos_BAL.ProdutosMaisVendidos(txtData.Text, cbFilial.Text);
            lstProdMaisVendidos.Items.Clear();
            foreach (var item in produtosMaisVendidos)
            {
                lstProdMaisVendidos.Items.Add("Nome: " + item.Key + " - Quantidade: " + item.Value);
            }

            Dictionary<string, string> receitaFuncionarios = BAL.Control.Graficos_BAL.ReceitaPorFuncionario(txtData.Text, cbFilial.Text);
            lstReceitaFuncionario.Items.Clear();
            foreach (var item in receitaFuncionarios)
            {
                lstReceitaFuncionario.Items.Add("Nome: " + item.Key + " - Receita: R$" + item.Value);
            }

            double[] valores = new double[3];
            valores = BAL.Control.Graficos_BAL.RelacaoCompraVenda(txtData.Text, cbFilial.Text);
            string[] nomes = new string[3];
            nomes[0] = "Custo - R$" + valores[0];
            nomes[1] = "Venda - R$" + valores[1];
            nomes[2] = "Receita - R$" + valores[2];
            graficoCustoVenda.Series[0].Points.DataBindXY(nomes, valores);
            graficoCustoVenda.Series[0].ChartType = SeriesChartType.Pie;
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkTodasFiliais.Checked == true)
                {
                    string receitaFuncionarioTotal = "0";
                    Dictionary<string, int> produtosMaisVendidosTotal = new Dictionary<string, int>();
                    Dictionary<string, string> receitaFuncionarioTotal2 = new Dictionary<string, string>();
                    double[] valoresGrafico = new double[3];
                    foreach (var item in cbFilial.Items)
                    {
                        string lucroFuncionario = BAL.Control.Graficos_BAL.LucroPorFuncionario(txtData.Text, item.ToString());

                        Dictionary<string, int> produtosMaisVendidos = BAL.Control.Graficos_BAL.ProdutosMaisVendidos(txtData.Text, item.ToString());

                        Dictionary<string, string> receitaFuncionarios = BAL.Control.Graficos_BAL.ReceitaPorFuncionario(txtData.Text, item.ToString());

                        double[] valores = new double[3];
                        valores = BAL.Control.Graficos_BAL.RelacaoCompraVenda(txtData.Text, item.ToString());

                        receitaFuncionarioTotal = (Convert.ToDouble(receitaFuncionarioTotal) + Convert.ToDouble(lucroFuncionario)).ToString();
                        foreach (var item2 in produtosMaisVendidos)
                        {
                            produtosMaisVendidosTotal.Add(item2.Key, produtosMaisVendidos[item2.Key]);
                        }
                        foreach (var item2 in receitaFuncionarios)
                        {
                            receitaFuncionarioTotal2.Add(item2.Key, receitaFuncionarios[item2.Key]);
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            valoresGrafico[i] = Convert.ToDouble(valoresGrafico[i]) + Convert.ToDouble(valores[i]);
                        }
                    }

                    txtReceitaFuncionario.Text = receitaFuncionarioTotal;
                    lstProdMaisVendidos.Items.Clear();
                    foreach (var item in produtosMaisVendidosTotal)
                    {
                        lstProdMaisVendidos.Items.Add("Nome: " + item.Key + " - Quantidade: " + item.Value);
                    }
                    lstReceitaFuncionario.Items.Clear();
                    foreach (var item in receitaFuncionarioTotal2)
                    {
                        lstReceitaFuncionario.Items.Add("Nome: " + item.Key + " - Receita: R$" + item.Value);
                    }
                    string[] nomes = new string[3];
                    nomes[0] = "Custo - R$" + valoresGrafico[0];
                    nomes[1] = "Venda - R$" + valoresGrafico[1];
                    nomes[2] = "Receita - R$" + valoresGrafico[2];
                    graficoCustoVenda.Series[0].Points.DataBindXY(nomes, valoresGrafico);
                    graficoCustoVenda.Series[0].ChartType = SeriesChartType.Pie;
                }
                else
                {
                    AtualizaControles();
                }

                progressBar1.Value = 0;
                var progress = new Progress<int>(percent =>
                {
                    progressBar1.Value = percent;

                });
                await Task.Run(() => DoSomething(progress));

                //AtualizaControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro desconhecido! Tente novamente mais tarde", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DAL.Model.Consultas.Log.GerarErro(ex, "Tela_Grafico");
            }
        }
        public void DoSomething(IProgress<int> progress)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(1);
                if (progress != null)
                    progress.Report(i);
            }
        }

    }
}

