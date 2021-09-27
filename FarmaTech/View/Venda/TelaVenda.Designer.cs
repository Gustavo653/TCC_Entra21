
namespace FarmaTech
{
    partial class TelaVenda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.lblCpf = new System.Windows.Forms.Label();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.tabVenda = new System.Windows.Forms.TabPage();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtValorParcial = new System.Windows.Forms.TextBox();
            this.lblValorParcial = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DescricaoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblValorTotalItem = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.lblQuant = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblDataSitema = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnConfirma);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Location = new System.Drawing.Point(134, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 110);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 14;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(190, 21);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 75);
            this.btnConfirma.TabIndex = 13;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(67, 21);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 75);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCliente);
            this.tabControl1.Controls.Add(this.tabVenda);
            this.tabControl1.Location = new System.Drawing.Point(65, 130);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1189, 504);
            this.tabControl1.TabIndex = 2;
            // 
            // tabCliente
            // 
            this.tabCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabCliente.Controls.Add(this.btnContinuar);
            this.tabCliente.Controls.Add(this.btnPesquisar);
            this.tabCliente.Controls.Add(this.txtObservacao);
            this.tabCliente.Controls.Add(this.lblObservacao);
            this.tabCliente.Controls.Add(this.txtCnpj);
            this.tabCliente.Controls.Add(this.txtRazaoSocial);
            this.tabCliente.Controls.Add(this.lblNome);
            this.tabCliente.Controls.Add(this.rbJuridica);
            this.tabCliente.Controls.Add(this.lblCpf);
            this.tabCliente.Controls.Add(this.rbFisica);
            this.tabCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCliente.Location = new System.Drawing.Point(4, 29);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(1181, 471);
            this.tabCliente.TabIndex = 1;
            this.tabCliente.Text = "Cliente";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(418, 303);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 75);
            this.btnContinuar.TabIndex = 122;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(292, 303);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 75);
            this.btnPesquisar.TabIndex = 121;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(192, 215);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(702, 29);
            this.txtObservacao.TabIndex = 120;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(65, 221);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(109, 20);
            this.lblObservacao.TabIndex = 119;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(192, 87);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(311, 29);
            this.txtCnpj.TabIndex = 118;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(192, 152);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(702, 29);
            this.txtRazaoSocial.TabIndex = 117;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(68, 158);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 116;
            this.lblNome.Text = "Nome:";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJuridica.Location = new System.Drawing.Point(462, 36);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(89, 24);
            this.rbJuridica.TabIndex = 115;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(124, 93);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(48, 20);
            this.lblCpf.TabIndex = 113;
            this.lblCpf.Text = "CPF:";
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFisica.Location = new System.Drawing.Point(364, 36);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(74, 24);
            this.rbFisica.TabIndex = 114;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // tabVenda
            // 
            this.tabVenda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabVenda.Controls.Add(this.txtConvenio);
            this.tabVenda.Controls.Add(this.lblConvenio);
            this.tabVenda.Controls.Add(this.textBox5);
            this.tabVenda.Controls.Add(this.lblValorTotal);
            this.tabVenda.Controls.Add(this.txtDesconto);
            this.tabVenda.Controls.Add(this.lblDesconto);
            this.tabVenda.Controls.Add(this.txtValorParcial);
            this.tabVenda.Controls.Add(this.lblValorParcial);
            this.tabVenda.Controls.Add(this.dataGridView1);
            this.tabVenda.Controls.Add(this.textBox1);
            this.tabVenda.Controls.Add(this.lblValorTotalItem);
            this.tabVenda.Controls.Add(this.txtQuant);
            this.tabVenda.Controls.Add(this.lblQuant);
            this.tabVenda.Controls.Add(this.btnPesquisa);
            this.tabVenda.Controls.Add(this.txtProduto);
            this.tabVenda.Controls.Add(this.lblDataSitema);
            this.tabVenda.Controls.Add(this.lblProduto);
            this.tabVenda.Controls.Add(this.lblData);
            this.tabVenda.Controls.Add(this.comboBox1);
            this.tabVenda.Controls.Add(this.lblVendedor);
            this.tabVenda.Location = new System.Drawing.Point(4, 29);
            this.tabVenda.Name = "tabVenda";
            this.tabVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenda.Size = new System.Drawing.Size(1181, 471);
            this.tabVenda.TabIndex = 0;
            this.tabVenda.Text = "Venda";
            // 
            // txtConvenio
            // 
            this.txtConvenio.Location = new System.Drawing.Point(906, 338);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.Size = new System.Drawing.Size(128, 26);
            this.txtConvenio.TabIndex = 54;
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenio.Location = new System.Drawing.Point(805, 341);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(88, 20);
            this.lblConvenio.TabIndex = 53;
            this.lblConvenio.Text = "Convênio:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(906, 385);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(128, 26);
            this.textBox5.TabIndex = 52;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(765, 388);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(129, 20);
            this.lblValorTotal.TabIndex = 51;
            this.lblValorTotal.Text = "Valor Total R$:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(906, 291);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(128, 26);
            this.txtDesconto.TabIndex = 48;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Location = new System.Drawing.Point(802, 294);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(91, 20);
            this.lblDesconto.TabIndex = 47;
            this.lblDesconto.Text = "Desconto:";
            // 
            // txtValorParcial
            // 
            this.txtValorParcial.Location = new System.Drawing.Point(906, 240);
            this.txtValorParcial.Name = "txtValorParcial";
            this.txtValorParcial.Size = new System.Drawing.Size(128, 26);
            this.txtValorParcial.TabIndex = 46;
            // 
            // lblValorParcial
            // 
            this.lblValorParcial.AutoSize = true;
            this.lblValorParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcial.Location = new System.Drawing.Point(774, 243);
            this.lblValorParcial.Name = "lblValorParcial";
            this.lblValorParcial.Size = new System.Drawing.Size(120, 20);
            this.lblValorParcial.TabIndex = 45;
            this.lblValorParcial.Text = "Valor Parcial.:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescricaoCol});
            this.dataGridView1.Location = new System.Drawing.Point(39, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(687, 184);
            this.dataGridView1.TabIndex = 44;
            // 
            // DescricaoCol
            // 
            this.DescricaoCol.HeaderText = "Descrição";
            this.DescricaoCol.Name = "DescricaoCol";
            this.DescricaoCol.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 26);
            this.textBox1.TabIndex = 43;
            // 
            // lblValorTotalItem
            // 
            this.lblValorTotalItem.AutoSize = true;
            this.lblValorTotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalItem.Location = new System.Drawing.Point(323, 187);
            this.lblValorTotalItem.Name = "lblValorTotalItem";
            this.lblValorTotalItem.Size = new System.Drawing.Size(56, 20);
            this.lblValorTotalItem.TabIndex = 42;
            this.lblValorTotalItem.Text = "Valor:";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(144, 184);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(128, 26);
            this.txtQuant.TabIndex = 41;
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuant.Location = new System.Drawing.Point(35, 187);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(107, 20);
            this.lblQuant.TabIndex = 40;
            this.lblQuant.Text = "Quantidade:";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(696, 110);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(30, 26);
            this.btnPesquisa.TabIndex = 38;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(144, 110);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(528, 26);
            this.txtProduto.TabIndex = 37;
            // 
            // lblDataSitema
            // 
            this.lblDataSitema.AutoSize = true;
            this.lblDataSitema.Location = new System.Drawing.Point(479, 38);
            this.lblDataSitema.Name = "lblDataSitema";
            this.lblDataSitema.Size = new System.Drawing.Size(51, 20);
            this.lblDataSitema.TabIndex = 36;
            this.lblDataSitema.Text = "label1";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(46, 113);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(77, 20);
            this.lblProduto.TabIndex = 35;
            this.lblProduto.Text = "Produto:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(398, 38);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 20);
            this.lblData.TabIndex = 33;
            this.lblData.Text = "Data:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 28);
            this.comboBox1.TabIndex = 32;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(46, 38);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(92, 20);
            this.lblVendedor.TabIndex = 31;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1302, 682);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Venda";
            this.Load += new System.EventHandler(this.TelaVenda_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabCliente.PerformLayout();
            this.tabVenda.ResumeLayout(false);
            this.tabVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.TabPage tabVenda;
        private System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtValorParcial;
        private System.Windows.Forms.Label lblValorParcial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblValorTotalItem;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblDataSitema;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoCol;
    }
}