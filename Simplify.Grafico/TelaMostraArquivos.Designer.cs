namespace Simplify.Grafico
{
    partial class TelaMostraArquivos
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
            this.fplMostraArquivo = new System.Windows.Forms.FlowLayoutPanel();
            this.tbBoletimPassado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fplMostraArquivo
            // 
            this.fplMostraArquivo.Location = new System.Drawing.Point(13, 54);
            this.fplMostraArquivo.Name = "fplMostraArquivo";
            this.fplMostraArquivo.Size = new System.Drawing.Size(860, 614);
            this.fplMostraArquivo.TabIndex = 0;
            this.fplMostraArquivo.Paint += new System.Windows.Forms.PaintEventHandler(this.fplMostraArquivo_Paint);
            // 
            // tbBoletimPassado
            // 
            this.tbBoletimPassado.Location = new System.Drawing.Point(13, 12);
            this.tbBoletimPassado.Name = "tbBoletimPassado";
            this.tbBoletimPassado.Size = new System.Drawing.Size(502, 20);
            this.tbBoletimPassado.TabIndex = 1;
            // 
            // TelaMostraArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 698);
            this.Controls.Add(this.tbBoletimPassado);
            this.Controls.Add(this.fplMostraArquivo);
            this.Name = "TelaMostraArquivos";
            this.Text = "TelaMostraArquivos";
            this.Load += new System.EventHandler(this.TelaMostraArquivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fplMostraArquivo;
        private System.Windows.Forms.TextBox tbBoletimPassado;
    }
}