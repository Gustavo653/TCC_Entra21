
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.lblCpf = new System.Windows.Forms.Label();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.tabVenda = new System.Windows.Forms.TabPage();
            this.btnContinarVenda = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            this.tabFormaPagamento = new System.Windows.Forms.TabPage();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnVoltarVenda = new System.Windows.Forms.Button();
            this.txtFormaPag = new System.Windows.Forms.TextBox();
            this.txtFormaValorParcial = new System.Windows.Forms.TextBox();
            this.txtFormaValorCompra = new System.Windows.Forms.TextBox();
            this.txtFormaConvenio = new System.Windows.Forms.TextBox();
            this.lblFormaConvenio = new System.Windows.Forms.Label();
            this.txtFormaValorTotal = new System.Windows.Forms.TextBox();
            this.lblFormaValorTotal = new System.Windows.Forms.Label();
            this.txtFormaDesconto = new System.Windows.Forms.TextBox();
            this.lblFormaDesconto = new System.Windows.Forms.Label();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.lblFormaParcial = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabFormaPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnConfirma);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Location = new System.Drawing.Point(130, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 111);
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
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(425, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 75);
            this.btnPesquisar.TabIndex = 121;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::FarmaTech.Properties.Resources.BotaoHome;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(51, 11);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 95);
            this.btnVoltar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnVoltar, "Volta");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCliente);
            this.tabControl1.Controls.Add(this.tabVenda);
            this.tabControl1.Controls.Add(this.tabFormaPagamento);
            this.tabControl1.Location = new System.Drawing.Point(23, 129);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 579);
            this.tabControl1.TabIndex = 2;
            // 
            // tabCliente
            // 
            this.tabCliente.BackColor = System.Drawing.Color.Lavender;
            this.tabCliente.Controls.Add(this.btnContinuar);
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
            this.tabCliente.Size = new System.Drawing.Size(825, 546);
            this.tabCliente.TabIndex = 1;
            this.tabCliente.Text = "Cliente";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(255, 267);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(117, 75);
            this.btnContinuar.TabIndex = 122;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(138, 195);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(427, 29);
            this.txtObservacao.TabIndex = 120;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.Color.Transparent;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(11, 201);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(109, 20);
            this.lblObservacao.TabIndex = 119;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(138, 67);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(311, 29);
            this.txtCnpj.TabIndex = 118;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(138, 132);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(427, 29);
            this.txtRazaoSocial.TabIndex = 117;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(60, 138);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 116;
            this.lblNome.Text = "Nome:";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJuridica.Location = new System.Drawing.Point(138, 19);
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
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(70, 73);
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
            this.rbFisica.Location = new System.Drawing.Point(40, 19);
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
            this.tabVenda.BackColor = System.Drawing.Color.Lavender;
            this.tabVenda.Controls.Add(this.btnContinarVenda);
            this.tabVenda.Controls.Add(this.btnCancelar);
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
            this.tabVenda.Size = new System.Drawing.Size(825, 546);
            this.tabVenda.TabIndex = 0;
            this.tabVenda.Text = "Venda";
            // 
            // btnContinarVenda
            // 
            this.btnContinarVenda.Location = new System.Drawing.Point(379, 406);
            this.btnContinarVenda.Name = "btnContinarVenda";
            this.btnContinarVenda.Size = new System.Drawing.Size(128, 92);
            this.btnContinarVenda.TabIndex = 56;
            this.btnContinarVenda.Text = "Continuar";
            this.btnContinarVenda.UseVisualStyleBackColor = true;
            this.btnContinarVenda.Click += new System.EventHandler(this.btnContinarVenda_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(379, 372);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 28);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtConvenio
            // 
            this.txtConvenio.Location = new System.Drawing.Point(165, 403);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.Size = new System.Drawing.Size(128, 26);
            this.txtConvenio.TabIndex = 54;
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenio.Location = new System.Drawing.Point(64, 406);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(88, 20);
            this.lblConvenio.TabIndex = 53;
            this.lblConvenio.Text = "Convênio:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(164, 486);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(128, 26);
            this.textBox5.TabIndex = 52;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(23, 492);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(129, 20);
            this.lblValorTotal.TabIndex = 51;
            this.lblValorTotal.Text = "Valor Total R$:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(164, 366);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(128, 26);
            this.txtDesconto.TabIndex = 48;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Location = new System.Drawing.Point(60, 369);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(91, 20);
            this.lblDesconto.TabIndex = 47;
            this.lblDesconto.Text = "Desconto:";
            // 
            // txtValorParcial
            // 
            this.txtValorParcial.Location = new System.Drawing.Point(164, 448);
            this.txtValorParcial.Name = "txtValorParcial";
            this.txtValorParcial.Size = new System.Drawing.Size(128, 26);
            this.txtValorParcial.TabIndex = 46;
            // 
            // lblValorParcial
            // 
            this.lblValorParcial.AutoSize = true;
            this.lblValorParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcial.Location = new System.Drawing.Point(32, 451);
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
            this.dataGridView1.Location = new System.Drawing.Point(16, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(591, 184);
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
            this.textBox1.Location = new System.Drawing.Point(379, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 26);
            this.textBox1.TabIndex = 43;
            // 
            // lblValorTotalItem
            // 
            this.lblValorTotalItem.AutoSize = true;
            this.lblValorTotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalItem.Location = new System.Drawing.Point(300, 118);
            this.lblValorTotalItem.Name = "lblValorTotalItem";
            this.lblValorTotalItem.Size = new System.Drawing.Size(56, 20);
            this.lblValorTotalItem.TabIndex = 42;
            this.lblValorTotalItem.Text = "Valor:";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(121, 115);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(128, 26);
            this.txtQuant.TabIndex = 41;
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuant.Location = new System.Drawing.Point(12, 118);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(107, 20);
            this.lblQuant.TabIndex = 40;
            this.lblQuant.Text = "Quantidade:";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(577, 69);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(30, 26);
            this.btnPesquisa.TabIndex = 38;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(121, 69);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(447, 26);
            this.txtProduto.TabIndex = 37;
            // 
            // lblDataSitema
            // 
            this.lblDataSitema.AutoSize = true;
            this.lblDataSitema.Location = new System.Drawing.Point(456, 26);
            this.lblDataSitema.Name = "lblDataSitema";
            this.lblDataSitema.Size = new System.Drawing.Size(51, 20);
            this.lblDataSitema.TabIndex = 36;
            this.lblDataSitema.Text = "label1";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(35, 72);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(77, 20);
            this.lblProduto.TabIndex = 35;
            this.lblProduto.Text = "Produto:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(375, 26);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 20);
            this.lblData.TabIndex = 33;
            this.lblData.Text = "Data:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 28);
            this.comboBox1.TabIndex = 32;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(23, 26);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(92, 20);
            this.lblVendedor.TabIndex = 31;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // tabFormaPagamento
            // 
            this.tabFormaPagamento.BackColor = System.Drawing.Color.Lavender;
            this.tabFormaPagamento.Controls.Add(this.btnFinalizar);
            this.tabFormaPagamento.Controls.Add(this.btnVoltarVenda);
            this.tabFormaPagamento.Controls.Add(this.txtFormaPag);
            this.tabFormaPagamento.Controls.Add(this.txtFormaValorParcial);
            this.tabFormaPagamento.Controls.Add(this.txtFormaValorCompra);
            this.tabFormaPagamento.Controls.Add(this.txtFormaConvenio);
            this.tabFormaPagamento.Controls.Add(this.lblFormaConvenio);
            this.tabFormaPagamento.Controls.Add(this.txtFormaValorTotal);
            this.tabFormaPagamento.Controls.Add(this.lblFormaValorTotal);
            this.tabFormaPagamento.Controls.Add(this.txtFormaDesconto);
            this.tabFormaPagamento.Controls.Add(this.lblFormaDesconto);
            this.tabFormaPagamento.Controls.Add(this.lblFormaPagamento);
            this.tabFormaPagamento.Controls.Add(this.lblFormaParcial);
            this.tabFormaPagamento.Controls.Add(this.lblValorCompra);
            this.tabFormaPagamento.Location = new System.Drawing.Point(4, 29);
            this.tabFormaPagamento.Name = "tabFormaPagamento";
            this.tabFormaPagamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormaPagamento.Size = new System.Drawing.Size(825, 546);
            this.tabFormaPagamento.TabIndex = 2;
            this.tabFormaPagamento.Text = "Forma Pagamento";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(437, 202);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(148, 83);
            this.btnFinalizar.TabIndex = 65;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnVoltarVenda
            // 
            this.btnVoltarVenda.Location = new System.Drawing.Point(437, 34);
            this.btnVoltarVenda.Name = "btnVoltarVenda";
            this.btnVoltarVenda.Size = new System.Drawing.Size(148, 34);
            this.btnVoltarVenda.TabIndex = 64;
            this.btnVoltarVenda.Text = "Voltar";
            this.btnVoltarVenda.UseVisualStyleBackColor = true;
            this.btnVoltarVenda.Click += new System.EventHandler(this.btnVoltarVenda_Click);
            // 
            // txtFormaPag
            // 
            this.txtFormaPag.Location = new System.Drawing.Point(228, 77);
            this.txtFormaPag.Name = "txtFormaPag";
            this.txtFormaPag.Size = new System.Drawing.Size(128, 26);
            this.txtFormaPag.TabIndex = 63;
            // 
            // txtFormaValorParcial
            // 
            this.txtFormaValorParcial.Location = new System.Drawing.Point(227, 122);
            this.txtFormaValorParcial.Name = "txtFormaValorParcial";
            this.txtFormaValorParcial.Size = new System.Drawing.Size(128, 26);
            this.txtFormaValorParcial.TabIndex = 62;
            // 
            // txtFormaValorCompra
            // 
            this.txtFormaValorCompra.Location = new System.Drawing.Point(228, 28);
            this.txtFormaValorCompra.Name = "txtFormaValorCompra";
            this.txtFormaValorCompra.Size = new System.Drawing.Size(128, 26);
            this.txtFormaValorCompra.TabIndex = 61;
            // 
            // txtFormaConvenio
            // 
            this.txtFormaConvenio.Location = new System.Drawing.Point(228, 213);
            this.txtFormaConvenio.Name = "txtFormaConvenio";
            this.txtFormaConvenio.Size = new System.Drawing.Size(128, 26);
            this.txtFormaConvenio.TabIndex = 60;
            // 
            // lblFormaConvenio
            // 
            this.lblFormaConvenio.AutoSize = true;
            this.lblFormaConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaConvenio.Location = new System.Drawing.Point(127, 216);
            this.lblFormaConvenio.Name = "lblFormaConvenio";
            this.lblFormaConvenio.Size = new System.Drawing.Size(88, 20);
            this.lblFormaConvenio.TabIndex = 59;
            this.lblFormaConvenio.Text = "Convênio:";
            // 
            // txtFormaValorTotal
            // 
            this.txtFormaValorTotal.Location = new System.Drawing.Point(227, 262);
            this.txtFormaValorTotal.Name = "txtFormaValorTotal";
            this.txtFormaValorTotal.Size = new System.Drawing.Size(128, 26);
            this.txtFormaValorTotal.TabIndex = 58;
            // 
            // lblFormaValorTotal
            // 
            this.lblFormaValorTotal.AutoSize = true;
            this.lblFormaValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaValorTotal.Location = new System.Drawing.Point(86, 265);
            this.lblFormaValorTotal.Name = "lblFormaValorTotal";
            this.lblFormaValorTotal.Size = new System.Drawing.Size(129, 20);
            this.lblFormaValorTotal.TabIndex = 57;
            this.lblFormaValorTotal.Text = "Valor Total R$:";
            // 
            // txtFormaDesconto
            // 
            this.txtFormaDesconto.Location = new System.Drawing.Point(228, 167);
            this.txtFormaDesconto.Name = "txtFormaDesconto";
            this.txtFormaDesconto.Size = new System.Drawing.Size(128, 26);
            this.txtFormaDesconto.TabIndex = 56;
            // 
            // lblFormaDesconto
            // 
            this.lblFormaDesconto.AutoSize = true;
            this.lblFormaDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaDesconto.Location = new System.Drawing.Point(124, 170);
            this.lblFormaDesconto.Name = "lblFormaDesconto";
            this.lblFormaDesconto.Size = new System.Drawing.Size(91, 20);
            this.lblFormaDesconto.TabIndex = 55;
            this.lblFormaDesconto.Text = "Desconto:";
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPagamento.Location = new System.Drawing.Point(29, 80);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(186, 20);
            this.lblFormaPagamento.TabIndex = 2;
            this.lblFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // lblFormaParcial
            // 
            this.lblFormaParcial.AutoSize = true;
            this.lblFormaParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaParcial.Location = new System.Drawing.Point(72, 125);
            this.lblFormaParcial.Name = "lblFormaParcial";
            this.lblFormaParcial.Size = new System.Drawing.Size(143, 20);
            this.lblFormaParcial.TabIndex = 1;
            this.lblFormaParcial.Text = "Valor Parcial: R$";
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.Location = new System.Drawing.Point(39, 34);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(176, 20);
            this.lblValorCompra.TabIndex = 0;
            this.lblValorCompra.Text = "Valor da Compra: R$";
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 749);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Venda";
            this.Load += new System.EventHandler(this.TelaVenda_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaVenda_Paint);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabCliente.PerformLayout();
            this.tabVenda.ResumeLayout(false);
            this.tabVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabFormaPagamento.ResumeLayout(false);
            this.tabFormaPagamento.PerformLayout();
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
        private System.Windows.Forms.TabPage tabFormaPagamento;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnVoltarVenda;
        private System.Windows.Forms.TextBox txtFormaPag;
        private System.Windows.Forms.TextBox txtFormaValorParcial;
        private System.Windows.Forms.TextBox txtFormaValorCompra;
        private System.Windows.Forms.TextBox txtFormaConvenio;
        private System.Windows.Forms.Label lblFormaConvenio;
        private System.Windows.Forms.TextBox txtFormaValorTotal;
        private System.Windows.Forms.Label lblFormaValorTotal;
        private System.Windows.Forms.TextBox txtFormaDesconto;
        private System.Windows.Forms.Label lblFormaDesconto;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.Label lblFormaParcial;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Button btnContinarVenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}