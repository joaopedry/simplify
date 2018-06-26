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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btEmail = new System.Windows.Forms.Button();
            this.btSeguradora = new System.Windows.Forms.Button();
            this.btDpvatonline = new System.Windows.Forms.Button();
            this.txtSimplify = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btConsultarProcesso = new System.Windows.Forms.Button();
            this.btNovoCadastro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbAniversariantes = new System.Windows.Forms.Label();
            this.dgAniversariantes = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbProcessoNegado = new System.Windows.Forms.Label();
            this.lbProcessoPendencia = new System.Windows.Forms.Label();
            this.lbProcessosEnviados = new System.Windows.Forms.Label();
            this.btProcessocompendencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btProcessEnviados = new System.Windows.Forms.Button();
            this.btProcessosnegados = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btRelatorios = new System.Windows.Forms.Button();
            this.cbGraficoProcessosnegdos = new System.Windows.Forms.CheckBox();
            this.cbGraficoProcessosenviados = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.ttConfiguracoes = new System.Windows.Forms.ToolTip(this.components);
            this.ttInfomacoes = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btEmail);
            this.panel1.Controls.Add(this.btSeguradora);
            this.panel1.Controls.Add(this.btDpvatonline);
            this.panel1.Controls.Add(this.txtSimplify);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 181);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(39, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.ttInfomacoes.SetToolTip(this.pictureBox3, "Informações");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.ttConfiguracoes.SetToolTip(this.pictureBox2, "Configurações");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(654, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 135);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btEmail
            // 
            this.btEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEmail.AutoSize = true;
            this.btEmail.BackColor = System.Drawing.Color.DarkGray;
            this.btEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmail.Location = new System.Drawing.Point(350, 138);
            this.btEmail.Margin = new System.Windows.Forms.Padding(2);
            this.btEmail.Name = "btEmail";
            this.btEmail.Size = new System.Drawing.Size(97, 27);
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
            this.btSeguradora.Location = new System.Drawing.Point(451, 139);
            this.btSeguradora.Margin = new System.Windows.Forms.Padding(2);
            this.btSeguradora.Name = "btSeguradora";
            this.btSeguradora.Size = new System.Drawing.Size(97, 27);
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
            this.btDpvatonline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDpvatonline.Location = new System.Drawing.Point(552, 138);
            this.btDpvatonline.Margin = new System.Windows.Forms.Padding(2);
            this.btDpvatonline.Name = "btDpvatonline";
            this.btDpvatonline.Size = new System.Drawing.Size(97, 27);
            this.btDpvatonline.TabIndex = 10;
            this.btDpvatonline.Text = "DPVAT online";
            this.btDpvatonline.UseVisualStyleBackColor = false;
            // 
            // txtSimplify
            // 
            this.txtSimplify.AutoSize = true;
            this.txtSimplify.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtSimplify.Location = new System.Drawing.Point(10, 137);
            this.txtSimplify.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSimplify.Name = "txtSimplify";
            this.txtSimplify.Size = new System.Drawing.Size(221, 31);
            this.txtSimplify.TabIndex = 0;
            this.txtSimplify.Text = "Simplify DPVAT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btConsultarProcesso);
            this.panel2.Controls.Add(this.btNovoCadastro);
            this.panel2.Location = new System.Drawing.Point(1, 184);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 157);
            this.panel2.TabIndex = 5;
            // 
            // btConsultarProcesso
            // 
            this.btConsultarProcesso.BackColor = System.Drawing.Color.DarkGray;
            this.btConsultarProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarProcesso.Location = new System.Drawing.Point(10, 86);
            this.btConsultarProcesso.Margin = new System.Windows.Forms.Padding(2);
            this.btConsultarProcesso.Name = "btConsultarProcesso";
            this.btConsultarProcesso.Size = new System.Drawing.Size(203, 55);
            this.btConsultarProcesso.TabIndex = 1;
            this.btConsultarProcesso.Text = "Consultar Cadastro";
            this.btConsultarProcesso.UseVisualStyleBackColor = false;
            this.btConsultarProcesso.Click += new System.EventHandler(this.btConsultarProcesso_Click);
            // 
            // btNovoCadastro
            // 
            this.btNovoCadastro.BackColor = System.Drawing.Color.DarkGray;
            this.btNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoCadastro.Location = new System.Drawing.Point(10, 15);
            this.btNovoCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.btNovoCadastro.Name = "btNovoCadastro";
            this.btNovoCadastro.Size = new System.Drawing.Size(203, 59);
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
            this.panel3.Location = new System.Drawing.Point(1, 345);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 206);
            this.panel3.TabIndex = 6;
            // 
            // lbAniversariantes
            // 
            this.lbAniversariantes.AutoSize = true;
            this.lbAniversariantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAniversariantes.Location = new System.Drawing.Point(9, 8);
            this.lbAniversariantes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAniversariantes.Name = "lbAniversariantes";
            this.lbAniversariantes.Size = new System.Drawing.Size(204, 20);
            this.lbAniversariantes.TabIndex = 1;
            this.lbAniversariantes.Text = "Aniversariantes da Semana";
            this.lbAniversariantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgAniversariantes
            // 
            this.dgAniversariantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgAniversariantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAniversariantes.Location = new System.Drawing.Point(10, 30);
            this.dgAniversariantes.Margin = new System.Windows.Forms.Padding(2);
            this.dgAniversariantes.Name = "dgAniversariantes";
            this.dgAniversariantes.RowTemplate.Height = 24;
            this.dgAniversariantes.Size = new System.Drawing.Size(203, 162);
            this.dgAniversariantes.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.lbProcessoNegado);
            this.panel4.Controls.Add(this.lbProcessoPendencia);
            this.panel4.Controls.Add(this.lbProcessosEnviados);
            this.panel4.Controls.Add(this.btProcessocompendencia);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btProcessosnegados);
            this.panel4.Controls.Add(this.btProcessEnviados);
            this.panel4.Location = new System.Drawing.Point(236, 185);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 366);
            this.panel4.TabIndex = 7;
            // 
            // lbProcessoNegado
            // 
            this.lbProcessoNegado.AutoSize = true;
            this.lbProcessoNegado.BackColor = System.Drawing.Color.DarkGray;
            this.lbProcessoNegado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbProcessoNegado.ForeColor = System.Drawing.Color.Tomato;
            this.lbProcessoNegado.Location = new System.Drawing.Point(104, 259);
            this.lbProcessoNegado.Name = "lbProcessoNegado";
            this.lbProcessoNegado.Size = new System.Drawing.Size(25, 25);
            this.lbProcessoNegado.TabIndex = 8;
            this.lbProcessoNegado.Text = "0";
            // 
            // lbProcessoPendencia
            // 
            this.lbProcessoPendencia.AutoSize = true;
            this.lbProcessoPendencia.BackColor = System.Drawing.Color.DarkGray;
            this.lbProcessoPendencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbProcessoPendencia.ForeColor = System.Drawing.Color.Khaki;
            this.lbProcessoPendencia.Location = new System.Drawing.Point(104, 181);
            this.lbProcessoPendencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessoPendencia.Name = "lbProcessoPendencia";
            this.lbProcessoPendencia.Size = new System.Drawing.Size(25, 25);
            this.lbProcessoPendencia.TabIndex = 7;
            this.lbProcessoPendencia.Text = "0";
            // 
            // lbProcessosEnviados
            // 
            this.lbProcessosEnviados.AutoSize = true;
            this.lbProcessosEnviados.BackColor = System.Drawing.Color.DarkGray;
            this.lbProcessosEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbProcessosEnviados.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbProcessosEnviados.Location = new System.Drawing.Point(104, 98);
            this.lbProcessosEnviados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessosEnviados.Name = "lbProcessosEnviados";
            this.lbProcessosEnviados.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.lbProcessosEnviados.Size = new System.Drawing.Size(25, 32);
            this.lbProcessosEnviados.TabIndex = 6;
            this.lbProcessosEnviados.Text = "0";
            this.lbProcessosEnviados.Click += new System.EventHandler(this.lbProcessosEnviados_Click);
            // 
            // btProcessocompendencia
            // 
            this.btProcessocompendencia.BackColor = System.Drawing.Color.DarkGray;
            this.btProcessocompendencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessocompendencia.Location = new System.Drawing.Point(4, 144);
            this.btProcessocompendencia.Margin = new System.Windows.Forms.Padding(2);
            this.btProcessocompendencia.Name = "btProcessocompendencia";
            this.btProcessocompendencia.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.btProcessocompendencia.Size = new System.Drawing.Size(213, 74);
            this.btProcessocompendencia.TabIndex = 2;
            this.btProcessocompendencia.Text = "Processos Pendentes";
            this.btProcessocompendencia.UseVisualStyleBackColor = false;
            this.btProcessocompendencia.Click += new System.EventHandler(this.btProcessocompendencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informativo";
            // 
            // btProcessEnviados
            // 
            this.btProcessEnviados.BackColor = System.Drawing.Color.DarkGray;
            this.btProcessEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessEnviados.Location = new System.Drawing.Point(4, 66);
            this.btProcessEnviados.Margin = new System.Windows.Forms.Padding(2);
            this.btProcessEnviados.Name = "btProcessEnviados";
            this.btProcessEnviados.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.btProcessEnviados.Size = new System.Drawing.Size(213, 74);
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
            this.btProcessosnegados.Location = new System.Drawing.Point(4, 222);
            this.btProcessosnegados.Margin = new System.Windows.Forms.Padding(2);
            this.btProcessosnegados.Name = "btProcessosnegados";
            this.btProcessosnegados.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.btProcessosnegados.Size = new System.Drawing.Size(213, 72);
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
            this.panel5.Location = new System.Drawing.Point(465, 184);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(318, 366);
            this.panel5.TabIndex = 8;
            // 
            // btRelatorios
            // 
            this.btRelatorios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRelatorios.BackColor = System.Drawing.Color.DarkGray;
            this.btRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRelatorios.Location = new System.Drawing.Point(216, 325);
            this.btRelatorios.Margin = new System.Windows.Forms.Padding(2);
            this.btRelatorios.Name = "btRelatorios";
            this.btRelatorios.Size = new System.Drawing.Size(94, 30);
            this.btRelatorios.TabIndex = 4;
            this.btRelatorios.Text = "Relatórios";
            this.btRelatorios.UseVisualStyleBackColor = false;
            this.btRelatorios.Click += new System.EventHandler(this.btRelatorios_Click);
            // 
            // cbGraficoProcessosnegdos
            // 
            this.cbGraficoProcessosnegdos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbGraficoProcessosnegdos.AutoSize = true;
            this.cbGraficoProcessosnegdos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGraficoProcessosnegdos.Location = new System.Drawing.Point(9, 336);
            this.cbGraficoProcessosnegdos.Margin = new System.Windows.Forms.Padding(2);
            this.cbGraficoProcessosnegdos.Name = "cbGraficoProcessosnegdos";
            this.cbGraficoProcessosnegdos.Size = new System.Drawing.Size(136, 19);
            this.cbGraficoProcessosnegdos.TabIndex = 3;
            this.cbGraficoProcessosnegdos.Text = "Processos Negados";
            this.cbGraficoProcessosnegdos.UseVisualStyleBackColor = true;
            // 
            // cbGraficoProcessosenviados
            // 
            this.cbGraficoProcessosenviados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbGraficoProcessosenviados.AutoSize = true;
            this.cbGraficoProcessosenviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGraficoProcessosenviados.Location = new System.Drawing.Point(9, 313);
            this.cbGraficoProcessosenviados.Margin = new System.Windows.Forms.Padding(2);
            this.cbGraficoProcessosenviados.Name = "cbGraficoProcessosenviados";
            this.cbGraficoProcessosenviados.Size = new System.Drawing.Size(136, 19);
            this.cbGraficoProcessosenviados.TabIndex = 2;
            this.cbGraficoProcessosenviados.Text = "Processos Enviados";
            this.cbGraficoProcessosenviados.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(9, 75);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(299, 163);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resultados";
            // 
            // ttConfiguracoes
            // 
            this.ttConfiguracoes.Tag = "Configurações";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "TelaPrincipal";
            this.Text = "Simplify DPVAT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.TelaPrincipal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEmail;
        private System.Windows.Forms.Button btSeguradora;
        private System.Windows.Forms.Button btDpvatonline;
        private System.Windows.Forms.Label txtSimplify;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btNovoCadastro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgAniversariantes;
        private System.Windows.Forms.Label lbAniversariantes;
        private System.Windows.Forms.Button btProcessosnegados;
        private System.Windows.Forms.Button btProcessEnviados;
        private System.Windows.Forms.Button btProcessocompendencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbProcessoNegado;
        private System.Windows.Forms.Label lbProcessoPendencia;
        private System.Windows.Forms.Label lbProcessosEnviados;
        private System.Windows.Forms.CheckBox cbGraficoProcessosnegdos;
        private System.Windows.Forms.CheckBox cbGraficoProcessosenviados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btRelatorios;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip ttConfiguracoes;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip ttInfomacoes;
        private System.Windows.Forms.Button btConsultarProcesso;
    }
}



