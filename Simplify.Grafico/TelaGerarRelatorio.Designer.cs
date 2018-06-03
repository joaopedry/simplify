namespace Simplify.Grafico
{
    partial class TelaGerarRelatorio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnResultado = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSuatusProcesso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataInicioRelatorio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFimRelatorio = new System.Windows.Forms.DateTimePicker();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btImprimirRelatorio = new System.Windows.Forms.Button();
            this.ppvRelatorio = new System.Windows.Forms.PrintPreviewControl();
            this.pdRelatorio = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.pnResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.btGerarRelatorio);
            this.panel1.Controls.Add(this.dtpDataFimRelatorio);
            this.panel1.Controls.Add(this.dtpDataInicioRelatorio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbSuatusProcesso);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 737);
            this.panel1.TabIndex = 0;
            // 
            // pnResultado
            // 
            this.pnResultado.BackColor = System.Drawing.Color.Gainsboro;
            this.pnResultado.Controls.Add(this.ppvRelatorio);
            this.pnResultado.Controls.Add(this.btImprimirRelatorio);
            this.pnResultado.Location = new System.Drawing.Point(504, 2);
            this.pnResultado.Name = "pnResultado";
            this.pnResultado.Size = new System.Drawing.Size(476, 737);
            this.pnResultado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatórios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status do Processo:";
            // 
            // cbSuatusProcesso
            // 
            this.cbSuatusProcesso.FormattingEnabled = true;
            this.cbSuatusProcesso.Location = new System.Drawing.Point(179, 139);
            this.cbSuatusProcesso.Name = "cbSuatusProcesso";
            this.cbSuatusProcesso.Size = new System.Drawing.Size(200, 24);
            this.cbSuatusProcesso.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Início:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data final:";
            // 
            // dtpDataInicioRelatorio
            // 
            this.dtpDataInicioRelatorio.Location = new System.Drawing.Point(179, 239);
            this.dtpDataInicioRelatorio.Name = "dtpDataInicioRelatorio";
            this.dtpDataInicioRelatorio.Size = new System.Drawing.Size(200, 22);
            this.dtpDataInicioRelatorio.TabIndex = 5;
            // 
            // dtpDataFimRelatorio
            // 
            this.dtpDataFimRelatorio.Location = new System.Drawing.Point(179, 339);
            this.dtpDataFimRelatorio.Name = "dtpDataFimRelatorio";
            this.dtpDataFimRelatorio.Size = new System.Drawing.Size(200, 22);
            this.dtpDataFimRelatorio.TabIndex = 6;
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.Location = new System.Drawing.Point(282, 694);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(100, 31);
            this.btGerarRelatorio.TabIndex = 7;
            this.btGerarRelatorio.Text = "Gerar";
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(388, 694);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(100, 31);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btImprimirRelatorio
            // 
            this.btImprimirRelatorio.Location = new System.Drawing.Point(366, 696);
            this.btImprimirRelatorio.Name = "btImprimirRelatorio";
            this.btImprimirRelatorio.Size = new System.Drawing.Size(100, 31);
            this.btImprimirRelatorio.TabIndex = 0;
            this.btImprimirRelatorio.Text = "Imprimir";
            this.btImprimirRelatorio.UseVisualStyleBackColor = true;
            // 
            // ppvRelatorio
            // 
            this.ppvRelatorio.Location = new System.Drawing.Point(12, 10);
            this.ppvRelatorio.Name = "ppvRelatorio";
            this.ppvRelatorio.Size = new System.Drawing.Size(454, 675);
            this.ppvRelatorio.TabIndex = 1;
            // 
            // pdRelatorio
            // 
            this.pdRelatorio.UseEXDialog = true;
            // 
            // TelaGerarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(982, 741);
            this.Controls.Add(this.pnResultado);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 788);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 788);
            this.Name = "TelaGerarRelatorio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaGerarRelatorio_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnResultado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.DateTimePicker dtpDataFimRelatorio;
        private System.Windows.Forms.DateTimePicker dtpDataInicioRelatorio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSuatusProcesso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnResultado;
        private System.Windows.Forms.PrintPreviewControl ppvRelatorio;
        private System.Windows.Forms.Button btImprimirRelatorio;
        private System.Windows.Forms.PrintDialog pdRelatorio;
    }
}