
namespace FarmaTech.View.Principal
{
    partial class TelaRequisicoes
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtPesquisaUsuario = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilialCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssuntoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RespostaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRequisicoes = new System.Windows.Forms.TabPage();
            this.tabResposta = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.cbFilial = new System.Windows.Forms.ComboBox();
            this.lblFilial = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDataSistema = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabRequisicoes.SuspendLayout();
            this.tabResposta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::FarmaTech.Properties.Resources.BotaoHome;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(25, 71);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 95);
            this.btnVoltar.TabIndex = 89;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtPesquisaUsuario
            // 
            this.txtPesquisaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaUsuario.Location = new System.Drawing.Point(346, 30);
            this.txtPesquisaUsuario.Name = "txtPesquisaUsuario";
            this.txtPesquisaUsuario.Size = new System.Drawing.Size(300, 26);
            this.txtPesquisaUsuario.TabIndex = 95;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(247, 33);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(93, 20);
            this.lblPesquisar.TabIndex = 94;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataCol,
            this.UsuarioCol,
            this.FilialCol,
            this.AssuntoCol,
            this.DescricaoCol,
            this.RespostaCol});
            this.dataGridView1.Location = new System.Drawing.Point(63, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 332);
            this.dataGridView1.TabIndex = 93;
            // 
            // DataCol
            // 
            this.DataCol.HeaderText = "Data";
            this.DataCol.Name = "DataCol";
            this.DataCol.ReadOnly = true;
            // 
            // UsuarioCol
            // 
            this.UsuarioCol.HeaderText = "Usuario";
            this.UsuarioCol.Name = "UsuarioCol";
            this.UsuarioCol.ReadOnly = true;
            // 
            // FilialCol
            // 
            this.FilialCol.HeaderText = "Filial";
            this.FilialCol.Name = "FilialCol";
            this.FilialCol.ReadOnly = true;
            // 
            // AssuntoCol
            // 
            this.AssuntoCol.HeaderText = "Assunto";
            this.AssuntoCol.Name = "AssuntoCol";
            this.AssuntoCol.ReadOnly = true;
            // 
            // DescricaoCol
            // 
            this.DescricaoCol.HeaderText = "Descrição";
            this.DescricaoCol.Name = "DescricaoCol";
            this.DescricaoCol.ReadOnly = true;
            // 
            // RespostaCol
            // 
            this.RespostaCol.HeaderText = "Resposta";
            this.RespostaCol.Name = "RespostaCol";
            this.RespostaCol.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 71);
            this.button1.TabIndex = 96;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRequisicoes);
            this.tabControl1.Controls.Add(this.tabResposta);
            this.tabControl1.Location = new System.Drawing.Point(141, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 519);
            this.tabControl1.TabIndex = 97;
            // 
            // tabRequisicoes
            // 
            this.tabRequisicoes.BackColor = System.Drawing.Color.Lavender;
            this.tabRequisicoes.Controls.Add(this.dataGridView1);
            this.tabRequisicoes.Controls.Add(this.txtPesquisaUsuario);
            this.tabRequisicoes.Controls.Add(this.lblPesquisar);
            this.tabRequisicoes.Location = new System.Drawing.Point(4, 22);
            this.tabRequisicoes.Name = "tabRequisicoes";
            this.tabRequisicoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequisicoes.Size = new System.Drawing.Size(917, 493);
            this.tabRequisicoes.TabIndex = 0;
            this.tabRequisicoes.Text = "Requisições";
            // 
            // tabResposta
            // 
            this.tabResposta.BackColor = System.Drawing.Color.Lavender;
            this.tabResposta.Controls.Add(this.textBox1);
            this.tabResposta.Controls.Add(this.lblResposta);
            this.tabResposta.Controls.Add(this.cbFilial);
            this.tabResposta.Controls.Add(this.lblFilial);
            this.tabResposta.Controls.Add(this.txtDescricao);
            this.tabResposta.Controls.Add(this.lblDescricao);
            this.tabResposta.Controls.Add(this.txtAssunto);
            this.tabResposta.Controls.Add(this.lblAssunto);
            this.tabResposta.Controls.Add(this.cbUsuario);
            this.tabResposta.Controls.Add(this.lblUsuario);
            this.tabResposta.Controls.Add(this.lblDataSistema);
            this.tabResposta.Controls.Add(this.lblData);
            this.tabResposta.Location = new System.Drawing.Point(4, 22);
            this.tabResposta.Name = "tabResposta";
            this.tabResposta.Padding = new System.Windows.Forms.Padding(3);
            this.tabResposta.Size = new System.Drawing.Size(917, 493);
            this.tabResposta.TabIndex = 1;
            this.tabResposta.Text = "Resposta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 343);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(527, 79);
            this.textBox1.TabIndex = 31;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(115, 346);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(55, 13);
            this.lblResposta.TabIndex = 30;
            this.lblResposta.Text = "Resposta:";
            // 
            // cbFilial
            // 
            this.cbFilial.FormattingEnabled = true;
            this.cbFilial.Location = new System.Drawing.Point(230, 85);
            this.cbFilial.Name = "cbFilial";
            this.cbFilial.Size = new System.Drawing.Size(184, 21);
            this.cbFilial.TabIndex = 29;
            // 
            // lblFilial
            // 
            this.lblFilial.AutoSize = true;
            this.lblFilial.Location = new System.Drawing.Point(159, 88);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(30, 13);
            this.lblFilial.TabIndex = 28;
            this.lblFilial.Text = "Filial:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(230, 202);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(527, 79);
            this.txtDescricao.TabIndex = 27;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(116, 205);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 26;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(230, 149);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(527, 20);
            this.txtAssunto.TabIndex = 25;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(130, 152);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(48, 13);
            this.lblAssunto.TabIndex = 24;
            this.lblAssunto.Text = "Assunto:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(558, 28);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(184, 21);
            this.cbUsuario.TabIndex = 23;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(461, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblDataSistema
            // 
            this.lblDataSistema.AutoSize = true;
            this.lblDataSistema.Location = new System.Drawing.Point(226, 25);
            this.lblDataSistema.Name = "lblDataSistema";
            this.lblDataSistema.Size = new System.Drawing.Size(0, 13);
            this.lblDataSistema.TabIndex = 21;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(157, 25);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 20;
            this.lblData.Text = "Data:";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(36, 308);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 87);
            this.btnExportar.TabIndex = 98;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // TelaRequisicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 595);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaRequisicoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Requisições";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaRequisicoes_FormClosed);
            this.Load += new System.EventHandler(this.TelaRequisicoes_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaRequisicoes_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabRequisicoes.ResumeLayout(false);
            this.tabRequisicoes.PerformLayout();
            this.tabResposta.ResumeLayout(false);
            this.tabResposta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtPesquisaUsuario;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilialCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssuntoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRequisicoes;
        private System.Windows.Forms.TabPage tabResposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn RespostaCol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.ComboBox cbFilial;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDataSistema;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnExportar;
    }
}