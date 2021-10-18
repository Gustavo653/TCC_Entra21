
namespace FarmaTech.View.Principal
{
    partial class TelaAberturaDeCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAberturaDeCaixa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumCaixa = new System.Windows.Forms.Label();
            this.lblDataSistema = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtValorAberturaCaixa = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblAbertura = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.lblNumCaixa);
            this.panel1.Controls.Add(this.lblDataSistema);
            this.panel1.Controls.Add(this.btnConfirma);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.txtValorAberturaCaixa);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.cbUsuario);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblCaixa);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.lblAbertura);
            this.panel1.Location = new System.Drawing.Point(46, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 366);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblNumCaixa
            // 
            this.lblNumCaixa.AutoSize = true;
            this.lblNumCaixa.BackColor = System.Drawing.Color.Transparent;
            this.lblNumCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCaixa.Location = new System.Drawing.Point(452, 121);
            this.lblNumCaixa.Name = "lblNumCaixa";
            this.lblNumCaixa.Size = new System.Drawing.Size(51, 20);
            this.lblNumCaixa.TabIndex = 12;
            this.lblNumCaixa.Text = "label1";
            // 
            // lblDataSistema
            // 
            this.lblDataSistema.AutoSize = true;
            this.lblDataSistema.BackColor = System.Drawing.Color.Transparent;
            this.lblDataSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSistema.Location = new System.Drawing.Point(144, 121);
            this.lblDataSistema.Name = "lblDataSistema";
            this.lblDataSistema.Size = new System.Drawing.Size(51, 20);
            this.lblDataSistema.TabIndex = 11;
            this.lblDataSistema.Text = "label1";
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirma.BackgroundImage")));
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirma.FlatAppearance.BorderSize = 0;
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirma.Location = new System.Drawing.Point(379, 261);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(98, 87);
            this.btnConfirma.TabIndex = 10;
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(211, 261);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(98, 87);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtValorAberturaCaixa
            // 
            this.txtValorAberturaCaixa.Location = new System.Drawing.Point(456, 193);
            this.txtValorAberturaCaixa.Name = "txtValorAberturaCaixa";
            this.txtValorAberturaCaixa.Size = new System.Drawing.Size(132, 20);
            this.txtValorAberturaCaixa.TabIndex = 8;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(375, 193);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(56, 20);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(166, 195);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(132, 21);
            this.cbUsuario.TabIndex = 6;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(62, 196);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(76, 20);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.BackColor = System.Drawing.Color.Transparent;
            this.lblCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.Location = new System.Drawing.Point(375, 121);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(58, 20);
            this.lblCaixa.TabIndex = 3;
            this.lblCaixa.Text = "Caixa:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(85, 121);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 20);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data:";
            // 
            // lblAbertura
            // 
            this.lblAbertura.AutoSize = true;
            this.lblAbertura.BackColor = System.Drawing.Color.Transparent;
            this.lblAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbertura.Location = new System.Drawing.Point(231, 45);
            this.lblAbertura.Name = "lblAbertura";
            this.lblAbertura.Size = new System.Drawing.Size(248, 31);
            this.lblAbertura.TabIndex = 0;
            this.lblAbertura.Text = "Abertura de Caixa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 448);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 30);
            this.panel2.TabIndex = 101;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblHora.Location = new System.Drawing.Point(695, 9);
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
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaAberturaDeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 478);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaAberturaDeCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Abertura de Caixa";
            this.Load += new System.EventHandler(this.TelaAberturaDeCaixa_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaAberturaDeCaixa_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtValorAberturaCaixa;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblAbertura;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblDataSistema;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblNumCaixa;
    }
}