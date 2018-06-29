namespace Simplify.Grafico
{
    partial class TelaListaProcessos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaListaProcessos));
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.btBuscarProcesso = new System.Windows.Forms.Button();
            this.btAlterarDados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btImprimirFolhaDeRosto = new System.Windows.Forms.Button();
            this.dgTodosOsClientes = new System.Windows.Forms.DataGridView();
            this.Nome_dados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_dados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lb05 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbIndicacao = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.lbLesoes = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbSocorrista = new System.Windows.Forms.Label();
            this.lbProfissao = new System.Windows.Forms.Label();
            this.lbVeiculos = new System.Windows.Forms.Label();
            this.lbObservacoes = new System.Windows.Forms.Label();
            this.lbNumerocasa = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbRegistro = new System.Windows.Forms.Label();
            this.lbInss = new System.Windows.Forms.Label();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbHospital = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbLocal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgTodosOsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(12, 51);
            this.tbBusca.MaxLength = 14;
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(144, 20);
            this.tbBusca.TabIndex = 1;
            this.tbBusca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBusca_KeyPress);
            this.tbBusca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBusca_KeyUp);
            // 
            // btBuscarProcesso
            // 
            this.btBuscarProcesso.BackColor = System.Drawing.Color.White;
            this.btBuscarProcesso.Location = new System.Drawing.Point(162, 49);
            this.btBuscarProcesso.Name = "btBuscarProcesso";
            this.btBuscarProcesso.Size = new System.Drawing.Size(128, 23);
            this.btBuscarProcesso.TabIndex = 2;
            this.btBuscarProcesso.Text = "Procurar";
            this.btBuscarProcesso.UseVisualStyleBackColor = false;
            this.btBuscarProcesso.Click += new System.EventHandler(this.btBuscarProcesso_Click);
            // 
            // btAlterarDados
            // 
            this.btAlterarDados.BackColor = System.Drawing.Color.White;
            this.btAlterarDados.Location = new System.Drawing.Point(12, 77);
            this.btAlterarDados.Name = "btAlterarDados";
            this.btAlterarDados.Size = new System.Drawing.Size(144, 23);
            this.btAlterarDados.TabIndex = 3;
            this.btAlterarDados.Text = "Alterar dados cadastrais";
            this.btAlterarDados.UseVisualStyleBackColor = false;
            this.btAlterarDados.Click += new System.EventHandler(this.btAlterarDados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Busca por CPF:";
            // 
            // btImprimirFolhaDeRosto
            // 
            this.btImprimirFolhaDeRosto.BackColor = System.Drawing.Color.White;
            this.btImprimirFolhaDeRosto.Location = new System.Drawing.Point(162, 77);
            this.btImprimirFolhaDeRosto.Name = "btImprimirFolhaDeRosto";
            this.btImprimirFolhaDeRosto.Size = new System.Drawing.Size(128, 23);
            this.btImprimirFolhaDeRosto.TabIndex = 5;
            this.btImprimirFolhaDeRosto.Text = "Imprimir folha de rosto";
            this.btImprimirFolhaDeRosto.UseVisualStyleBackColor = false;
            this.btImprimirFolhaDeRosto.Click += new System.EventHandler(this.btImprimirFolhaDeRosto_Click);
            this.btImprimirFolhaDeRosto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btImprimirFolhaDeRosto_MouseClick);
            // 
            // dgTodosOsClientes
            // 
            this.dgTodosOsClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTodosOsClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome_dados,
            this.CPF_dados,
            this.StatusProcesso});
            this.dgTodosOsClientes.Location = new System.Drawing.Point(12, 106);
            this.dgTodosOsClientes.Name = "dgTodosOsClientes";
            this.dgTodosOsClientes.Size = new System.Drawing.Size(278, 482);
            this.dgTodosOsClientes.TabIndex = 30;
            this.dgTodosOsClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTodosOsClientes_CellContentClick);
            // 
            // Nome_dados
            // 
            this.Nome_dados.DataPropertyName = "Nome_dados";
            this.Nome_dados.HeaderText = "Nome";
            this.Nome_dados.Name = "Nome_dados";
            this.Nome_dados.ReadOnly = true;
            // 
            // CPF_dados
            // 
            this.CPF_dados.DataPropertyName = "CPF_dados";
            this.CPF_dados.HeaderText = "CPF";
            this.CPF_dados.Name = "CPF_dados";
            this.CPF_dados.ReadOnly = true;
            // 
            // StatusProcesso
            // 
            this.StatusProcesso.DataPropertyName = "Status";
            this.StatusProcesso.HeaderText = "Status do Processo";
            this.StatusProcesso.Name = "StatusProcesso";
            this.StatusProcesso.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "EMAIL:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(121, 235);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(10, 13);
            this.lbEmail.TabIndex = 21;
            this.lbEmail.Text = "-";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(121, 265);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(10, 13);
            this.lbRua.TabIndex = 23;
            this.lbRua.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "TELEFONE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "RUA:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(121, 205);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(10, 13);
            this.lbTelefone.TabIndex = 19;
            this.lbTelefone.Text = "-";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(121, 295);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(10, 13);
            this.lbBairro.TabIndex = 25;
            this.lbBairro.Text = "-";
            // 
            // lb05
            // 
            this.lb05.AutoSize = true;
            this.lb05.Location = new System.Drawing.Point(47, 175);
            this.lb05.Name = "lb05";
            this.lb05.Size = new System.Drawing.Size(68, 13);
            this.lb05.TabIndex = 18;
            this.lb05.Text = "INDICAÇÃO:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "BAIRRO:";
            // 
            // lbIndicacao
            // 
            this.lbIndicacao.AutoSize = true;
            this.lbIndicacao.Location = new System.Drawing.Point(121, 175);
            this.lbIndicacao.Name = "lbIndicacao";
            this.lbIndicacao.Size = new System.Drawing.Size(10, 13);
            this.lbIndicacao.TabIndex = 17;
            this.lbIndicacao.Text = "-";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(121, 145);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(10, 13);
            this.lbCPF.TabIndex = 27;
            this.lbCPF.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "NOME:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(121, 115);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(10, 13);
            this.lbNome.TabIndex = 15;
            this.lbNome.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "PROCESSO PARA SOLICITAÇÃO DE INDENIZAÇÃO ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(589, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "REFERÊNCIA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "LESÕES:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "DATA:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "SOCORRISTA:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 445);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "PROFISSÃO:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(368, 325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "REGISTRO:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(368, 355);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "INSS:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(368, 385);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "HORÁRIO:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(371, 415);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "HOSPITAL:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(368, 295);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "CIDADE:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(368, 265);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Nº:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(368, 445);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 44;
            this.label20.Text = "TIPO:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(368, 475);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 45;
            this.label21.Text = "LOCAL:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(47, 475);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "VEÍCULOS:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(47, 505);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "OBSERVAÇÕES:";
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Location = new System.Drawing.Point(121, 325);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(10, 13);
            this.lbReferencia.TabIndex = 48;
            this.lbReferencia.Text = "-";
            // 
            // lbLesoes
            // 
            this.lbLesoes.AutoSize = true;
            this.lbLesoes.Location = new System.Drawing.Point(121, 355);
            this.lbLesoes.Name = "lbLesoes";
            this.lbLesoes.Size = new System.Drawing.Size(10, 13);
            this.lbLesoes.TabIndex = 49;
            this.lbLesoes.Text = "-";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(121, 385);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(10, 13);
            this.lbData.TabIndex = 50;
            this.lbData.Text = "-";
            // 
            // lbSocorrista
            // 
            this.lbSocorrista.AutoSize = true;
            this.lbSocorrista.Location = new System.Drawing.Point(121, 415);
            this.lbSocorrista.Name = "lbSocorrista";
            this.lbSocorrista.Size = new System.Drawing.Size(10, 13);
            this.lbSocorrista.TabIndex = 51;
            this.lbSocorrista.Text = "-";
            // 
            // lbProfissao
            // 
            this.lbProfissao.AutoSize = true;
            this.lbProfissao.Location = new System.Drawing.Point(121, 445);
            this.lbProfissao.Name = "lbProfissao";
            this.lbProfissao.Size = new System.Drawing.Size(10, 13);
            this.lbProfissao.TabIndex = 52;
            this.lbProfissao.Text = "-";
            // 
            // lbVeiculos
            // 
            this.lbVeiculos.AutoSize = true;
            this.lbVeiculos.Location = new System.Drawing.Point(121, 475);
            this.lbVeiculos.Name = "lbVeiculos";
            this.lbVeiculos.Size = new System.Drawing.Size(10, 13);
            this.lbVeiculos.TabIndex = 53;
            this.lbVeiculos.Text = "-";
            // 
            // lbObservacoes
            // 
            this.lbObservacoes.AutoSize = true;
            this.lbObservacoes.Location = new System.Drawing.Point(143, 505);
            this.lbObservacoes.Name = "lbObservacoes";
            this.lbObservacoes.Size = new System.Drawing.Size(10, 13);
            this.lbObservacoes.TabIndex = 54;
            this.lbObservacoes.Text = "-";
            // 
            // lbNumerocasa
            // 
            this.lbNumerocasa.AutoSize = true;
            this.lbNumerocasa.Location = new System.Drawing.Point(436, 265);
            this.lbNumerocasa.Name = "lbNumerocasa";
            this.lbNumerocasa.Size = new System.Drawing.Size(10, 13);
            this.lbNumerocasa.TabIndex = 55;
            this.lbNumerocasa.Text = "-";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(436, 295);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(10, 13);
            this.lbCidade.TabIndex = 56;
            this.lbCidade.Text = "-";
            // 
            // lbRegistro
            // 
            this.lbRegistro.AutoSize = true;
            this.lbRegistro.Location = new System.Drawing.Point(436, 325);
            this.lbRegistro.Name = "lbRegistro";
            this.lbRegistro.Size = new System.Drawing.Size(10, 13);
            this.lbRegistro.TabIndex = 57;
            this.lbRegistro.Text = "-";
            // 
            // lbInss
            // 
            this.lbInss.AutoSize = true;
            this.lbInss.Location = new System.Drawing.Point(436, 355);
            this.lbInss.Name = "lbInss";
            this.lbInss.Size = new System.Drawing.Size(10, 13);
            this.lbInss.TabIndex = 58;
            this.lbInss.Text = "-";
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Location = new System.Drawing.Point(436, 385);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(10, 13);
            this.lbHorario.TabIndex = 59;
            this.lbHorario.Text = "-";
            // 
            // lbHospital
            // 
            this.lbHospital.AutoSize = true;
            this.lbHospital.Location = new System.Drawing.Point(437, 415);
            this.lbHospital.Name = "lbHospital";
            this.lbHospital.Size = new System.Drawing.Size(10, 13);
            this.lbHospital.TabIndex = 61;
            this.lbHospital.Text = "-";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(437, 445);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(10, 13);
            this.lbTipo.TabIndex = 62;
            this.lbTipo.Text = "-";
            // 
            // lbLocal
            // 
            this.lbLocal.AutoSize = true;
            this.lbLocal.Location = new System.Drawing.Point(436, 475);
            this.lbLocal.Name = "lbLocal";
            this.lbLocal.Size = new System.Drawing.Size(10, 13);
            this.lbLocal.TabIndex = 63;
            this.lbLocal.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbLocal);
            this.panel1.Controls.Add(this.lbTipo);
            this.panel1.Controls.Add(this.lbHospital);
            this.panel1.Controls.Add(this.lbHorario);
            this.panel1.Controls.Add(this.lbInss);
            this.panel1.Controls.Add(this.lbRegistro);
            this.panel1.Controls.Add(this.lbCidade);
            this.panel1.Controls.Add(this.lbNumerocasa);
            this.panel1.Controls.Add(this.lbObservacoes);
            this.panel1.Controls.Add(this.lbVeiculos);
            this.panel1.Controls.Add(this.lbProfissao);
            this.panel1.Controls.Add(this.lbSocorrista);
            this.panel1.Controls.Add(this.lbData);
            this.panel1.Controls.Add(this.lbLesoes);
            this.panel1.Controls.Add(this.lbReferencia);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbCPF);
            this.panel1.Controls.Add(this.lbIndicacao);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lb05);
            this.panel1.Controls.Add(this.lbBairro);
            this.panel1.Controls.Add(this.lbTelefone);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbRua);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(296, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 659);
            this.panel1.TabIndex = 29;
            // 
            // TelaListaProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1000, 668);
            this.Controls.Add(this.dgTodosOsClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btImprimirFolhaDeRosto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAlterarDados);
            this.Controls.Add(this.btBuscarProcesso);
            this.Controls.Add(this.tbBusca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaListaProcessos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Processos";
            this.Activated += new System.EventHandler(this.TelaListaProcessos_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaListaProcessos_FormClosed);
            this.Load += new System.EventHandler(this.TelaListaProcessos_Load);
            this.Shown += new System.EventHandler(this.TelaListaProcessos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgTodosOsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Button btBuscarProcesso;
        private System.Windows.Forms.Button btAlterarDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btImprimirFolhaDeRosto;
        private System.Windows.Forms.DataGridView dgTodosOsClientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lb05;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbIndicacao;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbReferencia;
        private System.Windows.Forms.Label lbLesoes;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbSocorrista;
        private System.Windows.Forms.Label lbProfissao;
        private System.Windows.Forms.Label lbVeiculos;
        private System.Windows.Forms.Label lbObservacoes;
        private System.Windows.Forms.Label lbNumerocasa;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbRegistro;
        private System.Windows.Forms.Label lbInss;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbHospital;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbLocal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_dados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_dados;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusProcesso;
    }
}