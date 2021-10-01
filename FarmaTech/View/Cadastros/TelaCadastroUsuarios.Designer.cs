
namespace FarmaTech.View
{
    partial class TelaCadastroUsuarios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.txtPesquisaUsuario = new System.Windows.Forms.TextBox();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.tabNovoUsuario = new System.Windows.Forms.TabPage();
            this.lblFilial = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbUsuarioFilial = new System.Windows.Forms.ComboBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.nUDNivelAcesso = new System.Windows.Forms.NumericUpDown();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.cbUsuarioCargo = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.tabNovoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNivelAcesso)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUsuarios);
            this.tabControl1.Controls.Add(this.tabNovoUsuario);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(178, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 542);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.BackColor = System.Drawing.Color.Lavender;
            this.tabUsuarios.Controls.Add(this.txtPesquisaUsuario);
            this.tabUsuarios.Controls.Add(this.dgUsuarios);
            this.tabUsuarios.Controls.Add(this.lblPesquisar);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 29);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(1034, 509);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text = "Usuários";
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
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(40, 103);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.Size = new System.Drawing.Size(950, 388);
            this.dgUsuarios.TabIndex = 14;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(316, 45);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(93, 20);
            this.lblPesquisar.TabIndex = 13;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // tabNovoUsuario
            // 
            this.tabNovoUsuario.BackColor = System.Drawing.Color.Lavender;
            this.tabNovoUsuario.Controls.Add(this.lblFilial);
            this.tabNovoUsuario.Controls.Add(this.lblNome);
            this.tabNovoUsuario.Controls.Add(this.txtNome);
            this.tabNovoUsuario.Controls.Add(this.cbUsuarioFilial);
            this.tabNovoUsuario.Controls.Add(this.lblContato);
            this.tabNovoUsuario.Controls.Add(this.lblCargo);
            this.tabNovoUsuario.Controls.Add(this.nUDNivelAcesso);
            this.tabNovoUsuario.Controls.Add(this.txtContato);
            this.tabNovoUsuario.Controls.Add(this.cbUsuarioCargo);
            this.tabNovoUsuario.Controls.Add(this.lblNivel);
            this.tabNovoUsuario.Controls.Add(this.txtLogin);
            this.tabNovoUsuario.Controls.Add(this.lblLogin);
            this.tabNovoUsuario.Controls.Add(this.txtSenha);
            this.tabNovoUsuario.Controls.Add(this.lblSenha);
            this.tabNovoUsuario.Location = new System.Drawing.Point(4, 29);
            this.tabNovoUsuario.Name = "tabNovoUsuario";
            this.tabNovoUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovoUsuario.Size = new System.Drawing.Size(1034, 509);
            this.tabNovoUsuario.TabIndex = 1;
            this.tabNovoUsuario.Text = "Novo Usuário";
            // 
            // lblFilial
            // 
            this.lblFilial.AutoSize = true;
            this.lblFilial.BackColor = System.Drawing.Color.Transparent;
            this.lblFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilial.Location = new System.Drawing.Point(498, 122);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(51, 20);
            this.lblFilial.TabIndex = 50;
            this.lblFilial.Text = "Filial:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(138, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 46;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(222, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(645, 26);
            this.txtNome.TabIndex = 47;
            // 
            // cbUsuarioFilial
            // 
            this.cbUsuarioFilial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarioFilial.FormattingEnabled = true;
            this.cbUsuarioFilial.Location = new System.Drawing.Point(568, 114);
            this.cbUsuarioFilial.Name = "cbUsuarioFilial";
            this.cbUsuarioFilial.Size = new System.Drawing.Size(299, 28);
            this.cbUsuarioFilial.TabIndex = 51;
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.BackColor = System.Drawing.Color.Transparent;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(138, 189);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(78, 20);
            this.lblContato.TabIndex = 44;
            this.lblContato.Text = "Contato:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(138, 122);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(62, 20);
            this.lblCargo.TabIndex = 45;
            this.lblCargo.Text = "Cargo:";
            // 
            // nUDNivelAcesso
            // 
            this.nUDNivelAcesso.Location = new System.Drawing.Point(723, 186);
            this.nUDNivelAcesso.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUDNivelAcesso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDNivelAcesso.Name = "nUDNivelAcesso";
            this.nUDNivelAcesso.Size = new System.Drawing.Size(144, 26);
            this.nUDNivelAcesso.TabIndex = 53;
            this.nUDNivelAcesso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(222, 186);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(294, 26);
            this.txtContato.TabIndex = 52;
            // 
            // cbUsuarioCargo
            // 
            this.cbUsuarioCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarioCargo.FormattingEnabled = true;
            this.cbUsuarioCargo.Items.AddRange(new object[] {
            "Gerente",
            "Funcionario",
            "Admin"});
            this.cbUsuarioCargo.Location = new System.Drawing.Point(222, 119);
            this.cbUsuarioCargo.Name = "cbUsuarioCargo";
            this.cbUsuarioCargo.Size = new System.Drawing.Size(205, 28);
            this.cbUsuarioCargo.TabIndex = 48;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(586, 189);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(121, 20);
            this.lblNivel.TabIndex = 49;
            this.lblNivel.Text = "Nível Acesso: ";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(222, 250);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(294, 26);
            this.txtLogin.TabIndex = 55;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(138, 250);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(58, 20);
            this.lblLogin.TabIndex = 54;
            this.lblLogin.Text = "Login:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(627, 250);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(240, 26);
            this.txtSenha.TabIndex = 57;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(555, 253);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(66, 20);
            this.lblSenha.TabIndex = 56;
            this.lblSenha.Text = "Senha:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(47, 239);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 75);
            this.btnAlterar.TabIndex = 58;
            this.btnAlterar.Text = "Alterar";
            this.toolTip1.SetToolTip(this.btnAlterar, "Alterar");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.BackgroundImage = global::FarmaTech.Properties.Resources.BotaoNovo;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(36, 138);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 95);
            this.btnNovo.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = global::FarmaTech.Properties.Resources.BotaoExcluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(36, 320);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 95);
            this.btnExcluir.TabIndex = 59;
            this.toolTip1.SetToolTip(this.btnExcluir, "Excluir");
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
            this.btnSalvar.Location = new System.Drawing.Point(36, 406);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 95);
            this.btnSalvar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::FarmaTech.Properties.Resources.BotaoHome;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(36, 58);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 95);
            this.btnVoltar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnVoltar, "Voltar");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // TelaCadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 597);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Cadastro Usuários";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadastroUsuarios_FormClosed);
            this.Load += new System.EventHandler(this.TelaCadastroUsuarios_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaCadastroUsuarios_Paint);
            this.tabControl1.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            this.tabUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.tabNovoUsuario.ResumeLayout(false);
            this.tabNovoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNivelAcesso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.TabPage tabNovoUsuario;
        private System.Windows.Forms.TextBox txtPesquisaUsuario;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbUsuarioFilial;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.NumericUpDown nUDNivelAcesso;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.ComboBox cbUsuarioCargo;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}