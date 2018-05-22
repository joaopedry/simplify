namespace Simplify.Grafico
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btEmail = new System.Windows.Forms.Button();
            this.btSeguradora = new System.Windows.Forms.Button();
            this.btDpvatonline = new System.Windows.Forms.Button();
            this.txtSimplify = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btConsulta = new System.Windows.Forms.Button();
            this.txtConsultaprocesso = new System.Windows.Forms.Label();
            this.btNovoCadastro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbAniversariantes = new System.Windows.Forms.Label();
            this.dgAniversariantes = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbProcessoNegado = new System.Windows.Forms.Label();
            this.lbProcessoPendencia = new System.Windows.Forms.Label();
            this.lbProcessosEnviados = new System.Windows.Forms.Label();
            this.lbProcessoAndamento = new System.Windows.Forms.Label();
            this.btProcessAndamento = new System.Windows.Forms.Button();
            this.btProcessocompendencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btProcessEnviados = new System.Windows.Forms.Button();
            this.btProcessosnegados = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbGraficoProcessosnegdos = new System.Windows.Forms.CheckBox();
            this.cbGraficoProcessosenviados = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.btRelatorios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAniversariantes)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btEmail);
            this.panel1.Controls.Add(this.btSeguradora);
            this.panel1.Controls.Add(this.btDpvatonline);
            this.panel1.Controls.Add(this.txtSimplify);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1803, 223);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1579, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 165);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btEmail
            // 
            this.btEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEmail.AutoSize = true;
            this.btEmail.BackColor = System.Drawing.Color.DarkGray;
            this.btEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmail.Location = new System.Drawing.Point(1052, 133);
            this.btEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEmail.Name = "btEmail";
            this.btEmail.Size = new System.Drawing.Size(148, 43);
            this.btEmail.TabIndex = 12;
            this.btEmail.Text = "Email";
            this.btEmail.UseVisualStyleBackColor = false;
            this.btEmail.Click += new System.EventHandler(this.btEmail_Click);
            // 
            // btSeguradora
            // 
            this.btSeguradora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSeguradora.AutoSize = true;
            this.btSeguradora.BackColor = System.Drawing.Color.DarkGray;
            this.btSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeguradora.Location = new System.Drawing.Point(1205, 133);
            this.btSeguradora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSeguradora.Name = "btSeguradora";
            this.btSeguradora.Size = new System.Drawing.Size(161, 43);
            this.btSeguradora.TabIndex = 11;
            this.btSeguradora.Text = "Seguradora ";
            this.btSeguradora.UseVisualStyleBackColor = false;
            this.btSeguradora.Click += new System.EventHandler(this.btSeguradora_Click);
            // 
            // btDpvatonline
            // 
            this.btDpvatonline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDpvatonline.AutoSize = true;
            this.btDpvatonline.BackColor = System.Drawing.Color.DarkGray;
            this.btDpvatonline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDpvatonline.Location = new System.Drawing.Point(1371, 133);
            this.btDpvatonline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDpvatonline.Name = "btDpvatonline";
            this.btDpvatonline.Size = new System.Drawing.Size(181, 43);
            this.btDpvatonline.TabIndex = 10;
            this.btDpvatonline.Text = "DPVAT online";
            this.btDpvatonline.UseVisualStyleBackColor = false;
            // 
            // txtSimplify
            // 
            this.txtSimplify.AutoSize = true;
            this.txtSimplify.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtSimplify.Location = new System.Drawing.Point(41, 119);
            this.txtSimplify.Name = "txtSimplify";
            this.txtSimplify.Size = new System.Drawing.Size(393, 58);
            this.txtSimplify.TabIndex = 0;
            this.txtSimplify.Text = "Simplify DPVAT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.btConsulta);
            this.panel2.Controls.Add(this.txtConsultaprocesso);
            this.panel2.Controls.Add(this.btNovoCadastro);
            this.panel2.Location = new System.Drawing.Point(1, 226);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 287);
            this.panel2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(51, 210);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(195, 41);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btConsulta
            // 
            this.btConsulta.BackColor = System.Drawing.Color.DarkGray;
            this.btConsulta.Location = new System.Drawing.Point(275, 210);
            this.btConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(121, 41);
            this.btConsulta.TabIndex = 3;
            this.btConsulta.Text = "Consultar";
            this.btConsulta.UseVisualStyleBackColor = false;
            // 
            // txtConsultaprocesso
            // 
            this.txtConsultaprocesso.AutoSize = true;
            this.txtConsultaprocesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaprocesso.Location = new System.Drawing.Point(124, 144);
            this.txtConsultaprocesso.Name = "txtConsultaprocesso";
            this.txtConsultaprocesso.Size = new System.Drawing.Size(202, 26);
            this.txtConsultaprocesso.TabIndex = 1;
            this.txtConsultaprocesso.Text = "Consultar Processo";
            // 
            // btNovoCadastro
            // 
            this.btNovoCadastro.BackColor = System.Drawing.Color.DarkGray;
            this.btNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoCadastro.Location = new System.Drawing.Point(77, 30);
            this.btNovoCadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNovoCadastro.Name = "btNovoCadastro";
            this.btNovoCadastro.Size = new System.Drawing.Size(299, 63);
            this.btNovoCadastro.TabIndex = 0;
            this.btNovoCadastro.Text = "Novo Cadastro";
            this.btNovoCadastro.UseVisualStyleBackColor = false;
            this.btNovoCadastro.Click += new System.EventHandler(this.btNovoCadastro_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.lbAniversariantes);
            this.panel3.Controls.Add(this.dgAniversariantes);
            this.panel3.Location = new System.Drawing.Point(1, 517);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 257);
            this.panel3.TabIndex = 6;
            // 
            // lbAniversariantes
            // 
            this.lbAniversariantes.AutoSize = true;
            this.lbAniversariantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAniversariantes.Location = new System.Drawing.Point(95, 9);
            this.lbAniversariantes.Name = "lbAniversariantes";
            this.lbAniversariantes.Size = new System.Drawing.Size(253, 25);
            this.lbAniversariantes.TabIndex = 1;
            this.lbAniversariantes.Text = "Aniversariantes da Semana";
            this.lbAniversariantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgAniversariantes
            // 
            this.dgAniversariantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgAniversariantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAniversariantes.Location = new System.Drawing.Point(3, 42);
            this.dgAniversariantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgAniversariantes.Name = "dgAniversariantes";
            this.dgAniversariantes.RowTemplate.Height = 24;
            this.dgAniversariantes.Size = new System.Drawing.Size(453, 212);
            this.dgAniversariantes.TabIndex = 0;
            this.dgAniversariantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAniversariantes_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.lbProcessoNegado);
            this.panel4.Controls.Add(this.lbProcessoPendencia);
            this.panel4.Controls.Add(this.lbProcessosEnviados);
            this.panel4.Controls.Add(this.lbProcessoAndamento);
            this.panel4.Controls.Add(this.btProcessAndamento);
            this.panel4.Controls.Add(this.btProcessocompendencia);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btProcessEnviados);
            this.panel4.Controls.Add(this.btProcessosnegados);
            this.panel4.Location = new System.Drawing.Point(473, 226);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(331, 546);
            this.panel4.TabIndex = 7;
            // 
            // lbProcessoNegado
            // 
            this.lbProcessoNegado.AutoSize = true;
            this.lbProcessoNegado.BackColor = System.Drawing.Color.DarkGray;
            this.lbProcessoNegado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbProcessoNegado.ForeColor = System.Drawing.Color.Tomato;
            this.lbProcessoNegado.Location = new System.Drawing.Point(151, 497);
            this.lbProcessoNegado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProcessoNegado.Name = "lbProcessoNegado";
            this.lbProcessoNegado.Size = new System.Drawing.Size(25, 26);
            this.lbProcessoNegado.TabIndex = 8;
            this.lbProcessoNegado.Text = "0";
            // 
            // lbProcessoPendencia
            // 
            this.lbProcessoPendencia.AutoSize = true;
            this.lbProcessoPendencia.BackColor = System.Drawing.Color.DarkGray;
            this.lbProcessoPendencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbProcessoPendencia.ForeColor = System.Drawing.Color.Khaki;
            this.lbProcessoPendencia.Location = new System.Drawing.Point(148, 375);
            this.lbProcessoPendencia.Name = "lbProcessoPendencia";
            this.lbProcessoPendencia.Size = new System.Drawing.Size(25, 26);
            this.lbProcessoPendencia.TabIndex = 7;
            this.lbProcessoPendencia.Text = "0";
            // 
            // lbProcessosEnviados
            // 
            this.lbProcessosEnviados.AutoSize = true;
            this.lbProcessosEnviados.BackColor = System.Drawing.Color.DarkGray;
            this.lbProcessosEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbProcessosEnviados.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbProcessosEnviados.Location = new System.Drawing.Point(148, 247);
            this.lbProcessosEnviados.Name = "lbProcessosEnviados";
            this.lbProcessosEnviados.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbProcessosEnviados.Size = new System.Drawing.Size(25, 35);
            this.lbProcessosEnviados.TabIndex = 6;
            this.lbProcessosEnviados.Text = "0";
            // 
            // lbProcessoAndamento
            // 
            this.lbProcessoAndamento.AutoSize = true;
            this.lbProcessoAndamento.BackColor = System.Drawing.Color.DarkGray;
            this.lbProcessoAndamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbProcessoAndamento.ForeColor = System.Drawing.Color.LightGreen;
            this.lbProcessoAndamento.Location = new System.Drawing.Point(148, 128);
            this.lbProcessoAndamento.Name = "lbProcessoAndamento";
            this.lbProcessoAndamento.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbProcessoAndamento.Size = new System.Drawing.Size(25, 35);
            this.lbProcessoAndamento.TabIndex = 5;
            this.lbProcessoAndamento.Text = "0";
            this.lbProcessoAndamento.Click += new System.EventHandler(this.label2_Click);
            // 
            // btProcessAndamento
            // 
            this.btProcessAndamento.AutoSize = true;
            this.btProcessAndamento.BackColor = System.Drawing.Color.DarkGray;
            this.btProcessAndamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessAndamento.Location = new System.Drawing.Point(5, 62);
            this.btProcessAndamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btProcessAndamento.Name = "btProcessAndamento";
            this.btProcessAndamento.Padding = new System.Windows.Forms.Padding(0, 0, 0, 29);
            this.btProcessAndamento.Size = new System.Drawing.Size(317, 116);
            this.btProcessAndamento.TabIndex = 0;
            this.btProcessAndamento.Text = "Processos em andamento";
            this.btProcessAndamento.UseVisualStyleBackColor = false;
            this.btProcessAndamento.Click += new System.EventHandler(this.btProcessAndamento_Click);
            // 
            // btProcessocompendencia
            // 
            this.btProcessocompendencia.BackColor = System.Drawing.Color.DarkGray;
            this.btProcessocompendencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessocompendencia.Location = new System.Drawing.Point(5, 304);
            this.btProcessocompendencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btProcessocompendencia.Name = "btProcessocompendencia";
            this.btProcessocompendencia.Padding = new System.Windows.Forms.Padding(0, 0, 0, 29);
            this.btProcessocompendencia.Size = new System.Drawing.Size(317, 116);
            this.btProcessocompendencia.TabIndex = 2;
            this.btProcessocompendencia.Text = "Processos com pendência";
            this.btProcessocompendencia.UseVisualStyleBackColor = false;
            this.btProcessocompendencia.Click += new System.EventHandler(this.btProcessocompendencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informativo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btProcessEnviados
            // 
            this.btProcessEnviados.BackColor = System.Drawing.Color.DarkGray;
            this.btProcessEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessEnviados.Location = new System.Drawing.Point(5, 182);
            this.btProcessEnviados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btProcessEnviados.Name = "btProcessEnviados";
            this.btProcessEnviados.Padding = new System.Windows.Forms.Padding(0, 0, 0, 29);
            this.btProcessEnviados.Size = new System.Drawing.Size(317, 116);
            this.btProcessEnviados.TabIndex = 1;
            this.btProcessEnviados.Text = "Processos enviados";
            this.btProcessEnviados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btProcessEnviados.UseVisualStyleBackColor = false;
            this.btProcessEnviados.Click += new System.EventHandler(this.btProcessEnviados_Click);
            // 
            // btProcessosnegados
            // 
            this.btProcessosnegados.BackColor = System.Drawing.Color.DarkGray;
            this.btProcessosnegados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessosnegados.Location = new System.Drawing.Point(5, 426);
            this.btProcessosnegados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btProcessosnegados.Name = "btProcessosnegados";
            this.btProcessosnegados.Padding = new System.Windows.Forms.Padding(0, 0, 0, 29);
            this.btProcessosnegados.Size = new System.Drawing.Size(317, 116);
            this.btProcessosnegados.TabIndex = 3;
            this.btProcessosnegados.Text = "Processos Negados";
            this.btProcessosnegados.UseVisualStyleBackColor = false;
            this.btProcessosnegados.Click += new System.EventHandler(this.btProcessosnegados_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.btRelatorios);
            this.panel5.Controls.Add(this.cbGraficoProcessosnegdos);
            this.panel5.Controls.Add(this.cbGraficoProcessosenviados);
            this.panel5.Controls.Add(this.chart1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(809, 226);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(960, 546);
            this.panel5.TabIndex = 8;
            // 
            // cbGraficoProcessosnegdos
            // 
            this.cbGraficoProcessosnegdos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbGraficoProcessosnegdos.AutoSize = true;
            this.cbGraficoProcessosnegdos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGraficoProcessosnegdos.Location = new System.Drawing.Point(397, 497);
            this.cbGraficoProcessosnegdos.Name = "cbGraficoProcessosnegdos";
            this.cbGraficoProcessosnegdos.Size = new System.Drawing.Size(167, 22);
            this.cbGraficoProcessosnegdos.TabIndex = 3;
            this.cbGraficoProcessosnegdos.Text = "Processos Negados";
            this.cbGraficoProcessosnegdos.UseVisualStyleBackColor = true;
            // 
            // cbGraficoProcessosenviados
            // 
            this.cbGraficoProcessosenviados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbGraficoProcessosenviados.AutoSize = true;
            this.cbGraficoProcessosenviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGraficoProcessosenviados.Location = new System.Drawing.Point(40, 497);
            this.cbGraficoProcessosenviados.Name = "cbGraficoProcessosenviados";
            this.cbGraficoProcessosenviados.Size = new System.Drawing.Size(168, 22);
            this.cbGraficoProcessosenviados.TabIndex = 2;
            this.cbGraficoProcessosenviados.Text = "Processos Enviados";
            this.cbGraficoProcessosenviados.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(40, 62);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(910, 404);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resultados";
            // 
            // btRelatorios
            // 
            this.btRelatorios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRelatorios.BackColor = System.Drawing.Color.DarkGray;
            this.btRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRelatorios.Location = new System.Drawing.Point(796, 490);
            this.btRelatorios.Name = "btRelatorios";
            this.btRelatorios.Size = new System.Drawing.Size(126, 37);
            this.btRelatorios.TabIndex = 4;
            this.btRelatorios.Text = "Relatórios";
            this.btRelatorios.UseVisualStyleBackColor = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1771, 786);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaPrincipal";
            this.Text = "Simplify DPVAT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAniversariantes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEmail;
        private System.Windows.Forms.Button btSeguradora;
        private System.Windows.Forms.Button btDpvatonline;
        private System.Windows.Forms.Label txtSimplify;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtConsultaprocesso;
        private System.Windows.Forms.Button btNovoCadastro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgAniversariantes;
        private System.Windows.Forms.Label lbAniversariantes;
        private System.Windows.Forms.Button btProcessosnegados;
        private System.Windows.Forms.Button btProcessEnviados;
        private System.Windows.Forms.Button btProcessocompendencia;
        private System.Windows.Forms.Button btProcessAndamento;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProcessoAndamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbProcessoNegado;
        private System.Windows.Forms.Label lbProcessoPendencia;
        private System.Windows.Forms.Label lbProcessosEnviados;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox cbGraficoProcessosnegdos;
        private System.Windows.Forms.CheckBox cbGraficoProcessosenviados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btRelatorios;
    }
}



