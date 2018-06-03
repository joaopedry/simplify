namespace Simplify.Grafico
{
    partial class TelaAjustes
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
            this.btAdicionarUsuario = new System.Windows.Forms.Button();
            this.btRemoverUsuario = new System.Windows.Forms.Button();
            this.dgUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdicionarUsuario
            // 
            this.btAdicionarUsuario.Location = new System.Drawing.Point(12, 12);
            this.btAdicionarUsuario.Name = "btAdicionarUsuario";
            this.btAdicionarUsuario.Size = new System.Drawing.Size(90, 49);
            this.btAdicionarUsuario.TabIndex = 0;
            this.btAdicionarUsuario.Text = "Adicionar Usuário";
            this.btAdicionarUsuario.UseVisualStyleBackColor = true;
            this.btAdicionarUsuario.Click += new System.EventHandler(this.btAdicionarUsuario_Click);
            // 
            // btRemoverUsuario
            // 
            this.btRemoverUsuario.Location = new System.Drawing.Point(119, 12);
            this.btRemoverUsuario.Name = "btRemoverUsuario";
            this.btRemoverUsuario.Size = new System.Drawing.Size(90, 49);
            this.btRemoverUsuario.TabIndex = 1;
            this.btRemoverUsuario.Text = "Remover Usuário";
            this.btRemoverUsuario.UseVisualStyleBackColor = true;
            // 
            // dgUsuario
            // 
            this.dgUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuario.Location = new System.Drawing.Point(12, 82);
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.RowTemplate.Height = 24;
            this.dgUsuario.Size = new System.Drawing.Size(782, 330);
            this.dgUsuario.TabIndex = 2;
            // 
            // TelaAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 426);
            this.Controls.Add(this.dgUsuario);
            this.Controls.Add(this.btRemoverUsuario);
            this.Controls.Add(this.btAdicionarUsuario);
            this.MaximumSize = new System.Drawing.Size(1024, 473);
            this.MinimumSize = new System.Drawing.Size(824, 473);
            this.Name = "TelaAjustes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdicionarUsuario;
        private System.Windows.Forms.Button btRemoverUsuario;
        private System.Windows.Forms.DataGridView dgUsuario;
    }
}