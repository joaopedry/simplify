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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDataGeracao = new System.Windows.Forms.Label();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbDatainicio = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbProcessosConcluidos = new System.Windows.Forms.Label();
            this.lbProcessosPendentes = new System.Windows.Forms.Label();
            this.lbProcessosEnviados = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbProcessosNegados = new System.Windows.Forms.Label();
            this.lbProcessosEmAberto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbProcessosAprovados = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btImprimirRelatorio = new System.Windows.Forms.Button();
            this.pdRelatorio = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.pnResultado.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 599);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(291, 564);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2);
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
            this.btGerarRelatorio.Margin = new System.Windows.Forms.Padding(2);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(75, 25);
            this.btGerarRelatorio.TabIndex = 7;
            this.btGerarRelatorio.Text = "Gerar";
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // dtpDataFimRelatorio
            // 
            this.dtpDataFimRelatorio.Location = new System.Drawing.Point(122, 165);
            this.dtpDataFimRelatorio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataFimRelatorio.Name = "dtpDataFimRelatorio";
            this.dtpDataFimRelatorio.Size = new System.Drawing.Size(232, 20);
            this.dtpDataFimRelatorio.TabIndex = 6;
            // 
            // dtpDataInicioRelatorio
            // 
            this.dtpDataInicioRelatorio.Location = new System.Drawing.Point(122, 112);
            this.dtpDataInicioRelatorio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataInicioRelatorio.Name = "dtpDataInicioRelatorio";
            this.dtpDataInicioRelatorio.Size = new System.Drawing.Size(232, 20);
            this.dtpDataInicioRelatorio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 165);
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
            this.label3.Location = new System.Drawing.Point(10, 112);
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
            this.pnResultado.Controls.Add(this.panel2);
            this.pnResultado.Controls.Add(this.btImprimirRelatorio);
            this.pnResultado.Location = new System.Drawing.Point(378, 2);
            this.pnResultado.Margin = new System.Windows.Forms.Padding(2);
            this.pnResultado.Name = "pnResultado";
            this.pnResultado.Size = new System.Drawing.Size(357, 599);
            this.pnResultado.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbDataGeracao);
            this.panel2.Controls.Add(this.lbDataFinal);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lbDatainicio);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbProcessosConcluidos);
            this.panel2.Controls.Add(this.lbProcessosPendentes);
            this.panel2.Controls.Add(this.lbProcessosEnviados);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbProcessosNegados);
            this.panel2.Controls.Add(this.lbProcessosEmAberto);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbProcessosAprovados);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(11, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 551);
            this.panel2.TabIndex = 1;
            // 
            // lbDataGeracao
            // 
            this.lbDataGeracao.AutoSize = true;
            this.lbDataGeracao.Location = new System.Drawing.Point(171, 527);
            this.lbDataGeracao.Name = "lbDataGeracao";
            this.lbDataGeracao.Size = new System.Drawing.Size(48, 16);
            this.lbDataGeracao.TabIndex = 26;
            this.lbDataGeracao.Text = "--/--/----";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataFinal.Location = new System.Drawing.Point(214, 84);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(48, 16);
            this.lbDataFinal.TabIndex = 25;
            this.lbDataFinal.Text = "--/--/----";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(174, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "e";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // lbDatainicio
            // 
            this.lbDatainicio.AutoSize = true;
            this.lbDatainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatainicio.Location = new System.Drawing.Point(90, 84);
            this.lbDatainicio.Name = "lbDatainicio";
            this.lbDatainicio.Size = new System.Drawing.Size(48, 16);
            this.lbDatainicio.TabIndex = 23;
            this.lbDatainicio.Text = "--/--/----";
            this.lbDatainicio.Click += new System.EventHandler(this.lbDatainicio_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Período:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Gerado em:  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 311);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Processos Concluídos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Relatório";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Processos Enviados:";
            // 
            // lbProcessosConcluidos
            // 
            this.lbProcessosConcluidos.AutoSize = true;
            this.lbProcessosConcluidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessosConcluidos.Location = new System.Drawing.Point(184, 313);
            this.lbProcessosConcluidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessosConcluidos.Name = "lbProcessosConcluidos";
            this.lbProcessosConcluidos.Size = new System.Drawing.Size(12, 16);
            this.lbProcessosConcluidos.TabIndex = 19;
            this.lbProcessosConcluidos.Text = "-";
            // 
            // lbProcessosPendentes
            // 
            this.lbProcessosPendentes.AutoSize = true;
            this.lbProcessosPendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessosPendentes.Location = new System.Drawing.Point(184, 192);
            this.lbProcessosPendentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessosPendentes.Name = "lbProcessosPendentes";
            this.lbProcessosPendentes.Size = new System.Drawing.Size(12, 16);
            this.lbProcessosPendentes.TabIndex = 11;
            this.lbProcessosPendentes.Text = "-";
            // 
            // lbProcessosEnviados
            // 
            this.lbProcessosEnviados.AutoSize = true;
            this.lbProcessosEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessosEnviados.Location = new System.Drawing.Point(184, 153);
            this.lbProcessosEnviados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessosEnviados.Name = "lbProcessosEnviados";
            this.lbProcessosEnviados.Size = new System.Drawing.Size(12, 16);
            this.lbProcessosEnviados.TabIndex = 9;
            this.lbProcessosEnviados.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 355);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Processos Em Aberto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Processos Pendentes:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbProcessosNegados
            // 
            this.lbProcessosNegados.AutoSize = true;
            this.lbProcessosNegados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessosNegados.Location = new System.Drawing.Point(184, 232);
            this.lbProcessosNegados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessosNegados.Name = "lbProcessosNegados";
            this.lbProcessosNegados.Size = new System.Drawing.Size(12, 16);
            this.lbProcessosNegados.TabIndex = 13;
            this.lbProcessosNegados.Text = "-";
            // 
            // lbProcessosEmAberto
            // 
            this.lbProcessosEmAberto.AutoSize = true;
            this.lbProcessosEmAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessosEmAberto.Location = new System.Drawing.Point(184, 355);
            this.lbProcessosEmAberto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessosEmAberto.Name = "lbProcessosEmAberto";
            this.lbProcessosEmAberto.Size = new System.Drawing.Size(12, 16);
            this.lbProcessosEmAberto.TabIndex = 17;
            this.lbProcessosEmAberto.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 232);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Processos Negados:";
            // 
            // lbProcessosAprovados
            // 
            this.lbProcessosAprovados.AutoSize = true;
            this.lbProcessosAprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessosAprovados.Location = new System.Drawing.Point(184, 273);
            this.lbProcessosAprovados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessosAprovados.Name = "lbProcessosAprovados";
            this.lbProcessosAprovados.Size = new System.Drawing.Size(12, 16);
            this.lbProcessosAprovados.TabIndex = 15;
            this.lbProcessosAprovados.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 273);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Processos Aprovados:";
            // 
            // btImprimirRelatorio
            // 
            this.btImprimirRelatorio.Location = new System.Drawing.Point(274, 566);
            this.btImprimirRelatorio.Margin = new System.Windows.Forms.Padding(2);
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
            // TelaGerarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(738, 610);
            this.Controls.Add(this.pnResultado);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbDatainicio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDataGeracao;
    }
}