
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFiliais = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUnidades = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConvenios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.requisiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRequisicao = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNovaRequisicao = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacaoFinanceira = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuContasPagar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuContasReceber = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGraficos = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPdv = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFechamentoCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNivel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.MenuPrincipal.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.MenuPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.MenuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.requisiçõesToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.MenuRelatorios,
            this.vendasToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.MenuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.MenuPrincipal.Location = new System.Drawing.Point(26, 0);
            this.MenuPrincipal.Margin = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuPrincipal.Size = new System.Drawing.Size(130, 208);
            this.MenuPrincipal.Stretch = false;
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
            this.MenuCadastros.Size = new System.Drawing.Size(126, 29);
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
            this.MenuUnidades});
            this.configuraçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // MenuUnidades
            // 
            this.MenuUnidades.Name = "MenuUnidades";
            this.MenuUnidades.Size = new System.Drawing.Size(152, 26);
            this.MenuUnidades.Text = "Unidades";
            this.MenuUnidades.Click += new System.EventHandler(this.MenuUnidades_Click);
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
            // requisiçõesToolStripMenuItem
            // 
            this.requisiçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRequisicao,
            this.MenuNovaRequisicao});
            this.requisiçõesToolStripMenuItem.Name = "requisiçõesToolStripMenuItem";
            this.requisiçõesToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.requisiçõesToolStripMenuItem.Text = "Requisições";
            // 
            // MenuRequisicao
            // 
            this.MenuRequisicao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuRequisicao.Name = "MenuRequisicao";
            this.MenuRequisicao.Size = new System.Drawing.Size(210, 26);
            this.MenuRequisicao.Text = "Consulta";
            this.MenuRequisicao.Click += new System.EventHandler(this.MenuRequisicao_Click);
            // 
            // MenuNovaRequisicao
            // 
            this.MenuNovaRequisicao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuNovaRequisicao.Name = "MenuNovaRequisicao";
            this.MenuNovaRequisicao.Size = new System.Drawing.Size(210, 26);
            this.MenuNovaRequisicao.Text = "Nova Requisição";
            this.MenuNovaRequisicao.Click += new System.EventHandler(this.MenuNovaRequisicao_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMovimentacaoFinanceira,
            this.MenuContasPagar,
            this.MenuContasReceber});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // MenuMovimentacaoFinanceira
            // 
            this.MenuMovimentacaoFinanceira.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuMovimentacaoFinanceira.Name = "MenuMovimentacaoFinanceira";
            this.MenuMovimentacaoFinanceira.Size = new System.Drawing.Size(280, 26);
            this.MenuMovimentacaoFinanceira.Text = "Movimentação Financeira";
            this.MenuMovimentacaoFinanceira.Click += new System.EventHandler(this.MenuMovimentacaoFinanceira_Click);
            // 
            // MenuContasPagar
            // 
            this.MenuContasPagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuContasPagar.Name = "MenuContasPagar";
            this.MenuContasPagar.Size = new System.Drawing.Size(280, 26);
            this.MenuContasPagar.Text = "Contas a Pagar";
            this.MenuContasPagar.Click += new System.EventHandler(this.MenuContasPagar_Click);
            // 
            // MenuContasReceber
            // 
            this.MenuContasReceber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuContasReceber.Name = "MenuContasReceber";
            this.MenuContasReceber.Size = new System.Drawing.Size(280, 26);
            this.MenuContasReceber.Text = "Contas a Receber";
            this.MenuContasReceber.Click += new System.EventHandler(this.MenuContasReceber_Click);
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuGraficos});
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(126, 29);
            this.MenuRelatorios.Text = "Relatórios";
            // 
            // MenuGraficos
            // 
            this.MenuGraficos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuGraficos.Name = "MenuGraficos";
            this.MenuGraficos.Size = new System.Drawing.Size(144, 26);
            this.MenuGraficos.Text = "Gráficos";
            this.MenuGraficos.Click += new System.EventHandler(this.MenuGraficos_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPdv,
            this.MenuFechamentoCaixa});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // MenuPdv
            // 
            this.MenuPdv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuPdv.Name = "MenuPdv";
            this.MenuPdv.Size = new System.Drawing.Size(245, 26);
            this.MenuPdv.Text = "PDV";
            this.MenuPdv.Click += new System.EventHandler(this.MenuPdv_Click_1);
            // 
            // MenuFechamentoCaixa
            // 
            this.MenuFechamentoCaixa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuFechamentoCaixa.Name = "MenuFechamentoCaixa";
            this.MenuFechamentoCaixa.Size = new System.Drawing.Size(245, 26);
            this.MenuFechamentoCaixa.Text = "Fechamento de Caixa";
            this.MenuFechamentoCaixa.Click += new System.EventHandler(this.MenuFechamentoCaixa_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(9, 9);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(167, 24);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = " Seja Bem-Vindo";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(61, 50);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(0, 24);
            this.lblNomeUsuario.TabIndex = 2;
            this.lblNomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(186)))), ((int)(((byte)(240)))));
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(197, 749);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel2.BackgroundImage")));
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(190, 125);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNivel);
            this.panel1.Controls.Add(this.lblNomeUsuario);
            this.panel1.Controls.Add(this.lblBemVindo);
            this.panel1.Location = new System.Drawing.Point(3, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 141);
            this.panel1.TabIndex = 5;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(9, 92);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(165, 24);
            this.lblNivel.TabIndex = 6;
            this.lblNivel.Text = "Nivel de acesso.";
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Location = new System.Drawing.Point(3, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 297);
            this.panel2.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.MenuPrincipal);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(185, 269);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.button1);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 584);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(188, 165);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(50, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(50, 100, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHora.Location = new System.Drawing.Point(1089, 19);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(115, 31);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "HORA!!";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblData.Location = new System.Drawing.Point(1013, 72);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(48, 20);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::FarmaTech.Properties.Resources.lab__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1044, 749);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:FarmaTech:.";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaPrincipal_Paint);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MenuFiliais;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuUnidades;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuPdv;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuConvenios;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuContasPagar;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.ToolStripMenuItem requisiçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuRequisicao;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacaoFinanceira;
        private System.Windows.Forms.ToolStripMenuItem MenuContasReceber;
        private System.Windows.Forms.ToolStripMenuItem MenuNovaRequisicao;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem MenuGraficos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ToolStripMenuItem MenuFechamentoCaixa;
    }
}