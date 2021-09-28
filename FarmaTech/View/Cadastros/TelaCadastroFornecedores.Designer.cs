
namespace FarmaTech.View
{
    partial class TelaCadastroFornecedores
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFornecedores = new System.Windows.Forms.TabPage();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.txtPesquisaUsuario = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.tabNovoFornecedor = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            this.tabFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.tabNovoFornecedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(43, 132);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 75);
            this.btnNovo.TabIndex = 77;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(43, 403);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 75);
            this.btnExcluir.TabIndex = 76;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(43, 312);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 75);
            this.btnAlterar.TabIndex = 75;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(43, 222);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 75);
            this.btnSalvar.TabIndex = 74;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(43, 41);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 75);
            this.btnVoltar.TabIndex = 73;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFornecedores);
            this.tabControl1.Controls.Add(this.tabNovoFornecedor);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(148, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 437);
            this.tabControl1.TabIndex = 72;
            // 
            // tabFornecedores
            // 
            this.tabFornecedores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabFornecedores.Controls.Add(this.dgUsuarios);
            this.tabFornecedores.Controls.Add(this.txtPesquisaUsuario);
            this.tabFornecedores.Controls.Add(this.lblPesquisar);
            this.tabFornecedores.Location = new System.Drawing.Point(4, 29);
            this.tabFornecedores.Name = "tabFornecedores";
            this.tabFornecedores.Padding = new System.Windows.Forms.Padding(3);
            this.tabFornecedores.Size = new System.Drawing.Size(916, 404);
            this.tabFornecedores.TabIndex = 0;
            this.tabFornecedores.Text = "Fornecedores";
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(31, 91);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.Size = new System.Drawing.Size(810, 282);
            this.dgUsuarios.TabIndex = 20;
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
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(250, 35);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(93, 20);
            this.lblPesquisar.TabIndex = 17;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // tabNovoFornecedor
            // 
            this.tabNovoFornecedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabNovoFornecedor.Controls.Add(this.cboEstados);
            this.tabNovoFornecedor.Controls.Add(this.lblContato);
            this.tabNovoFornecedor.Controls.Add(this.txtContato);
            this.tabNovoFornecedor.Controls.Add(this.txtNomeFantasia);
            this.tabNovoFornecedor.Controls.Add(this.lblNomeFantasia);
            this.tabNovoFornecedor.Controls.Add(this.lblRazaoSocial);
            this.tabNovoFornecedor.Controls.Add(this.lblCnpj);
            this.tabNovoFornecedor.Controls.Add(this.txtCnpj);
            this.tabNovoFornecedor.Controls.Add(this.txtCidade);
            this.tabNovoFornecedor.Controls.Add(this.txtCompl);
            this.tabNovoFornecedor.Controls.Add(this.txtNumero);
            this.tabNovoFornecedor.Controls.Add(this.txtEndereco);
            this.tabNovoFornecedor.Controls.Add(this.lblCidade);
            this.tabNovoFornecedor.Controls.Add(this.lblEstado);
            this.tabNovoFornecedor.Controls.Add(this.lblNumero);
            this.tabNovoFornecedor.Controls.Add(this.lblCompl);
            this.tabNovoFornecedor.Controls.Add(this.lblEndereco);
            this.tabNovoFornecedor.Controls.Add(this.txtRazaoSocial);
            this.tabNovoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNovoFornecedor.Location = new System.Drawing.Point(4, 29);
            this.tabNovoFornecedor.Name = "tabNovoFornecedor";
            this.tabNovoFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovoFornecedor.Size = new System.Drawing.Size(916, 404);
            this.tabNovoFornecedor.TabIndex = 1;
            this.tabNovoFornecedor.Text = "Novo Fornecedor";
            // 
            // cboEstados
            // 
            this.cboEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(703, 257);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(121, 28);
            this.cboEstados.TabIndex = 101;
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(509, 320);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(78, 20);
            this.lblContato.TabIndex = 99;
            this.lblContato.Text = "Contato:";
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(593, 317);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(253, 26);
            this.txtContato.TabIndex = 100;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(201, 97);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(645, 29);
            this.txtNomeFantasia.TabIndex = 96;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.Location = new System.Drawing.Point(44, 103);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(135, 20);
            this.lblNomeFantasia.TabIndex = 95;
            this.lblNomeFantasia.Text = "Nome Fantasia:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(59, 46);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(120, 20);
            this.lblRazaoSocial.TabIndex = 86;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(120, 320);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(50, 20);
            this.lblCnpj.TabIndex = 98;
            this.lblCnpj.Text = "Cnpj:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(201, 314);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(284, 29);
            this.txtCnpj.TabIndex = 97;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(201, 259);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(401, 29);
            this.txtCidade.TabIndex = 94;
            // 
            // txtCompl
            // 
            this.txtCompl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompl.Location = new System.Drawing.Point(201, 204);
            this.txtCompl.Name = "txtCompl";
            this.txtCompl.Size = new System.Drawing.Size(401, 29);
            this.txtCompl.TabIndex = 93;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(713, 204);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(133, 29);
            this.txtNumero.TabIndex = 92;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(201, 152);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(645, 29);
            this.txtEndereco.TabIndex = 90;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(109, 265);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(70, 20);
            this.lblCidade.TabIndex = 89;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(626, 265);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(71, 20);
            this.lblEstado.TabIndex = 88;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(626, 210);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(81, 20);
            this.lblNumero.TabIndex = 87;
            this.lblNumero.Text = "Número: ";
            // 
            // lblCompl
            // 
            this.lblCompl.AutoSize = true;
            this.lblCompl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCompl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompl.Location = new System.Drawing.Point(110, 210);
            this.lblCompl.Name = "lblCompl";
            this.lblCompl.Size = new System.Drawing.Size(69, 20);
            this.lblCompl.TabIndex = 85;
            this.lblCompl.Text = "Compl.:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(88, 158);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(91, 20);
            this.lblEndereco.TabIndex = 84;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(201, 40);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(645, 26);
            this.txtRazaoSocial.TabIndex = 83;
            // 
            // TelaCadastroFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1111, 515);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Cadastro Fornecedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadastroFornecedores_FormClosed);
            this.Load += new System.EventHandler(this.TelaCadastroFornecedores_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaCadastroFornecedores_Paint);
            this.tabControl1.ResumeLayout(false);
            this.tabFornecedores.ResumeLayout(false);
            this.tabFornecedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.tabNovoFornecedor.ResumeLayout(false);
            this.tabNovoFornecedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFornecedores;
        private System.Windows.Forms.TextBox txtPesquisaUsuario;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TabPage tabNovoFornecedor;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtContato;
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
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.ComboBox cboEstados;
    }
}