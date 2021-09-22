
namespace FarmaTech.View
{
    partial class TelaDeProdutos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdEstoqueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCol,
            this.UnidadeCol,
            this.QtdEstoqueCol,
            this.CodigoCol,
            this.LabCol,
            this.CustoCol,
            this.ValorUniCol,
            this.GrupoCol});
            this.dataGridView1.Location = new System.Drawing.Point(25, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // NomeCol
            // 
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.Name = "NomeCol";
            // 
            // UnidadeCol
            // 
            this.UnidadeCol.HeaderText = "Unidade";
            this.UnidadeCol.Name = "UnidadeCol";
            // 
            // QtdEstoqueCol
            // 
            this.QtdEstoqueCol.HeaderText = "Em estoque:";
            this.QtdEstoqueCol.Name = "QtdEstoqueCol";
            // 
            // CodigoCol
            // 
            this.CodigoCol.HeaderText = "Código";
            this.CodigoCol.Name = "CodigoCol";
            // 
            // LabCol
            // 
            this.LabCol.HeaderText = "Laboratório";
            this.LabCol.Name = "LabCol";
            // 
            // CustoCol
            // 
            this.CustoCol.HeaderText = "Preço custo";
            this.CustoCol.Name = "CustoCol";
            // 
            // ValorUniCol
            // 
            this.ValorUniCol.HeaderText = "Valor unitário";
            this.ValorUniCol.Name = "ValorUniCol";
            // 
            // GrupoCol
            // 
            this.GrupoCol.HeaderText = "Grupo";
            this.GrupoCol.Name = "GrupoCol";
            // 
            // TelaDeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(897, 386);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TelaDeProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaDeProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdEstoqueCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupoCol;
    }
}