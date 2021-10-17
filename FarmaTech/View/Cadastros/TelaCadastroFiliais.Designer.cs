
namespace FarmaTech.View
{
    partial class TelaCadastroFiliais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroFiliais));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFiliais = new System.Windows.Forms.TabPage();
            this.dgFiliais = new System.Windows.Forms.DataGridView();
            this.NomeFantasiaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CnpjCpfCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContatoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaUsuario = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.tabNovoFilial = new System.Windows.Forms.TabPage();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCompl = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCompl = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblFiliais = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabFiliais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiliais)).BeginInit();
            this.tabNovoFilial.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(41, 202);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 95);
            this.btnNovo.TabIndex = 66;
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
            this.btnExcluir.Location = new System.Drawing.Point(41, 473);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 95);
            this.btnExcluir.TabIndex = 65;
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
            this.btnAlterar.Location = new System.Drawing.Point(41, 383);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(95, 95);
            this.btnAlterar.TabIndex = 64;
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
            this.btnSalvar.Location = new System.Drawing.Point(41, 292);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 95);
            this.btnSalvar.TabIndex = 63;
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
            this.btnVoltar.Location = new System.Drawing.Point(41, 116);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 95);
            this.btnVoltar.TabIndex = 62;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFiliais);
            this.tabControl1.Controls.Add(this.tabNovoFilial);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(169, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 542);
            this.tabControl1.TabIndex = 61;
            // 
            // tabFiliais
            // 
            this.tabFiliais.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabFiliais.Controls.Add(this.dgFiliais);
            this.tabFiliais.Controls.Add(this.txtPesquisaUsuario);
            this.tabFiliais.Controls.Add(this.lblPesquisar);
            this.tabFiliais.Location = new System.Drawing.Point(4, 29);
            this.tabFiliais.Name = "tabFiliais";
            this.tabFiliais.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiliais.Size = new System.Drawing.Size(1034, 509);
            this.tabFiliais.TabIndex = 0;
            this.tabFiliais.Text = "Filiais";
            this.tabFiliais.Paint += new System.Windows.Forms.PaintEventHandler(this.tabFiliais_Paint);
            // 
            // dgFiliais
            // 
            this.dgFiliais.AllowUserToAddRows = false;
            this.dgFiliais.AllowUserToDeleteRows = false;
            this.dgFiliais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiliais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeFantasiaCol,
            this.CnpjCpfCol,
            this.ContatoCol,
            this.RuaCol,
            this.NumeroCol,
            this.CidadeCol,
            this.EstadoCol});
            this.dgFiliais.Location = new System.Drawing.Point(57, 106);
            this.dgFiliais.Name = "dgFiliais";
            this.dgFiliais.ReadOnly = true;
            this.dgFiliais.Size = new System.Drawing.Size(940, 368);
            this.dgFiliais.TabIndex = 16;
            // 
            // NomeFantasiaCol
            // 
            this.NomeFantasiaCol.HeaderText = "Nome Fantasia";
            this.NomeFantasiaCol.Name = "NomeFantasiaCol";
            this.NomeFantasiaCol.ReadOnly = true;
            this.NomeFantasiaCol.Width = 200;
            // 
            // CnpjCpfCol
            // 
            this.CnpjCpfCol.HeaderText = "Cnpj / Cpf";
            this.CnpjCpfCol.Name = "CnpjCpfCol";
            this.CnpjCpfCol.ReadOnly = true;
            this.CnpjCpfCol.Width = 150;
            // 
            // ContatoCol
            // 
            this.ContatoCol.HeaderText = "Contato";
            this.ContatoCol.Name = "ContatoCol";
            this.ContatoCol.ReadOnly = true;
            this.ContatoCol.Width = 150;
            // 
            // RuaCol
            // 
            this.RuaCol.HeaderText = "Endereço";
            this.RuaCol.Name = "RuaCol";
            this.RuaCol.ReadOnly = true;
            this.RuaCol.Width = 200;
            // 
            // NumeroCol
            // 
            this.NumeroCol.HeaderText = "Nº";
            this.NumeroCol.Name = "NumeroCol";
            this.NumeroCol.ReadOnly = true;
            this.NumeroCol.Width = 50;
            // 
            // CidadeCol
            // 
            this.CidadeCol.HeaderText = "Cidade";
            this.CidadeCol.Name = "CidadeCol";
            this.CidadeCol.ReadOnly = true;
            // 
            // EstadoCol
            // 
            this.EstadoCol.HeaderText = "Estado";
            this.EstadoCol.Name = "EstadoCol";
            this.EstadoCol.ReadOnly = true;
            this.EstadoCol.Width = 50;
            // 
            // txtPesquisaUsuario
            // 
            this.txtPesquisaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaUsuario.Location = new System.Drawing.Point(415, 42);
            this.txtPesquisaUsuario.Name = "txtPesquisaUsuario";
            this.txtPesquisaUsuario.Size = new System.Drawing.Size(300, 26);
            this.txtPesquisaUsuario.TabIndex = 15;
            this.txtPesquisaUsuario.TextChanged += new System.EventHandler(this.txtPesquisaUsuario_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(316, 45);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(93, 20);
            this.lblPesquisar.TabIndex = 13;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // tabNovoFilial
            // 
            this.tabNovoFilial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabNovoFilial.Controls.Add(this.cboEstados);
            this.tabNovoFilial.Controls.Add(this.lblContato);
            this.tabNovoFilial.Controls.Add(this.txtContato);
            this.tabNovoFilial.Controls.Add(this.txtNomeFantasia);
            this.tabNovoFilial.Controls.Add(this.lblNomeFantasia);
            this.tabNovoFilial.Controls.Add(this.lblRazaoSocial);
            this.tabNovoFilial.Controls.Add(this.lblCnpj);
            this.tabNovoFilial.Controls.Add(this.txtCnpj);
            this.tabNovoFilial.Controls.Add(this.txtCidade);
            this.tabNovoFilial.Controls.Add(this.txtCompl);
            this.tabNovoFilial.Controls.Add(this.txtNumero);
            this.tabNovoFilial.Controls.Add(this.txtEndereco);
            this.tabNovoFilial.Controls.Add(this.lblCidade);
            this.tabNovoFilial.Controls.Add(this.lblEstado);
            this.tabNovoFilial.Controls.Add(this.lblNumero);
            this.tabNovoFilial.Controls.Add(this.lblCompl);
            this.tabNovoFilial.Controls.Add(this.lblEndereco);
            this.tabNovoFilial.Controls.Add(this.txtRazaoSocial);
            this.tabNovoFilial.Location = new System.Drawing.Point(4, 29);
            this.tabNovoFilial.Name = "tabNovoFilial";
            this.tabNovoFilial.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovoFilial.Size = new System.Drawing.Size(1034, 509);
            this.tabNovoFilial.TabIndex = 1;
            this.tabNovoFilial.Text = "Nova Filial";
            this.tabNovoFilial.Paint += new System.Windows.Forms.PaintEventHandler(this.tabNovoFilial_Paint);
            // 
            // cboEstados
            // 
            this.cboEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(773, 275);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(121, 28);
            this.cboEstados.TabIndex = 102;
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.BackColor = System.Drawing.Color.Transparent;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(579, 333);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(78, 20);
            this.lblContato.TabIndex = 81;
            this.lblContato.Text = "Contato:";
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(663, 330);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(253, 26);
            this.txtContato.TabIndex = 82;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(271, 110);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(645, 29);
            this.txtNomeFantasia.TabIndex = 78;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.Location = new System.Drawing.Point(114, 116);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(135, 20);
            this.lblNomeFantasia.TabIndex = 77;
            this.lblNomeFantasia.Text = "Nome Fantasia:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(129, 59);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(120, 20);
            this.lblRazaoSocial.TabIndex = 67;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.BackColor = System.Drawing.Color.Transparent;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(190, 333);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(50, 20);
            this.lblCnpj.TabIndex = 80;
            this.lblCnpj.Text = "Cnpj:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(271, 327);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(284, 29);
            this.txtCnpj.TabIndex = 79;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(271, 272);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(401, 29);
            this.txtCidade.TabIndex = 76;
            // 
            // txtCompl
            // 
            this.txtCompl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompl.Location = new System.Drawing.Point(271, 217);
            this.txtCompl.Name = "txtCompl";
            this.txtCompl.Size = new System.Drawing.Size(401, 29);
            this.txtCompl.TabIndex = 75;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(783, 217);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(133, 29);
            this.txtNumero.TabIndex = 74;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(271, 165);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(645, 29);
            this.txtEndereco.TabIndex = 72;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(179, 278);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(70, 20);
            this.lblCidade.TabIndex = 71;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(696, 278);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(71, 20);
            this.lblEstado.TabIndex = 70;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(696, 223);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(81, 20);
            this.lblNumero.TabIndex = 69;
            this.lblNumero.Text = "Número: ";
            // 
            // lblCompl
            // 
            this.lblCompl.AutoSize = true;
            this.lblCompl.BackColor = System.Drawing.Color.Transparent;
            this.lblCompl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompl.Location = new System.Drawing.Point(180, 223);
            this.lblCompl.Name = "lblCompl";
            this.lblCompl.Size = new System.Drawing.Size(69, 20);
            this.lblCompl.TabIndex = 66;
            this.lblCompl.Text = "Compl.:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(158, 171);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(91, 20);
            this.lblEndereco.TabIndex = 65;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(271, 53);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(645, 26);
            this.txtRazaoSocial.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 649);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 30);
            this.panel1.TabIndex = 88;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblHora.Location = new System.Drawing.Point(1125, 9);
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
            // lblFiliais
            // 
            this.lblFiliais.AutoSize = true;
            this.lblFiliais.BackColor = System.Drawing.Color.Transparent;
            this.lblFiliais.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiliais.Location = new System.Drawing.Point(1011, 39);
            this.lblFiliais.Name = "lblFiliais";
            this.lblFiliais.Size = new System.Drawing.Size(99, 36);
            this.lblFiliais.TabIndex = 89;
            this.lblFiliais.Text = "Filiais";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaCadastroFiliais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1028, 679);
            this.Controls.Add(this.lblFiliais);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroFiliais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Cadastro Filiais";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadastroFiliais_FormClosed);
            this.Load += new System.EventHandler(this.TelaCadastroFiliais_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaCadastroFiliais_Paint);
            this.tabControl1.ResumeLayout(false);
            this.tabFiliais.ResumeLayout(false);
            this.tabFiliais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiliais)).EndInit();
            this.tabNovoFilial.ResumeLayout(false);
            this.tabNovoFilial.PerformLayout();
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
        private System.Windows.Forms.TabPage tabFiliais;
        private System.Windows.Forms.TextBox txtPesquisaUsuario;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TabPage tabNovoFilial;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.DataGridView dgFiliais;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCompl;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCompl;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblFiliais;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFantasiaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CnpjCpfCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContatoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCol;
    }
}