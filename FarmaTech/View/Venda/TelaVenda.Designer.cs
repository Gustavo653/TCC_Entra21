
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
            this.btnPesquisaProduto = new System.Windows.Forms.Button();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.btnSangria = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.cbNomeCliente = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.lblCpf = new System.Windows.Forms.Label();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.tabVenda = new System.Windows.Forms.TabPage();
            this.btnRemover = new System.Windows.Forms.Button();
            this.cbQuantidade = new System.Windows.Forms.ComboBox();
            this.cbProdutoVenda = new System.Windows.Forms.ComboBox();
            this.txtValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.txtDesconto = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecoTotalProduto = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecoUnitario = new System.Windows.Forms.MaskedTextBox();
            this.lblDescontos = new System.Windows.Forms.Label();
            this.btnAdiciona = new System.Windows.Forms.Button();
            this.btnContinarVenda = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblPrecoTotalProduto = new System.Windows.Forms.Label();
            this.dgVenda = new System.Windows.Forms.DataGridView();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblDataSitema = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.tabFormaPagamento = new System.Windows.Forms.TabPage();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.cbConvenio = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnVoltarVenda = new System.Windows.Forms.Button();
            this.txtFormaValorParcial = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.lblFormaConvenio = new System.Windows.Forms.Label();
            this.txtFormaValorTotal = new System.Windows.Forms.TextBox();
            this.lblFormaValorTotal = new System.Windows.Forms.Label();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.lblFormaParcial = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnitarioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoTotalProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).BeginInit();
            this.tabFormaPagamento.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.btnPesquisaProduto);
            this.panel1.Controls.Add(this.btnPesquisaCliente);
            this.panel1.Controls.Add(this.btnSangria);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Location = new System.Drawing.Point(130, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 111);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnPesquisaProduto
            // 
            this.btnPesquisaProduto.Location = new System.Drawing.Point(301, 21);
            this.btnPesquisaProduto.Name = "btnPesquisaProduto";
            this.btnPesquisaProduto.Size = new System.Drawing.Size(75, 75);
            this.btnPesquisaProduto.TabIndex = 14;
            this.btnPesquisaProduto.Text = "Pesquisa Produto";
            this.btnPesquisaProduto.UseVisualStyleBackColor = true;
            this.btnPesquisaProduto.Click += new System.EventHandler(this.btnPesquisaProduto_Click);
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.Location = new System.Drawing.Point(425, 21);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(75, 75);
            this.btnPesquisaCliente.TabIndex = 121;
            this.btnPesquisaCliente.Text = "Pesquisa Cliente";
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // btnSangria
            // 
            this.btnSangria.Location = new System.Drawing.Point(190, 21);
            this.btnSangria.Name = "btnSangria";
            this.btnSangria.Size = new System.Drawing.Size(75, 75);
            this.btnSangria.TabIndex = 13;
            this.btnSangria.Text = "Sangria";
            this.btnSangria.UseVisualStyleBackColor = true;
            this.btnSangria.Click += new System.EventHandler(this.btnSangria_Click);
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
            this.tabCliente.Controls.Add(this.cbNomeCliente);
            this.tabCliente.Controls.Add(this.cbCliente);
            this.tabCliente.Controls.Add(this.btnContinuar);
            this.tabCliente.Controls.Add(this.txtObservacao);
            this.tabCliente.Controls.Add(this.lblObservacao);
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
            this.tabCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.tabCliente_Paint_1);
            // 
            // cbNomeCliente
            // 
            this.cbNomeCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNomeCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNomeCliente.FormattingEnabled = true;
            this.cbNomeCliente.Location = new System.Drawing.Point(138, 88);
            this.cbNomeCliente.Name = "cbNomeCliente";
            this.cbNomeCliente.Size = new System.Drawing.Size(531, 28);
            this.cbNomeCliente.TabIndex = 124;
            this.cbNomeCliente.SelectedIndexChanged += new System.EventHandler(this.cbNomeCliente_SelectedIndexChanged);
            // 
            // cbCliente
            // 
            this.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(138, 30);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(259, 28);
            this.cbCliente.TabIndex = 123;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(421, 221);
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
            this.txtObservacao.Location = new System.Drawing.Point(138, 148);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(531, 29);
            this.txtObservacao.TabIndex = 120;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.Color.Transparent;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(11, 154);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(109, 20);
            this.lblObservacao.TabIndex = 119;
            this.lblObservacao.Text = "Observação:";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(60, 91);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 116;
            this.lblNome.Text = "Nome:";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.BackColor = System.Drawing.Color.Transparent;
            this.rbJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJuridica.Location = new System.Drawing.Point(580, 27);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(89, 24);
            this.rbJuridica.TabIndex = 115;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = false;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(70, 33);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(48, 20);
            this.lblCpf.TabIndex = 113;
            this.lblCpf.Text = "CPF:";
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.BackColor = System.Drawing.Color.Transparent;
            this.rbFisica.Checked = true;
            this.rbFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFisica.Location = new System.Drawing.Point(482, 27);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(74, 24);
            this.rbFisica.TabIndex = 114;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = false;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // tabVenda
            // 
            this.tabVenda.BackColor = System.Drawing.Color.Lavender;
            this.tabVenda.Controls.Add(this.btnRemover);
            this.tabVenda.Controls.Add(this.cbQuantidade);
            this.tabVenda.Controls.Add(this.cbProdutoVenda);
            this.tabVenda.Controls.Add(this.txtValorTotal);
            this.tabVenda.Controls.Add(this.txtDesconto);
            this.tabVenda.Controls.Add(this.txtPrecoTotalProduto);
            this.tabVenda.Controls.Add(this.txtPrecoUnitario);
            this.tabVenda.Controls.Add(this.lblDescontos);
            this.tabVenda.Controls.Add(this.btnAdiciona);
            this.tabVenda.Controls.Add(this.btnContinarVenda);
            this.tabVenda.Controls.Add(this.btnCancelar);
            this.tabVenda.Controls.Add(this.lblValorTotal);
            this.tabVenda.Controls.Add(this.lblDesconto);
            this.tabVenda.Controls.Add(this.lblPrecoTotalProduto);
            this.tabVenda.Controls.Add(this.dgVenda);
            this.tabVenda.Controls.Add(this.lblPrecoUnitario);
            this.tabVenda.Controls.Add(this.lblQuant);
            this.tabVenda.Controls.Add(this.lblDataSitema);
            this.tabVenda.Controls.Add(this.lblProduto);
            this.tabVenda.Controls.Add(this.lblData);
            this.tabVenda.Controls.Add(this.cbVendedor);
            this.tabVenda.Controls.Add(this.lblVendedor);
            this.tabVenda.Location = new System.Drawing.Point(4, 29);
            this.tabVenda.Name = "tabVenda";
            this.tabVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenda.Size = new System.Drawing.Size(825, 546);
            this.tabVenda.TabIndex = 0;
            this.tabVenda.Text = "Venda";
            this.tabVenda.Paint += new System.Windows.Forms.PaintEventHandler(this.tabVenda_Paint_1);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(657, 45);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(54, 58);
            this.btnRemover.TabIndex = 67;
            this.btnRemover.Text = "-";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // cbQuantidade
            // 
            this.cbQuantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantidade.FormattingEnabled = true;
            this.cbQuantidade.Location = new System.Drawing.Point(121, 115);
            this.cbQuantidade.Name = "cbQuantidade";
            this.cbQuantidade.Size = new System.Drawing.Size(92, 28);
            this.cbQuantidade.TabIndex = 66;
            // 
            // cbProdutoVenda
            // 
            this.cbProdutoVenda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProdutoVenda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProdutoVenda.FormattingEnabled = true;
            this.cbProdutoVenda.Location = new System.Drawing.Point(121, 69);
            this.cbProdutoVenda.Name = "cbProdutoVenda";
            this.cbProdutoVenda.Size = new System.Drawing.Size(432, 28);
            this.cbProdutoVenda.TabIndex = 65;
            this.cbProdutoVenda.SelectedIndexChanged += new System.EventHandler(this.cbProdutoVenda_SelectedIndexChanged);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtValorTotal.Location = new System.Drawing.Point(460, 399);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(143, 35);
            this.txtValorTotal.TabIndex = 63;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.ForeColor = System.Drawing.Color.Red;
            this.txtDesconto.Location = new System.Drawing.Point(136, 423);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(128, 29);
            this.txtDesconto.TabIndex = 61;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            this.txtDesconto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDesconto_KeyUp);
            // 
            // txtPrecoTotalProduto
            // 
            this.txtPrecoTotalProduto.Enabled = false;
            this.txtPrecoTotalProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoTotalProduto.Location = new System.Drawing.Point(675, 115);
            this.txtPrecoTotalProduto.Name = "txtPrecoTotalProduto";
            this.txtPrecoTotalProduto.Size = new System.Drawing.Size(118, 26);
            this.txtPrecoTotalProduto.TabIndex = 60;
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Enabled = false;
            this.txtPrecoUnitario.Location = new System.Drawing.Point(381, 115);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(126, 26);
            this.txtPrecoUnitario.TabIndex = 59;
            // 
            // lblDescontos
            // 
            this.lblDescontos.AutoSize = true;
            this.lblDescontos.BackColor = System.Drawing.Color.Transparent;
            this.lblDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontos.Location = new System.Drawing.Point(121, 366);
            this.lblDescontos.Name = "lblDescontos";
            this.lblDescontos.Size = new System.Drawing.Size(100, 20);
            this.lblDescontos.TabIndex = 58;
            this.lblDescontos.Text = "Descontos:";
            // 
            // btnAdiciona
            // 
            this.btnAdiciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdiciona.Location = new System.Drawing.Point(593, 45);
            this.btnAdiciona.Name = "btnAdiciona";
            this.btnAdiciona.Size = new System.Drawing.Size(54, 58);
            this.btnAdiciona.TabIndex = 57;
            this.btnAdiciona.Text = "+";
            this.btnAdiciona.UseVisualStyleBackColor = true;
            this.btnAdiciona.Click += new System.EventHandler(this.btnAdiciona_Click);
            // 
            // btnContinarVenda
            // 
            this.btnContinarVenda.Location = new System.Drawing.Point(656, 435);
            this.btnContinarVenda.Name = "btnContinarVenda";
            this.btnContinarVenda.Size = new System.Drawing.Size(128, 92);
            this.btnContinarVenda.TabIndex = 56;
            this.btnContinarVenda.Text = "Continuar";
            this.btnContinarVenda.UseVisualStyleBackColor = true;
            this.btnContinarVenda.Click += new System.EventHandler(this.btnContinarVenda_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(656, 401);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 28);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(331, 409);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(129, 20);
            this.lblValorTotal.TabIndex = 51;
            this.lblValorTotal.Text = "Valor Total R$:";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.BackColor = System.Drawing.Color.Transparent;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Location = new System.Drawing.Point(32, 426);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(91, 20);
            this.lblDesconto.TabIndex = 47;
            this.lblDesconto.Text = "Desconto:";
            // 
            // lblPrecoTotalProduto
            // 
            this.lblPrecoTotalProduto.AutoSize = true;
            this.lblPrecoTotalProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoTotalProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoTotalProduto.Location = new System.Drawing.Point(536, 118);
            this.lblPrecoTotalProduto.Name = "lblPrecoTotalProduto";
            this.lblPrecoTotalProduto.Size = new System.Drawing.Size(133, 20);
            this.lblPrecoTotalProduto.TabIndex = 45;
            this.lblPrecoTotalProduto.Text = "Preço Total: R$";
            // 
            // dgVenda
            // 
            this.dgVenda.AllowUserToAddRows = false;
            this.dgVenda.AllowUserToDeleteRows = false;
            this.dgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCol,
            this.QuantidadeCol,
            this.PrecoUnitarioCol,
            this.PrecoTotalProduto});
            this.dgVenda.Location = new System.Drawing.Point(16, 161);
            this.dgVenda.Name = "dgVenda";
            this.dgVenda.ReadOnly = true;
            this.dgVenda.Size = new System.Drawing.Size(777, 184);
            this.dgVenda.TabIndex = 44;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoUnitario.Location = new System.Drawing.Point(219, 118);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(156, 20);
            this.lblPrecoUnitario.TabIndex = 42;
            this.lblPrecoUnitario.Text = "Preço Unitário: R$";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.BackColor = System.Drawing.Color.Transparent;
            this.lblQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuant.Location = new System.Drawing.Point(12, 118);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(107, 20);
            this.lblQuant.TabIndex = 40;
            this.lblQuant.Text = "Quantidade:";
            // 
            // lblDataSitema
            // 
            this.lblDataSitema.AutoSize = true;
            this.lblDataSitema.BackColor = System.Drawing.Color.Transparent;
            this.lblDataSitema.Location = new System.Drawing.Point(456, 26);
            this.lblDataSitema.Name = "lblDataSitema";
            this.lblDataSitema.Size = new System.Drawing.Size(51, 20);
            this.lblDataSitema.TabIndex = 36;
            this.lblDataSitema.Text = "label1";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.BackColor = System.Drawing.Color.Transparent;
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
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(375, 26);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 20);
            this.lblData.TabIndex = 33;
            this.lblData.Text = "Data:";
            // 
            // cbVendedor
            // 
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(121, 23);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(184, 28);
            this.cbVendedor.TabIndex = 32;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.BackColor = System.Drawing.Color.Transparent;
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
            this.tabFormaPagamento.Controls.Add(this.cbFormaPagamento);
            this.tabFormaPagamento.Controls.Add(this.cbConvenio);
            this.tabFormaPagamento.Controls.Add(this.btnFinalizar);
            this.tabFormaPagamento.Controls.Add(this.btnVoltarVenda);
            this.tabFormaPagamento.Controls.Add(this.txtFormaValorParcial);
            this.tabFormaPagamento.Controls.Add(this.txtValorCompra);
            this.tabFormaPagamento.Controls.Add(this.lblFormaConvenio);
            this.tabFormaPagamento.Controls.Add(this.txtFormaValorTotal);
            this.tabFormaPagamento.Controls.Add(this.lblFormaValorTotal);
            this.tabFormaPagamento.Controls.Add(this.lblFormaPagamento);
            this.tabFormaPagamento.Controls.Add(this.lblFormaParcial);
            this.tabFormaPagamento.Controls.Add(this.lblValorCompra);
            this.tabFormaPagamento.Location = new System.Drawing.Point(4, 29);
            this.tabFormaPagamento.Name = "tabFormaPagamento";
            this.tabFormaPagamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormaPagamento.Size = new System.Drawing.Size(825, 546);
            this.tabFormaPagamento.TabIndex = 2;
            this.tabFormaPagamento.Text = "Forma Pagamento";
            this.tabFormaPagamento.Paint += new System.Windows.Forms.PaintEventHandler(this.tabFormaPagamento_Paint);
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Location = new System.Drawing.Point(228, 244);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(128, 28);
            this.cbFormaPagamento.TabIndex = 67;
            // 
            // cbConvenio
            // 
            this.cbConvenio.FormattingEnabled = true;
            this.cbConvenio.Location = new System.Drawing.Point(228, 82);
            this.cbConvenio.Name = "cbConvenio";
            this.cbConvenio.Size = new System.Drawing.Size(128, 28);
            this.cbConvenio.TabIndex = 66;
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
            // txtFormaValorParcial
            // 
            this.txtFormaValorParcial.Enabled = false;
            this.txtFormaValorParcial.Location = new System.Drawing.Point(228, 132);
            this.txtFormaValorParcial.Name = "txtFormaValorParcial";
            this.txtFormaValorParcial.Size = new System.Drawing.Size(128, 26);
            this.txtFormaValorParcial.TabIndex = 62;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Enabled = false;
            this.txtValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCompra.ForeColor = System.Drawing.Color.Blue;
            this.txtValorCompra.Location = new System.Drawing.Point(228, 28);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(128, 29);
            this.txtValorCompra.TabIndex = 61;
            // 
            // lblFormaConvenio
            // 
            this.lblFormaConvenio.AutoSize = true;
            this.lblFormaConvenio.BackColor = System.Drawing.Color.Transparent;
            this.lblFormaConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaConvenio.Location = new System.Drawing.Point(128, 85);
            this.lblFormaConvenio.Name = "lblFormaConvenio";
            this.lblFormaConvenio.Size = new System.Drawing.Size(88, 20);
            this.lblFormaConvenio.TabIndex = 59;
            this.lblFormaConvenio.Text = "Convênio:";
            // 
            // txtFormaValorTotal
            // 
            this.txtFormaValorTotal.Enabled = false;
            this.txtFormaValorTotal.Location = new System.Drawing.Point(228, 176);
            this.txtFormaValorTotal.Name = "txtFormaValorTotal";
            this.txtFormaValorTotal.Size = new System.Drawing.Size(128, 26);
            this.txtFormaValorTotal.TabIndex = 58;
            // 
            // lblFormaValorTotal
            // 
            this.lblFormaValorTotal.AutoSize = true;
            this.lblFormaValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblFormaValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaValorTotal.Location = new System.Drawing.Point(87, 179);
            this.lblFormaValorTotal.Name = "lblFormaValorTotal";
            this.lblFormaValorTotal.Size = new System.Drawing.Size(129, 20);
            this.lblFormaValorTotal.TabIndex = 57;
            this.lblFormaValorTotal.Text = "Valor Total R$:";
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.BackColor = System.Drawing.Color.Transparent;
            this.lblFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPagamento.Location = new System.Drawing.Point(30, 247);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(186, 20);
            this.lblFormaPagamento.TabIndex = 2;
            this.lblFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // lblFormaParcial
            // 
            this.lblFormaParcial.AutoSize = true;
            this.lblFormaParcial.BackColor = System.Drawing.Color.Transparent;
            this.lblFormaParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaParcial.Location = new System.Drawing.Point(73, 135);
            this.lblFormaParcial.Name = "lblFormaParcial";
            this.lblFormaParcial.Size = new System.Drawing.Size(143, 20);
            this.lblFormaParcial.TabIndex = 1;
            this.lblFormaParcial.Text = "Valor Parcial: R$";
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.Location = new System.Drawing.Point(39, 34);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(176, 20);
            this.lblValorCompra.TabIndex = 0;
            this.lblValorCompra.Text = "Valor da Compra: R$";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 719);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 30);
            this.panel2.TabIndex = 102;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblHora.Location = new System.Drawing.Point(779, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 13);
            this.lblHora.TabIndex = 87;
            this.lblHora.Text = "Hora";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 13);
            this.lblDate.TabIndex = 86;
            this.lblDate.Text = "Data";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // NomeCol
            // 
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.Name = "NomeCol";
            this.NomeCol.ReadOnly = true;
            this.NomeCol.Width = 250;
            // 
            // QuantidadeCol
            // 
            this.QuantidadeCol.HeaderText = "Quantidade";
            this.QuantidadeCol.Name = "QuantidadeCol";
            this.QuantidadeCol.ReadOnly = true;
            // 
            // PrecoUnitarioCol
            // 
            this.PrecoUnitarioCol.HeaderText = "Preço Unit.";
            this.PrecoUnitarioCol.Name = "PrecoUnitarioCol";
            this.PrecoUnitarioCol.ReadOnly = true;
            this.PrecoUnitarioCol.Width = 130;
            // 
            // PrecoTotalProduto
            // 
            this.PrecoTotalProduto.HeaderText = "Valor Total";
            this.PrecoTotalProduto.Name = "PrecoTotalProduto";
            this.PrecoTotalProduto.ReadOnly = true;
            this.PrecoTotalProduto.Width = 150;
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 749);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).EndInit();
            this.tabFormaPagamento.ResumeLayout(false);
            this.tabFormaPagamento.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSangria;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.TabPage tabVenda;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblPrecoTotalProduto;
        private System.Windows.Forms.DataGridView dgVenda;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblDataSitema;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cbVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.Button btnPesquisaProduto;
        private System.Windows.Forms.TabPage tabFormaPagamento;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnVoltarVenda;
        private System.Windows.Forms.TextBox txtFormaValorParcial;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label lblFormaConvenio;
        private System.Windows.Forms.TextBox txtFormaValorTotal;
        private System.Windows.Forms.Label lblFormaValorTotal;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.Label lblFormaParcial;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Button btnContinarVenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAdiciona;
        private System.Windows.Forms.Label lblDescontos;
        private System.Windows.Forms.MaskedTextBox txtValorTotal;
        private System.Windows.Forms.MaskedTextBox txtDesconto;
        private System.Windows.Forms.MaskedTextBox txtPrecoTotalProduto;
        private System.Windows.Forms.MaskedTextBox txtPrecoUnitario;
        private System.Windows.Forms.ComboBox cbProdutoVenda;
        private System.Windows.Forms.ComboBox cbQuantidade;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.ComboBox cbConvenio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnitarioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoTotalProduto;
    }
}