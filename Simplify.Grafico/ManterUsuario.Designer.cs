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
            this.SuspendLayout();
            // 
            // tbNomeUsuario
            // 
            this.tbNomeUsuario.Location = new System.Drawing.Point(85, 76);
            this.tbNomeUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNomeUsuario.Name = "tbNomeUsuario";
            this.tbNomeUsuario.Size = new System.Drawing.Size(319, 22);
            this.tbNomeUsuario.TabIndex = 0;
            // 
            // tbEmailUsuario
            // 
            this.tbEmailUsuario.Location = new System.Drawing.Point(85, 103);
            this.tbEmailUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmailUsuario.Name = "tbEmailUsuario";
            this.tbEmailUsuario.Size = new System.Drawing.Size(319, 22);
            this.tbEmailUsuario.TabIndex = 1;
            // 
            // tbLoginUsuario
            // 
            this.tbLoginUsuario.Location = new System.Drawing.Point(85, 132);
            this.tbLoginUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLoginUsuario.Name = "tbLoginUsuario";
            this.tbLoginUsuario.Size = new System.Drawing.Size(319, 22);
            this.tbLoginUsuario.TabIndex = 2;
            // 
            // tbSenhaUsuario
            // 
            this.tbSenhaUsuario.Location = new System.Drawing.Point(85, 160);
            this.tbSenhaUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSenhaUsuario.Name = "tbSenhaUsuario";
            this.tbSenhaUsuario.Size = new System.Drawing.Size(319, 22);
            this.tbSenhaUsuario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cadastrar Usuário";
            // 
            // btSalvarUsuario
            // 
            this.btSalvarUsuario.Location = new System.Drawing.Point(211, 208);
            this.btSalvarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalvarUsuario.Name = "btSalvarUsuario";
            this.btSalvarUsuario.Size = new System.Drawing.Size(89, 30);
            this.btSalvarUsuario.TabIndex = 9;
            this.btSalvarUsuario.Text = "Salvar";
            this.btSalvarUsuario.UseVisualStyleBackColor = true;
            this.btSalvarUsuario.Click += new System.EventHandler(this.btSalvarUsuario_Click);
            // 
            // btCancelarUsuario
            // 
            this.btCancelarUsuario.Location = new System.Drawing.Point(307, 208);
            this.btCancelarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancelarUsuario.Name = "btCancelarUsuario";
            this.btCancelarUsuario.Size = new System.Drawing.Size(99, 30);
            this.btCancelarUsuario.TabIndex = 10;
            this.btCancelarUsuario.Text = "Cancelar";
            this.btCancelarUsuario.UseVisualStyleBackColor = true;
            // 
            // ManterUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(435, 249);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(453, 296);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(453, 296);
            this.Name = "ManterUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
    }
}