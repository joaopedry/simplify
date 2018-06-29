namespace Simplify.Grafico
{
    partial class ManterUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManterUsuario));
            this.tbNomeUsuario = new System.Windows.Forms.TextBox();
            this.tbEmailUsuario = new System.Windows.Forms.TextBox();
            this.tbLoginUsuario = new System.Windows.Forms.TextBox();
            this.tbSenhaUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btSalvarUsuario = new System.Windows.Forms.Button();
            this.btCancelarUsuario = new System.Windows.Forms.Button();
            this.tbIdUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.gbFuncao = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbFuncao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNomeUsuario
            // 
            this.tbNomeUsuario.Location = new System.Drawing.Point(102, 53);
            this.tbNomeUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomeUsuario.Name = "tbNomeUsuario";
            this.tbNomeUsuario.Size = new System.Drawing.Size(231, 20);
            this.tbNomeUsuario.TabIndex = 0;
            this.tbNomeUsuario.TextChanged += new System.EventHandler(this.tbNomeUsuario_TextChanged);
            this.tbNomeUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValidacao_Letras);
            // 
            // tbEmailUsuario
            // 
            this.tbEmailUsuario.Location = new System.Drawing.Point(102, 77);
            this.tbEmailUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmailUsuario.Name = "tbEmailUsuario";
            this.tbEmailUsuario.Size = new System.Drawing.Size(231, 20);
            this.tbEmailUsuario.TabIndex = 1;
            // 
            // tbLoginUsuario
            // 
            this.tbLoginUsuario.Location = new System.Drawing.Point(102, 100);
            this.tbLoginUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbLoginUsuario.Name = "tbLoginUsuario";
            this.tbLoginUsuario.Size = new System.Drawing.Size(231, 20);
            this.tbLoginUsuario.TabIndex = 2;
            // 
            // tbSenhaUsuario
            // 
            this.tbSenhaUsuario.Location = new System.Drawing.Point(102, 123);
            this.tbSenhaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbSenhaUsuario.Name = "tbSenhaUsuario";
            this.tbSenhaUsuario.Size = new System.Drawing.Size(231, 20);
            this.tbSenhaUsuario.TabIndex = 3;
            this.tbSenhaUsuario.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cadastrar Usuário";
            // 
            // btSalvarUsuario
            // 
            this.btSalvarUsuario.Location = new System.Drawing.Point(189, 173);
            this.btSalvarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btSalvarUsuario.Name = "btSalvarUsuario";
            this.btSalvarUsuario.Size = new System.Drawing.Size(67, 24);
            this.btSalvarUsuario.TabIndex = 9;
            this.btSalvarUsuario.Text = "Salvar";
            this.btSalvarUsuario.UseVisualStyleBackColor = true;
            this.btSalvarUsuario.Click += new System.EventHandler(this.btSalvarUsuario_Click);
            // 
            // btCancelarUsuario
            // 
            this.btCancelarUsuario.Location = new System.Drawing.Point(261, 173);
            this.btCancelarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelarUsuario.Name = "btCancelarUsuario";
            this.btCancelarUsuario.Size = new System.Drawing.Size(74, 24);
            this.btCancelarUsuario.TabIndex = 10;
            this.btCancelarUsuario.Text = "Cancelar";
            this.btCancelarUsuario.UseVisualStyleBackColor = true;
            this.btCancelarUsuario.Click += new System.EventHandler(this.btCancelarUsuario_Click);
            // 
            // tbIdUsuario
            // 
            this.tbIdUsuario.Location = new System.Drawing.Point(226, 38);
            this.tbIdUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbIdUsuario.Name = "tbIdUsuario";
            this.tbIdUsuario.Size = new System.Drawing.Size(0, 20);
            this.tbIdUsuario.TabIndex = 20;
            this.tbIdUsuario.Visible = false;
            this.tbIdUsuario.TextChanged += new System.EventHandler(this.tbMatriculaUsuario_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Função:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Checked = true;
            this.rbAdministrador.Location = new System.Drawing.Point(10, 3);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(88, 17);
            this.rbAdministrador.TabIndex = 24;
            this.rbAdministrador.TabStop = true;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Location = new System.Drawing.Point(101, 3);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(61, 17);
            this.rbUsuario.TabIndex = 25;
            this.rbUsuario.TabStop = true;
            this.rbUsuario.Text = "Usuário";
            this.rbUsuario.UseVisualStyleBackColor = true;
            // 
            // gbFuncao
            // 
            this.gbFuncao.Controls.Add(this.rbAdministrador);
            this.gbFuncao.Controls.Add(this.rbUsuario);
            this.gbFuncao.Location = new System.Drawing.Point(92, 148);
            this.gbFuncao.Name = "gbFuncao";
            this.gbFuncao.Size = new System.Drawing.Size(241, 24);
            this.gbFuncao.TabIndex = 26;
            this.gbFuncao.TabStop = false;
            // 
            // ManterUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(495, 210);
            this.Controls.Add(this.gbFuncao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbIdUsuario);
            this.Controls.Add(this.btCancelarUsuario);
            this.Controls.Add(this.btSalvarUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSenhaUsuario);
            this.Controls.Add(this.tbLoginUsuario);
            this.Controls.Add(this.tbEmailUsuario);
            this.Controls.Add(this.tbNomeUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManterUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Usuário";
            this.Load += new System.EventHandler(this.ManterUsuario_Load);
            this.Shown += new System.EventHandler(this.ManterUsuario_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbFuncao.ResumeLayout(false);
            this.gbFuncao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomeUsuario;
        private System.Windows.Forms.TextBox tbEmailUsuario;
        private System.Windows.Forms.TextBox tbLoginUsuario;
        private System.Windows.Forms.TextBox tbSenhaUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSalvarUsuario;
        private System.Windows.Forms.Button btCancelarUsuario;
        private System.Windows.Forms.TextBox tbIdUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbAdministrador;
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.GroupBox gbFuncao;
    }
}