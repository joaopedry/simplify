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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btBuscarProcesso = new System.Windows.Forms.Button();
            this.btAlterarDados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btImprimirFolhaDeRosto = new System.Windows.Forms.Button();
            this.rbProcessoPendencia = new System.Windows.Forms.RadioButton();
            this.rbProcessoEnviado = new System.Windows.Forms.RadioButton();
            this.rbProcessoNegado = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gbStatusProcesso = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbStatusProcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(349, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btBuscarProcesso
            // 
            this.btBuscarProcesso.Location = new System.Drawing.Point(286, 41);
            this.btBuscarProcesso.Name = "btBuscarProcesso";
            this.btBuscarProcesso.Size = new System.Drawing.Size(75, 23);
            this.btBuscarProcesso.TabIndex = 2;
            this.btBuscarProcesso.Text = "Procurar";
            this.btBuscarProcesso.UseVisualStyleBackColor = true;
            // 
            // btAlterarDados
            // 
            this.btAlterarDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAlterarDados.Location = new System.Drawing.Point(233, 371);
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
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Busca por nome, CPF ou RG:";
            // 
            // btImprimirFolhaDeRosto
            // 
            this.btImprimirFolhaDeRosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btImprimirFolhaDeRosto.Location = new System.Drawing.Point(99, 371);
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
            this.label2.Location = new System.Drawing.Point(382, 378);
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
            this.gbStatusProcesso.Location = new System.Drawing.Point(484, 371);
            this.gbStatusProcesso.Name = "gbStatusProcesso";
            this.gbStatusProcesso.Size = new System.Drawing.Size(215, 33);
            this.gbStatusProcesso.TabIndex = 10;
            this.gbStatusProcesso.TabStop = false;
            // 
            // TelaListaProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(699, 401);
            this.Controls.Add(this.gbStatusProcesso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btImprimirFolhaDeRosto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAlterarDados);
            this.Controls.Add(this.btBuscarProcesso);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaListaProcessos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelaListaProcessos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbStatusProcesso.ResumeLayout(false);
            this.gbStatusProcesso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btBuscarProcesso;
        private System.Windows.Forms.Button btAlterarDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btImprimirFolhaDeRosto;
        private System.Windows.Forms.RadioButton rbProcessoPendencia;
        private System.Windows.Forms.RadioButton rbProcessoEnviado;
        private System.Windows.Forms.RadioButton rbProcessoNegado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbStatusProcesso;
    }
}