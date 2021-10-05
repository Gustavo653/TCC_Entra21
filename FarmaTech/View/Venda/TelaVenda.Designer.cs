
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnContinarVenda = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblPrecoTotalProduto = new System.Windows.Forms.Label();
            this.dgVenda = new System.Windows.Forms.DataGridView();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.lblDataSitema = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.tabFormaPagamento = new System.Windows.Forms.TabPage();
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
            this.lblDescontos = new System.Windows.Forms.Label();
            this.txtPrecoUnitario = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecoTotalProduto = new System.Windows.Forms.MaskedTextBox();
            this.txtDesconto = new System.Windows.Forms.MaskedTextBox();
            this.txtValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.cbProdutoVenda = new System.Windows.Forms.ComboBox();
            this.cbQuantidade = new System.Windows.Forms.ComboBox();
            this.DescricaoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnitarioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoTotalProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbConvenio = new System.Windows.Forms.ComboBox();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).BeginInit();
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
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(138, 27);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(311, 29);
            this.txtCnpj.TabIndex = 118;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(138, 85);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(531, 29);
            this.txtRazaoSocial.TabIndex = 117;
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
            this.rbJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJuridica.Location = new System.Drawing.Point(580, 27);
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
            this.lblCpf.Location = new System.Drawing.Point(70, 33);
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
            this.rbFisica.Location = new System.Drawing.Point(482, 27);
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
            this.tabVenda.Controls.Add(this.cbQuantidade);
            this.tabVenda.Controls.Add(this.cbProdutoVenda);
            this.tabVenda.Controls.Add(this.txtValorTotal);
            this.tabVenda.Controls.Add(this.txtDesconto);
            this.tabVenda.Controls.Add(this.txtPrecoTotalProduto);
            this.tabVenda.Controls.Add(this.txtPrecoUnitario);
            this.tabVenda.Controls.Add(this.lblDescontos);
            this.tabVenda.Controls.Add(this.button2);
            this.tabVenda.Controls.Add(this.btnContinarVenda);
            this.tabVenda.Controls.Add(this.btnCancelar);
            this.tabVenda.Controls.Add(this.lblValorTotal);
            this.tabVenda.Controls.Add(this.lblDesconto);
            this.tabVenda.Controls.Add(this.lblPrecoTotalProduto);
            this.tabVenda.Controls.Add(this.dgVenda);
            this.tabVenda.Controls.Add(this.lblPrecoUnitario);
            this.tabVenda.Controls.Add(this.lblQuant);
            this.tabVenda.Controls.Add(this.btnPesquisa);
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
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(709, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.DescricaoCol,
            this.UnidadeCol,
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
            this.txtFormaValorParcial.Location = new System.Drawing.Point(228, 132);
            this.txtFormaValorParcial.Name = "txtFormaValorParcial";
            this.txtFormaValorParcial.Size = new System.Drawing.Size(128, 26);
            this.txtFormaValorParcial.TabIndex = 62;
            // 
            // txtValorCompra
            // 
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
            this.lblFormaConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaConvenio.Location = new System.Drawing.Point(128, 85);
            this.lblFormaConvenio.Name = "lblFormaConvenio";
            this.lblFormaConvenio.Size = new System.Drawing.Size(88, 20);
            this.lblFormaConvenio.TabIndex = 59;
            this.lblFormaConvenio.Text = "Convênio:";
            // 
            // txtFormaValorTotal
            // 
            this.txtFormaValorTotal.Location = new System.Drawing.Point(228, 176);
            this.txtFormaValorTotal.Name = "txtFormaValorTotal";
            this.txtFormaValorTotal.Size = new System.Drawing.Size(128, 26);
            this.txtFormaValorTotal.TabIndex = 58;
            // 
            // lblFormaValorTotal
            // 
            this.lblFormaValorTotal.AutoSize = true;
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
            this.lblValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.Location = new System.Drawing.Point(39, 34);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(176, 20);
            this.lblValorCompra.TabIndex = 0;
            this.lblValorCompra.Text = "Valor da Compra: R$";
            // 
            // lblDescontos
            // 
            this.lblDescontos.AutoSize = true;
            this.lblDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontos.Location = new System.Drawing.Point(121, 366);
            this.lblDescontos.Name = "lblDescontos";
            this.lblDescontos.Size = new System.Drawing.Size(100, 20);
            this.lblDescontos.TabIndex = 58;
            this.lblDescontos.Text = "Descontos:";
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(381, 115);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(126, 26);
            this.txtPrecoUnitario.TabIndex = 59;
            // 
            // txtPrecoTotalProduto
            // 
            this.txtPrecoTotalProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoTotalProduto.Location = new System.Drawing.Point(675, 115);
            this.txtPrecoTotalProduto.Name = "txtPrecoTotalProduto";
            this.txtPrecoTotalProduto.Size = new System.Drawing.Size(118, 26);
            this.txtPrecoTotalProduto.TabIndex = 60;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.ForeColor = System.Drawing.Color.Red;
            this.txtDesconto.Location = new System.Drawing.Point(136, 423);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(128, 29);
            this.txtDesconto.TabIndex = 61;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtValorTotal.Location = new System.Drawing.Point(460, 399);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(143, 35);
            this.txtValorTotal.TabIndex = 63;
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
            // cbQuantidade
            // 
            this.cbQuantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantidade.FormattingEnabled = true;
            this.cbQuantidade.Location = new System.Drawing.Point(121, 115);
            this.cbQuantidade.Name = "cbQuantidade";
            this.cbQuantidade.Size = new System.Drawing.Size(92, 28);
            this.cbQuantidade.TabIndex = 66;
            // 
            // DescricaoCol
            // 
            this.DescricaoCol.HeaderText = "Descrição";
            this.DescricaoCol.Name = "DescricaoCol";
            this.DescricaoCol.ReadOnly = true;
            this.DescricaoCol.Width = 250;
            // 
            // UnidadeCol
            // 
            this.UnidadeCol.HeaderText = "Unid";
            this.UnidadeCol.Name = "UnidadeCol";
            this.UnidadeCol.ReadOnly = true;
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
            // cbConvenio
            // 
            this.cbConvenio.FormattingEnabled = true;
            this.cbConvenio.Location = new System.Drawing.Point(228, 82);
            this.cbConvenio.Name = "cbConvenio";
            this.cbConvenio.Size = new System.Drawing.Size(128, 28);
            this.cbConvenio.TabIndex = 66;
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Location = new System.Drawing.Point(228, 244);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(128, 28);
            this.cbFormaPagamento.TabIndex = 67;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).EndInit();
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
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblPrecoTotalProduto;
        private System.Windows.Forms.DataGridView dgVenda;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label lblDataSitema;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cbVendedor;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblDescontos;
        private System.Windows.Forms.MaskedTextBox txtValorTotal;
        private System.Windows.Forms.MaskedTextBox txtDesconto;
        private System.Windows.Forms.MaskedTextBox txtPrecoTotalProduto;
        private System.Windows.Forms.MaskedTextBox txtPrecoUnitario;
        private System.Windows.Forms.ComboBox cbProdutoVenda;
        private System.Windows.Forms.ComboBox cbQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnitarioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoTotalProduto;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.ComboBox cbConvenio;
    }
}