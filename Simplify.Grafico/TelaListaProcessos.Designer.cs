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
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.btBuscarProcesso = new System.Windows.Forms.Button();
            this.btAlterarDados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btImprimirFolhaDeRosto = new System.Windows.Forms.Button();
            this.rbProcessoPendencia = new System.Windows.Forms.RadioButton();
            this.rbProcessoEnviado = new System.Windows.Forms.RadioButton();
            this.rbProcessoNegado = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gbStatusProcesso = new System.Windows.Forms.GroupBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb05 = new System.Windows.Forms.Label();
            this.lbIndicacao = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.gbStatusProcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(109, 11);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(200, 20);
            this.tbBusca.TabIndex = 1;
            this.tbBusca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btBuscarProcesso
            // 
            this.btBuscarProcesso.Location = new System.Drawing.Point(233, 40);
            this.btBuscarProcesso.Name = "btBuscarProcesso";
            this.btBuscarProcesso.Size = new System.Drawing.Size(75, 23);
            this.btBuscarProcesso.TabIndex = 2;
            this.btBuscarProcesso.Text = "Procurar";
            this.btBuscarProcesso.UseVisualStyleBackColor = true;
            this.btBuscarProcesso.Click += new System.EventHandler(this.btBuscarProcesso_Click);
            // 
            // btAlterarDados
            // 
            this.btAlterarDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAlterarDados.Location = new System.Drawing.Point(233, 440);
            this.btAlterarDados.Name = "btAlterarDados";
            this.btAlterarDados.Size = new System.Drawing.Size(129, 23);
            this.btAlterarDados.TabIndex = 3;
            this.btAlterarDados.Text = "Alterar dados cadastrais";
            this.btAlterarDados.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Busca por CPF:";
            // 
            // btImprimirFolhaDeRosto
            // 
            this.btImprimirFolhaDeRosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btImprimirFolhaDeRosto.Location = new System.Drawing.Point(99, 440);
            this.btImprimirFolhaDeRosto.Name = "btImprimirFolhaDeRosto";
            this.btImprimirFolhaDeRosto.Size = new System.Drawing.Size(128, 23);
            this.btImprimirFolhaDeRosto.TabIndex = 5;
            this.btImprimirFolhaDeRosto.Text = "Imprimir folha de rosto";
            this.btImprimirFolhaDeRosto.UseVisualStyleBackColor = true;
            // 
            // rbProcessoPendencia
            // 
            this.rbProcessoPendencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbProcessoPendencia.AutoSize = true;
            this.rbProcessoPendencia.Checked = true;
            this.rbProcessoPendencia.Location = new System.Drawing.Point(8, 5);
            this.rbProcessoPendencia.Name = "rbProcessoPendencia";
            this.rbProcessoPendencia.Size = new System.Drawing.Size(71, 17);
            this.rbProcessoPendencia.TabIndex = 6;
            this.rbProcessoPendencia.TabStop = true;
            this.rbProcessoPendencia.Text = "Pendente";
            this.rbProcessoPendencia.UseVisualStyleBackColor = true;
            // 
            // rbProcessoEnviado
            // 
            this.rbProcessoEnviado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbProcessoEnviado.AutoSize = true;
            this.rbProcessoEnviado.Location = new System.Drawing.Point(84, 5);
            this.rbProcessoEnviado.Name = "rbProcessoEnviado";
            this.rbProcessoEnviado.Size = new System.Drawing.Size(64, 17);
            this.rbProcessoEnviado.TabIndex = 7;
            this.rbProcessoEnviado.TabStop = true;
            this.rbProcessoEnviado.Text = "Enviado";
            this.rbProcessoEnviado.UseVisualStyleBackColor = true;
            // 
            // rbProcessoNegado
            // 
            this.rbProcessoNegado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbProcessoNegado.AutoSize = true;
            this.rbProcessoNegado.Location = new System.Drawing.Point(154, 5);
            this.rbProcessoNegado.Name = "rbProcessoNegado";
            this.rbProcessoNegado.Size = new System.Drawing.Size(63, 17);
            this.rbProcessoNegado.TabIndex = 8;
            this.rbProcessoNegado.TabStop = true;
            this.rbProcessoNegado.Text = "Negado";
            this.rbProcessoNegado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Status do Processo:";
            // 
            // gbStatusProcesso
            // 
            this.gbStatusProcesso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbStatusProcesso.BackColor = System.Drawing.Color.Transparent;
            this.gbStatusProcesso.Controls.Add(this.rbProcessoEnviado);
            this.gbStatusProcesso.Controls.Add(this.rbProcessoPendencia);
            this.gbStatusProcesso.Controls.Add(this.rbProcessoNegado);
            this.gbStatusProcesso.Location = new System.Drawing.Point(484, 440);
            this.gbStatusProcesso.Name = "gbStatusProcesso";
            this.gbStatusProcesso.Size = new System.Drawing.Size(215, 33);
            this.gbStatusProcesso.TabIndex = 10;
            this.gbStatusProcesso.TabStop = false;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(77, 80);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(10, 13);
            this.lbNome.TabIndex = 15;
            this.lbNome.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nome:";
            // 
            // lb05
            // 
            this.lb05.AutoSize = true;
            this.lb05.Location = new System.Drawing.Point(9, 105);
            this.lb05.Name = "lb05";
            this.lb05.Size = new System.Drawing.Size(54, 13);
            this.lb05.TabIndex = 18;
            this.lb05.Text = "Indicação";
            // 
            // lbIndicacao
            // 
            this.lbIndicacao.AutoSize = true;
            this.lbIndicacao.Location = new System.Drawing.Point(77, 105);
            this.lbIndicacao.Name = "lbIndicacao";
            this.lbIndicacao.Size = new System.Drawing.Size(10, 13);
            this.lbIndicacao.TabIndex = 17;
            this.lbIndicacao.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Telefone:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(77, 131);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(10, 13);
            this.lbTelefone.TabIndex = 19;
            this.lbTelefone.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Email:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(77, 158);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(10, 13);
            this.lbEmail.TabIndex = 21;
            this.lbEmail.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Endereço:";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(77, 180);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(10, 13);
            this.lbEndereco.TabIndex = 23;
            this.lbEndereco.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Bairro:";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(77, 206);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(10, 13);
            this.lbBairro.TabIndex = 25;
            this.lbBairro.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "CPF:";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(80, 50);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(10, 13);
            this.lbCPF.TabIndex = 27;
            this.lbCPF.Text = "-";
            // 
            // TelaListaProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(730, 470);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lb05);
            this.Controls.Add(this.lbIndicacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.gbStatusProcesso);
            this.Controls.Add(this.label2);
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
            this.Text = "TelaListaProcessos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaListaProcessos_Load);
            this.Shown += new System.EventHandler(this.TelaListaProcessos_Shown);
            this.gbStatusProcesso.ResumeLayout(false);
            this.gbStatusProcesso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Button btBuscarProcesso;
        private System.Windows.Forms.Button btAlterarDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btImprimirFolhaDeRosto;
        private System.Windows.Forms.RadioButton rbProcessoPendencia;
        private System.Windows.Forms.RadioButton rbProcessoEnviado;
        private System.Windows.Forms.RadioButton rbProcessoNegado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbStatusProcesso;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb05;
        private System.Windows.Forms.Label lbIndicacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCPF;
    }
}