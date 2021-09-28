
namespace FarmaTech
{
    partial class TelaPrincipal
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
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFiliais = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUnidades = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFormaPag = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConvenios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuContasPagar = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPdv = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.MenuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.financeiroToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.MenuSair});
            this.MenuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuPrincipal.Size = new System.Drawing.Size(1370, 33);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "MenuCadastros";
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuarios,
            this.MenuFiliais,
            this.configuraçõesToolStripMenuItem,
            this.MenuFornecedores,
            this.MenuClientes,
            this.MenuConvenios,
            this.MenuProdutos});
            this.MenuCadastros.Name = "MenuCadastros";
            this.MenuCadastros.Size = new System.Drawing.Size(111, 29);
            this.MenuCadastros.Text = "Cadastros";
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(192, 26);
            this.MenuUsuarios.Text = "Usuarios";
            this.MenuUsuarios.Click += new System.EventHandler(this.MenuUsuarios_Click);
            // 
            // MenuFiliais
            // 
            this.MenuFiliais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuFiliais.Name = "MenuFiliais";
            this.MenuFiliais.Size = new System.Drawing.Size(192, 26);
            this.MenuFiliais.Text = "Filiais";
            this.MenuFiliais.Click += new System.EventHandler(this.MenuFiliais_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUnidades,
            this.MenuFormaPag});
            this.configuraçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // MenuUnidades
            // 
            this.MenuUnidades.Name = "MenuUnidades";
            this.MenuUnidades.Size = new System.Drawing.Size(250, 26);
            this.MenuUnidades.Text = "Unidades";
            this.MenuUnidades.Click += new System.EventHandler(this.MenuUnidades_Click);
            // 
            // MenuFormaPag
            // 
            this.MenuFormaPag.Name = "MenuFormaPag";
            this.MenuFormaPag.Size = new System.Drawing.Size(250, 26);
            this.MenuFormaPag.Text = "Formas de Pagamento";
            this.MenuFormaPag.Click += new System.EventHandler(this.MenuFormaPag_Click);
            // 
            // MenuFornecedores
            // 
            this.MenuFornecedores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuFornecedores.Name = "MenuFornecedores";
            this.MenuFornecedores.Size = new System.Drawing.Size(192, 26);
            this.MenuFornecedores.Text = "Fornecedores";
            this.MenuFornecedores.Click += new System.EventHandler(this.MenuFornecedores_Click);
            // 
            // MenuClientes
            // 
            this.MenuClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(192, 26);
            this.MenuClientes.Text = "Clientes";
            this.MenuClientes.Click += new System.EventHandler(this.MenuClientes_Click);
            // 
            // MenuConvenios
            // 
            this.MenuConvenios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuConvenios.Name = "MenuConvenios";
            this.MenuConvenios.Size = new System.Drawing.Size(192, 26);
            this.MenuConvenios.Text = "Convênios";
            this.MenuConvenios.Click += new System.EventHandler(this.MenuConvenios_Click);
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(192, 26);
            this.MenuProdutos.Text = "Produtos";
            this.MenuProdutos.Click += new System.EventHandler(this.MenuProdutos_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuContasPagar});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // MenuContasPagar
            // 
            this.MenuContasPagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuContasPagar.Name = "MenuContasPagar";
            this.MenuContasPagar.Size = new System.Drawing.Size(195, 26);
            this.MenuContasPagar.Text = "Contas a Pagar";
            this.MenuContasPagar.Click += new System.EventHandler(this.MenuContasPagar_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPdv});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // MenuPdv
            // 
            this.MenuPdv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuPdv.Name = "MenuPdv";
            this.MenuPdv.Size = new System.Drawing.Size(180, 26);
            this.MenuPdv.Text = "PDV";
            this.MenuPdv.Click += new System.EventHandler(this.MenuPdv_Click_1);
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(58, 29);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(511, 84);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(161, 24);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = "Seja Bem-Vindo";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(687, 84);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(0, 24);
            this.lblNomeUsuario.TabIndex = 2;
            this.lblNomeUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::FarmaTech.Properties.Resources.lab__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.MenuPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MenuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:FarmaTech:.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripMenuItem MenuFiliais;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuUnidades;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuPdv;
        private System.Windows.Forms.ToolStripMenuItem MenuFormaPag;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuConvenios;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuContasPagar;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblNomeUsuario;
    }
}