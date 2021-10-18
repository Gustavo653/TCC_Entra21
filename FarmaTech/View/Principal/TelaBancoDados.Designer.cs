
namespace FarmaTech.View.Principal
{
    partial class TelaBancoDados
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSincronizar = new System.Windows.Forms.Button();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.rbRemoto = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sincronizar o Banco de Dados \"local\" com o \"remoto\":";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(178, 91);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // btnSincronizar
            // 
            this.btnSincronizar.BackColor = System.Drawing.Color.Transparent;
            this.btnSincronizar.BackgroundImage = global::FarmaTech.Properties.Resources.MicrosoftTeams_image__19_;
            this.btnSincronizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSincronizar.FlatAppearance.BorderSize = 0;
            this.btnSincronizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSincronizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSincronizar.Location = new System.Drawing.Point(219, 120);
            this.btnSincronizar.Name = "btnSincronizar";
            this.btnSincronizar.Size = new System.Drawing.Size(232, 134);
            this.btnSincronizar.TabIndex = 1;
            this.btnSincronizar.UseVisualStyleBackColor = false;
            this.btnSincronizar.Click += new System.EventHandler(this.btnSincronizar_Click);
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.BackColor = System.Drawing.Color.Transparent;
            this.rbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLocal.Location = new System.Drawing.Point(206, 379);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(78, 28);
            this.rbLocal.TabIndex = 4;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = false;
            this.rbLocal.CheckedChanged += new System.EventHandler(this.rbLocal_CheckedChanged);
            // 
            // rbRemoto
            // 
            this.rbRemoto.AutoSize = true;
            this.rbRemoto.BackColor = System.Drawing.Color.Transparent;
            this.rbRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRemoto.Location = new System.Drawing.Point(351, 379);
            this.rbRemoto.Name = "rbRemoto";
            this.rbRemoto.Size = new System.Drawing.Size(100, 28);
            this.rbRemoto.TabIndex = 5;
            this.rbRemoto.Text = "Remoto";
            this.rbRemoto.UseVisualStyleBackColor = false;
            this.rbRemoto.CheckedChanged += new System.EventHandler(this.rbRemoto_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Escolha o Banco de Dados:";
            // 
            // TelaBancoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbRemoto);
            this.Controls.Add(this.rbLocal);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSincronizar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaBancoDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaBancoDados";
            this.Load += new System.EventHandler(this.TelaBancoDados_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TelaBancoDados_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSincronizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.RadioButton rbRemoto;
        private System.Windows.Forms.Label label2;
    }
}