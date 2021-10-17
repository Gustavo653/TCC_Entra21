
namespace FarmaTech.View
{
    partial class TelaCadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroProdutos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProdutos = new System.Windows.Forms.TabPage();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.txtPesquisaUsuario = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.tabNovoProduto = new System.Windows.Forms.TabPage();
            this.cboUnidade = new System.Windows.Forms.ComboBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaboratorioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnitarioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.tabNovoProduto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProdutos);
            this.tabControl1.Controls.Add(this.tabNovoProduto);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(128, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 437);
            this.tabControl1.TabIndex = 78;
            // 
            // tabProdutos
            // 
            this.tabProdutos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabProdutos.Controls.Add(this.dgProdutos);
            this.tabProdutos.Controls.Add(this.txtPesquisaUsuario);
            this.tabProdutos.Controls.Add(this.lblPesquisar);
            this.tabProdutos.Location = new System.Drawing.Point(4, 29);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProdutos.Size = new System.Drawing.Size(916, 404);
            this.tabProdutos.TabIndex = 0;
            this.tabProdutos.Text = "Produtos";
            this.tabProdutos.Paint += new System.Windows.Forms.PaintEventHandler(this.tabProdutos_Paint);
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCol,
            this.LaboratorioCol,
            this.QuantidadeCol,
            this.PrecoUnitarioCol});
            this.dgProdutos.Location = new System.Drawing.Point(31, 91);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.Size = new System.Drawing.Size(852, 282);
            this.dgProdutos.TabIndex = 20;
            this.dgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProdutos_CellContentClick);
            // 
            // txtPesquisaUsuario
            // 
            this.txtPesquisaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaUsuario.Location = new System.Drawing.Point(349, 32);
            this.txtPesquisaUsuario.Name = "txtPesquisaUsuario";
            this.txtPesquisaUsuario.Size = new System.Drawing.Size(300, 26);
            this.txtPesquisaUsuario.TabIndex = 19;
            this.txtPesquisaUsuario.TextChanged += new System.EventHandler(this.txtPesquisaUsuario_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(250, 35);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(93, 20);
            this.lblPesquisar.TabIndex = 17;
            this.lblPesquisar.Text = "Pesquisar:";
            this.lblPesquisar.Click += new System.EventHandler(this.lblPesquisar_Click);
            // 
            // tabNovoProduto
            // 
            this.tabNovoProduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabNovoProduto.Controls.Add(this.cboUnidade);
            this.tabNovoProduto.Controls.Add(this.txtGrupo);
            this.tabNovoProduto.Controls.Add(this.label7);
            this.tabNovoProduto.Controls.Add(this.txtPrecoUnitario);
            this.tabNovoProduto.Controls.Add(this.label6);
            this.tabNovoProduto.Controls.Add(this.txtPrecoCusto);
            this.tabNovoProduto.Controls.Add(this.label3);
            this.tabNovoProduto.Controls.Add(this.txtCodigo);
            this.tabNovoProduto.Controls.Add(this.label4);
            this.tabNovoProduto.Controls.Add(this.txtLaboratorio);
            this.tabNovoProduto.Controls.Add(this.label5);
            this.tabNovoProduto.Controls.Add(this.txtQuantidade);
            this.tabNovoProduto.Controls.Add(this.label2);
            this.tabNovoProduto.Controls.Add(this.label1);
            this.tabNovoProduto.Controls.Add(this.txtNome);
            this.tabNovoProduto.Controls.Add(this.lblRazaoSocial);
            this.tabNovoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNovoProduto.Location = new System.Drawing.Point(4, 29);
            this.tabNovoProduto.Name = "tabNovoProduto";
            this.tabNovoProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovoProduto.Size = new System.Drawing.Size(916, 404);
            this.tabNovoProduto.TabIndex = 1;
            this.tabNovoProduto.Text = "Novo Produto";
            this.tabNovoProduto.Paint += new System.Windows.Forms.PaintEventHandler(this.tabNovoProduto_Paint);
            // 
            // cboUnidade
            // 
            this.cboUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidade.FormattingEnabled = true;
            this.cboUnidade.Location = new System.Drawing.Point(585, 85);
            this.cboUnidade.Name = "cboUnidade";
            this.cboUnidade.Size = new System.Drawing.Size(248, 28);
            this.cboUnidade.TabIndex = 81;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupo.Location = new System.Drawing.Point(725, 141);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(134, 29);
            this.txtGrupo.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(655, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Grupo:";
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUnitario.Location = new System.Drawing.Point(466, 207);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(134, 29);
            this.txtPrecoUnitario.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Preço Unitário:";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCusto.Location = new System.Drawing.Point(142, 201);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(134, 29);
            this.txtPrecoCusto.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Preço Custo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(466, 138);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(160, 29);
            this.txtCodigo.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Laboratório:";
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaboratorio.Location = new System.Drawing.Point(142, 82);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(318, 29);
            this.txtLaboratorio.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Código:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(142, 141);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(211, 29);
            this.txtQuantidade.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Em estoque:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Unidade:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(142, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(691, 29);
            this.txtNome.TabIndex = 66;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(67, 39);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(60, 20);
            this.lblRazaoSocial.TabIndex = 65;
            this.lblRazaoSocial.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 570);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 30);
            this.panel1.TabIndex = 89;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblHora.Location = new System.Drawing.Point(987, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 13);
            this.lblHora.TabIndex = 87;
            this.lblHora.Text = "Hora";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
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
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.BackColor = System.Drawing.Color.Transparent;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(871, 38);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(144, 36);
            this.lblProd.TabIndex = 90;
            this.lblProd.Text = "Produtos";
            this.lblProd.Click += new System.EventHandler(this.lblProd_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(15, 179);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 96);
            this.btnNovo.TabIndex = 83;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(15, 450);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 96);
            this.btnExcluir.TabIndex = 82;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(15, 359);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(95, 96);
            this.btnAlterar.TabIndex = 81;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(15, 269);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 96);
            this.btnSalvar.TabIndex = 80;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(15, 88);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 96);
            this.btnVoltar.TabIndex = 79;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // NomeCol
            // 
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.Name = "NomeCol";
            this.NomeCol.ReadOnly = true;
            this.NomeCol.Width = 200;
            // 
            // LaboratorioCol
            // 
            this.LaboratorioCol.HeaderText = "Laboratorio";
            this.LaboratorioCol.Name = "LaboratorioCol";
            this.LaboratorioCol.ReadOnly = true;
            this.LaboratorioCol.Width = 150;
            // 
            // QuantidadeCol
            // 
            this.QuantidadeCol.HeaderText = "Quantidade";
            this.QuantidadeCol.Name = "QuantidadeCol";
            this.QuantidadeCol.ReadOnly = true;
            this.QuantidadeCol.Width = 150;
            // 
            // PrecoUnitarioCol
            // 
            this.PrecoUnitarioCol.HeaderText = "Preço Unit.";
            this.PrecoUnitarioCol.Name = "PrecoUnitarioCol";
            this.PrecoUnitarioCol.ReadOnly = true;
            this.PrecoUnitarioCol.Width = 150;
            // 
            // TelaCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1028, 600);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TelaCadastroProdutos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Cadastro Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadastroProdutos_FormClosed);
            this.Load += new System.EventHandler(this.TelaCadastroProdutos_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaCadastroProdutos_Paint);
            this.tabControl1.ResumeLayout(false);
            this.tabProdutos.ResumeLayout(false);
            this.tabProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.tabNovoProduto.ResumeLayout(false);
            this.tabNovoProduto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProdutos;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.TextBox txtPesquisaUsuario;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TabPage tabNovoProduto;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.ComboBox cboUnidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaboratorioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnitarioCol;
    }
}