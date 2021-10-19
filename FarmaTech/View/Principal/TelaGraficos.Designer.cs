
namespace FarmaTech.View.Principal
{
    partial class TelaGraficos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graficoCustoVenda = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstProdMaisVendidos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstReceitaFuncionario = new System.Windows.Forms.ListBox();
            this.cbFilial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReceitaFuncionario = new System.Windows.Forms.TextBox();
            this.txtFuncionarioMaisVendas = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.chkTodasFiliais = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.graficoCustoVenda)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graficoCustoVenda
            // 
            this.graficoCustoVenda.BackColor = System.Drawing.Color.Transparent;
            this.graficoCustoVenda.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.graficoCustoVenda.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoCustoVenda.Legends.Add(legend1);
            this.graficoCustoVenda.Location = new System.Drawing.Point(15, 12);
            this.graficoCustoVenda.Name = "graficoCustoVenda";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficoCustoVenda.Series.Add(series1);
            this.graficoCustoVenda.Size = new System.Drawing.Size(795, 574);
            this.graficoCustoVenda.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 592);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 30);
            this.panel1.TabIndex = 97;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblHora.Location = new System.Drawing.Point(936, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 13);
            this.lblHora.TabIndex = 87;
            this.lblHora.Text = "Hora";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblData.Location = new System.Drawing.Point(12, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 13);
            this.lblData.TabIndex = 86;
            this.lblData.Text = "Data";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(815, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Filtrar por mes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(815, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Receita por funcionario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(816, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 100;
            this.label3.Text = "Funcionario com mais vendas: ";
            // 
            // lstProdMaisVendidos
            // 
            this.lstProdMaisVendidos.FormattingEnabled = true;
            this.lstProdMaisVendidos.Location = new System.Drawing.Point(819, 477);
            this.lstProdMaisVendidos.Name = "lstProdMaisVendidos";
            this.lstProdMaisVendidos.Size = new System.Drawing.Size(217, 95);
            this.lstProdMaisVendidos.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(816, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Produtos mais vendidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(813, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 105;
            this.label5.Text = "Receita de cada funcionario";
            // 
            // lstReceitaFuncionario
            // 
            this.lstReceitaFuncionario.FormattingEnabled = true;
            this.lstReceitaFuncionario.Location = new System.Drawing.Point(816, 339);
            this.lstReceitaFuncionario.Name = "lstReceitaFuncionario";
            this.lstReceitaFuncionario.Size = new System.Drawing.Size(217, 95);
            this.lstReceitaFuncionario.TabIndex = 104;
            // 
            // cbFilial
            // 
            this.cbFilial.FormattingEnabled = true;
            this.cbFilial.Location = new System.Drawing.Point(896, 18);
            this.cbFilial.Name = "cbFilial";
            this.cbFilial.Size = new System.Drawing.Size(121, 21);
            this.cbFilial.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(815, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "Filtrar por filial:";
            // 
            // txtReceitaFuncionario
            // 
            this.txtReceitaFuncionario.Enabled = false;
            this.txtReceitaFuncionario.Location = new System.Drawing.Point(939, 74);
            this.txtReceitaFuncionario.Name = "txtReceitaFuncionario";
            this.txtReceitaFuncionario.Size = new System.Drawing.Size(94, 20);
            this.txtReceitaFuncionario.TabIndex = 108;
            // 
            // txtFuncionarioMaisVendas
            // 
            this.txtFuncionarioMaisVendas.Location = new System.Drawing.Point(972, 101);
            this.txtFuncionarioMaisVendas.Name = "txtFuncionarioMaisVendas";
            this.txtFuncionarioMaisVendas.Size = new System.Drawing.Size(61, 20);
            this.txtFuncionarioMaisVendas.TabIndex = 109;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(896, 45);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(121, 20);
            this.txtData.TabIndex = 110;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Silver;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(818, 223);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(214, 50);
            this.btnPesquisar.TabIndex = 111;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // chkTodasFiliais
            // 
            this.chkTodasFiliais.AutoSize = true;
            this.chkTodasFiliais.BackColor = System.Drawing.Color.Transparent;
            this.chkTodasFiliais.Location = new System.Drawing.Point(819, 131);
            this.chkTodasFiliais.Name = "chkTodasFiliais";
            this.chkTodasFiliais.Size = new System.Drawing.Size(81, 17);
            this.chkTodasFiliais.TabIndex = 112;
            this.chkTodasFiliais.Text = "Todas filiais";
            this.chkTodasFiliais.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(818, 178);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(214, 23);
            this.progressBar1.TabIndex = 113;
            // 
            // TelaGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 622);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chkTodasFiliais);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtFuncionarioMaisVendas);
            this.Controls.Add(this.txtReceitaFuncionario);
            this.Controls.Add(this.cbFilial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstReceitaFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstProdMaisVendidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.graficoCustoVenda);
            this.Name = "TelaGraficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Gráficos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaGraficos_FormClosed);
            this.Load += new System.EventHandler(this.TelaGraficos_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaGraficos_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.graficoCustoVenda)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficoCustoVenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstProdMaisVendidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstReceitaFuncionario;
        private System.Windows.Forms.ComboBox cbFilial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReceitaFuncionario;
        private System.Windows.Forms.TextBox txtFuncionarioMaisVendas;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.CheckBox chkTodasFiliais;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}