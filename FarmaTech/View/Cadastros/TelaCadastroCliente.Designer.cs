
namespace FarmaTech.View
{
    partial class TelaCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroCliente));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.rbCnpj = new System.Windows.Forms.RadioButton();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.txtPesquisaUsuario = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.tabNovoCliente = new System.Windows.Forms.TabPage();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCompl = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblCompl = new System.Windows.Forms.Label();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblCadastroClientes = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.tabNovoCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClientes);
            this.tabControl1.Controls.Add(this.tabNovoCliente);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(113, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 513);
            this.tabControl1.TabIndex = 78;
            // 
            // tabClientes
            // 
            this.tabClientes.BackColor = System.Drawing.Color.Lavender;
            this.tabClientes.Controls.Add(this.rbCnpj);
            this.tabClientes.Controls.Add(this.rbCpf);
            this.tabClientes.Controls.Add(this.dgClientes);
            this.tabClientes.Controls.Add(this.txtPesquisaUsuario);
            this.tabClientes.Controls.Add(this.lblPesquisar);
            this.tabClientes.Location = new System.Drawing.Point(4, 29);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(934, 480);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.tabClientes_Paint);
            // 
            // rbCnpj
            // 
            this.rbCnpj.AutoSize = true;
            this.rbCnpj.BackColor = System.Drawing.Color.Transparent;
            this.rbCnpj.Checked = true;
            this.rbCnpj.Location = new System.Drawing.Point(682, 34);
            this.rbCnpj.Name = "rbCnpj";
            this.rbCnpj.Size = new System.Drawing.Size(71, 24);
            this.rbCnpj.TabIndex = 26;
            this.rbCnpj.TabStop = true;
            this.rbCnpj.Text = "CNPJ";
            this.rbCnpj.UseVisualStyleBackColor = false;
            this.rbCnpj.CheckedChanged += new System.EventHandler(this.rbCnpj_CheckedChanged);
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.BackColor = System.Drawing.Color.Transparent;
            this.rbCpf.Location = new System.Drawing.Point(591, 34);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(61, 24);
            this.rbCpf.TabIndex = 25;
            this.rbCpf.Text = "CPF";
            this.rbCpf.UseVisualStyleBackColor = false;
            this.rbCpf.CheckedChanged += new System.EventHandler(this.rbCpf_CheckedChanged);
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(49, 87);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.Size = new System.Drawing.Size(819, 291);
            this.dgClientes.TabIndex = 24;
            // 
            // txtPesquisaUsuario
            // 
            this.txtPesquisaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaUsuario.Location = new System.Drawing.Point(257, 31);
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
            this.lblPesquisar.Location = new System.Drawing.Point(158, 34);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(93, 20);
            this.lblPesquisar.TabIndex = 17;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // tabNovoCliente
            // 
            this.tabNovoCliente.BackColor = System.Drawing.Color.Lavender;
            this.tabNovoCliente.Controls.Add(this.cboEstados);
            this.tabNovoCliente.Controls.Add(this.txtContato);
            this.tabNovoCliente.Controls.Add(this.lblContato);
            this.tabNovoCliente.Controls.Add(this.txtCnpj);
            this.tabNovoCliente.Controls.Add(this.txtNomeFantasia);
            this.tabNovoCliente.Controls.Add(this.lblNomeFantasia);
            this.tabNovoCliente.Controls.Add(this.txtCidade);
            this.tabNovoCliente.Controls.Add(this.txtCompl);
            this.tabNovoCliente.Controls.Add(this.txtNumero);
            this.tabNovoCliente.Controls.Add(this.txtEndereco);
            this.tabNovoCliente.Controls.Add(this.lblCidade);
            this.tabNovoCliente.Controls.Add(this.lblEstado);
            this.tabNovoCliente.Controls.Add(this.lblNumero);
            this.tabNovoCliente.Controls.Add(this.txtRazaoSocial);
            this.tabNovoCliente.Controls.Add(this.lblRazaoSocial);
            this.tabNovoCliente.Controls.Add(this.lblCompl);
            this.tabNovoCliente.Controls.Add(this.rbJuridica);
            this.tabNovoCliente.Controls.Add(this.lblCnpj);
            this.tabNovoCliente.Controls.Add(this.lblEndereco);
            this.tabNovoCliente.Controls.Add(this.rbFisica);
            this.tabNovoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNovoCliente.Location = new System.Drawing.Point(4, 29);
            this.tabNovoCliente.Name = "tabNovoCliente";
            this.tabNovoCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovoCliente.Size = new System.Drawing.Size(934, 480);
            this.tabNovoCliente.TabIndex = 1;
            this.tabNovoCliente.Text = "Novo Cliente";
            this.tabNovoCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.tabNovoCliente_Paint);
            // 
            // cboEstados
            // 
            this.cboEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(548, 294);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(121, 28);
            this.cboEstados.TabIndex = 115;
            // 
            // txtContato
            // 
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.Location = new System.Drawing.Point(631, 346);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(233, 29);
            this.txtContato.TabIndex = 114;
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.BackColor = System.Drawing.Color.Transparent;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(524, 352);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(78, 20);
            this.lblContato.TabIndex = 113;
            this.lblContato.Text = "Contato:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(162, 346);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(311, 29);
            this.txtCnpj.TabIndex = 112;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(162, 121);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(702, 29);
            this.txtNomeFantasia.TabIndex = 111;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.Location = new System.Drawing.Point(15, 127);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(135, 20);
            this.lblNomeFantasia.TabIndex = 110;
            this.lblNomeFantasia.Text = "Nome Fantasia:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(162, 291);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(284, 29);
            this.txtCidade.TabIndex = 109;
            // 
            // txtCompl
            // 
            this.txtCompl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompl.Location = new System.Drawing.Point(162, 233);
            this.txtCompl.Name = "txtCompl";
            this.txtCompl.Size = new System.Drawing.Size(440, 29);
            this.txtCompl.TabIndex = 108;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(722, 233);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(142, 29);
            this.txtNumero.TabIndex = 107;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(162, 178);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(702, 29);
            this.txtEndereco.TabIndex = 105;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(75, 297);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(70, 20);
            this.lblCidade.TabIndex = 104;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(471, 297);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(71, 20);
            this.lblEstado.TabIndex = 103;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(627, 239);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(81, 20);
            this.lblNumero.TabIndex = 102;
            this.lblNumero.Text = "Número: ";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(162, 68);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(702, 29);
            this.txtRazaoSocial.TabIndex = 101;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(24, 74);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(120, 20);
            this.lblRazaoSocial.TabIndex = 100;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // lblCompl
            // 
            this.lblCompl.AutoSize = true;
            this.lblCompl.BackColor = System.Drawing.Color.Transparent;
            this.lblCompl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompl.Location = new System.Drawing.Point(75, 239);
            this.lblCompl.Name = "lblCompl";
            this.lblCompl.Size = new System.Drawing.Size(69, 20);
            this.lblCompl.TabIndex = 99;
            this.lblCompl.Text = "Compl.:";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.BackColor = System.Drawing.Color.Transparent;
            this.rbJuridica.Checked = true;
            this.rbJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJuridica.Location = new System.Drawing.Point(444, 22);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(89, 24);
            this.rbJuridica.TabIndex = 97;
            this.rbJuridica.TabStop = true;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = false;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.BackColor = System.Drawing.Color.Transparent;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(94, 352);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(50, 20);
            this.lblCnpj.TabIndex = 95;
            this.lblCnpj.Text = "Cnpj:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(53, 178);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(91, 20);
            this.lblEndereco.TabIndex = 98;
            this.lblEndereco.Text = "Endereço:";
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.BackColor = System.Drawing.Color.Transparent;
            this.rbFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFisica.Location = new System.Drawing.Point(346, 22);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(74, 24);
            this.rbFisica.TabIndex = 96;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = false;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(16, 382);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(95, 75);
            this.btnAlterar.TabIndex = 81;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.BackgroundImage = global::FarmaTech.Properties.Resources.BotaoNovo;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(16, 195);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 95);
            this.btnNovo.TabIndex = 85;
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
            this.btnExcluir.Location = new System.Drawing.Point(16, 463);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 95);
            this.btnExcluir.TabIndex = 84;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::FarmaTech.Properties.Resources.BotaoSalvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(16, 296);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 95);
            this.btnSalvar.TabIndex = 83;
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
            this.btnVoltar.Location = new System.Drawing.Point(16, 96);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 95);
            this.btnVoltar.TabIndex = 82;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 607);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 30);
            this.panel1.TabIndex = 87;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblHora.Location = new System.Drawing.Point(993, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 13);
            this.lblHora.TabIndex = 87;
            this.lblHora.Text = "Hora";
            // 
            // lblCadastroClientes
            // 
            this.lblCadastroClientes.AutoSize = true;
            this.lblCadastroClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroClientes.Location = new System.Drawing.Point(740, 9);
            this.lblCadastroClientes.Name = "lblCadastroClientes";
            this.lblCadastroClientes.Size = new System.Drawing.Size(311, 36);
            this.lblCadastroClientes.TabIndex = 88;
            this.lblCadastroClientes.Text = "Cadastro de Clientes";
            // 
            // TelaCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 637);
            this.Controls.Add(this.lblCadastroClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Cadastro Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadastroCliente_FormClosed);
            this.Load += new System.EventHandler(this.TelaCadastroCliente_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaCadastroCliente_Paint);
            this.tabControl1.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.tabNovoCliente.ResumeLayout(false);
            this.tabNovoCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TextBox txtPesquisaUsuario;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TabPage tabNovoCliente;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCompl;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblCompl;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.RadioButton rbCnpj;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblCadastroClientes;
    }
}