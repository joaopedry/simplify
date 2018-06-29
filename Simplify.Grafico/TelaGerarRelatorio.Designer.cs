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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.dtpDataFimRelatorio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicioRelatorio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnResultado = new System.Windows.Forms.Panel();
            this.btImprimirRelatorio = new System.Windows.Forms.Button();
            this.pdRelatorio = new System.Windows.Forms.PrintDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.lbProcessosEnviados = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbProcessosPendentes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbProcessosNegados = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbProcessosAprovados = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbProcessosEmAberto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbProcessosConcluidos = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 599);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(291, 564);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 25);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.Location = new System.Drawing.Point(212, 564);
            this.btGerarRelatorio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(75, 25);
            this.btGerarRelatorio.TabIndex = 7;
            this.btGerarRelatorio.Text = "Gerar";
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // dtpDataFimRelatorio
            // 
            this.dtpDataFimRelatorio.Location = new System.Drawing.Point(134, 275);
            this.dtpDataFimRelatorio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataFimRelatorio.Name = "dtpDataFimRelatorio";
            this.dtpDataFimRelatorio.Size = new System.Drawing.Size(151, 20);
            this.dtpDataFimRelatorio.TabIndex = 6;
            // 
            // dtpDataInicioRelatorio
            // 
            this.dtpDataInicioRelatorio.Location = new System.Drawing.Point(134, 194);
            this.dtpDataInicioRelatorio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataInicioRelatorio.Name = "dtpDataInicioRelatorio";
            this.dtpDataInicioRelatorio.Size = new System.Drawing.Size(151, 20);
            this.dtpDataInicioRelatorio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Início:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerar Relatórios";
            // 
            // pnResultado
            // 
            this.pnResultado.BackColor = System.Drawing.Color.Gainsboro;
            this.pnResultado.Controls.Add(this.label11);
            this.pnResultado.Controls.Add(this.lbProcessosConcluidos);
            this.pnResultado.Controls.Add(this.label7);
            this.pnResultado.Controls.Add(this.lbProcessosEmAberto);
            this.pnResultado.Controls.Add(this.label10);
            this.pnResultado.Controls.Add(this.lbProcessosAprovados);
            this.pnResultado.Controls.Add(this.label8);
            this.pnResultado.Controls.Add(this.lbProcessosNegados);
            this.pnResultado.Controls.Add(this.label6);
            this.pnResultado.Controls.Add(this.lbProcessosPendentes);
            this.pnResultado.Controls.Add(this.label5);
            this.pnResultado.Controls.Add(this.lbProcessosEnviados);
            this.pnResultado.Controls.Add(this.label2);
            this.pnResultado.Controls.Add(this.btImprimirRelatorio);
            this.pnResultado.Location = new System.Drawing.Point(378, 2);
            this.pnResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnResultado.Name = "pnResultado";
            this.pnResultado.Size = new System.Drawing.Size(357, 599);
            this.pnResultado.TabIndex = 1;
            // 
            // btImprimirRelatorio
            // 
            this.btImprimirRelatorio.Location = new System.Drawing.Point(274, 566);
            this.btImprimirRelatorio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btImprimirRelatorio.Name = "btImprimirRelatorio";
            this.btImprimirRelatorio.Size = new System.Drawing.Size(75, 25);
            this.btImprimirRelatorio.TabIndex = 0;
            this.btImprimirRelatorio.Text = "Imprimir";
            this.btImprimirRelatorio.UseVisualStyleBackColor = true;
            // 
            // pdRelatorio
            // 
            this.pdRelatorio.UseEXDialog = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Relatório";
            // 
            // lbProcessosEnviados
            // 
            this.lbProcessosEnviados.AutoSize = true;
            this.lbProcessosEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessosEnviados.Location = new System.Drawing.Point(162, 123);
            this.lbProcessosEnviados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessosEnviados.Name = "lbProcessosEnviados";
            this.lbProcessosEnviados.Size = new System.Drawing.Size(11, 15);
            this.lbProcessosEnviados.TabIndex = 9;
            this.lbProcessosEnviados.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Processos Enviados:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Processos Pendentes:";
            // 
            // lbProcessosPendentes
            // 
            this.lbProcessosPendentes.AutoSize = true;
            this.lbProcessosPendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessosPendentes.Location = new System.Drawing.Point(162, 165);
            this.lbProcessosPendentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessosPendentes.Name = "lbProcessosPendentes";
            this.lbProcessosPendentes.Size = new System.Drawing.Size(11, 15);
            this.lbProcessosPendentes.TabIndex = 11;
            this.lbProcessosPendentes.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Processos Negados:";
            // 
            // lbProcessosNegados
            // 
            this.lbProcessosNegados.AutoSize = true;
            this.lbProcessosNegados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessosNegados.Location = new System.Drawing.Point(162, 210);
            this.lbProcessosNegados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessosNegados.Name = "lbProcessosNegados";
            this.lbProcessosNegados.Size = new System.Drawing.Size(11, 15);
            this.lbProcessosNegados.TabIndex = 13;
            this.lbProcessosNegados.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 246);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Processos Aprovados:";
            // 
            // lbProcessosAprovados
            // 
            this.lbProcessosAprovados.AutoSize = true;
            this.lbProcessosAprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessosAprovados.Location = new System.Drawing.Point(162, 246);
            this.lbProcessosAprovados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessosAprovados.Name = "lbProcessosAprovados";
            this.lbProcessosAprovados.Size = new System.Drawing.Size(11, 15);
            this.lbProcessosAprovados.TabIndex = 15;
            this.lbProcessosAprovados.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Processos Em Aberto:";
            // 
            // lbProcessosEmAberto
            // 
            this.lbProcessosEmAberto.AutoSize = true;
            this.lbProcessosEmAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessosEmAberto.Location = new System.Drawing.Point(162, 314);
            this.lbProcessosEmAberto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessosEmAberto.Name = "lbProcessosEmAberto";
            this.lbProcessosEmAberto.Size = new System.Drawing.Size(11, 15);
            this.lbProcessosEmAberto.TabIndex = 17;
            this.lbProcessosEmAberto.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 279);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Processos Concluídos:";
            // 
            // lbProcessosConcluidos
            // 
            this.lbProcessosConcluidos.AutoSize = true;
            this.lbProcessosConcluidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessosConcluidos.Location = new System.Drawing.Point(162, 279);
            this.lbProcessosConcluidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessosConcluidos.Name = "lbProcessosConcluidos";
            this.lbProcessosConcluidos.Size = new System.Drawing.Size(11, 15);
            this.lbProcessosConcluidos.TabIndex = 19;
            this.lbProcessosConcluidos.Text = "-";
            // 
            // TelaGerarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(738, 609);
            this.Controls.Add(this.pnResultado);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(754, 648);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(754, 648);
            this.Name = "TelaGerarRelatorio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.TelaGerarRelatorio_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaGerarRelatorio_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnResultado.ResumeLayout(false);
            this.pnResultado.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnResultado;
        private System.Windows.Forms.Button btImprimirRelatorio;
        private System.Windows.Forms.PrintDialog pdRelatorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbProcessosEnviados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbProcessosAprovados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbProcessosNegados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbProcessosPendentes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbProcessosConcluidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbProcessosEmAberto;
    }
}