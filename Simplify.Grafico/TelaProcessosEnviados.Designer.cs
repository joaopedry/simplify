namespace Simplify.Grafico
{
    partial class TelaProcessosEnviados
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
            this.dgProcessosEnviados = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcessosEnviados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProcessosEnviados
            // 
            this.dgProcessosEnviados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProcessosEnviados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProcessosEnviados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF,
            this.Status});
            this.dgProcessosEnviados.Location = new System.Drawing.Point(1, 2);
            this.dgProcessosEnviados.Name = "dgProcessosEnviados";
            this.dgProcessosEnviados.Size = new System.Drawing.Size(353, 429);
            this.dgProcessosEnviados.TabIndex = 0;
            this.dgProcessosEnviados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProcessosEnviados_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome_dados";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF_dados";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // TelaProcessosEnviados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(358, 434);
            this.Controls.Add(this.dgProcessosEnviados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaProcessosEnviados";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Processos Enviados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaProcessosEnviados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProcessosEnviados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProcessosEnviados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}