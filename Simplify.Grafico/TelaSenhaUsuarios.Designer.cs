namespace Simplify.Grafico
{
    partial class TelaSenhaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSenhaUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser_Admin = new System.Windows.Forms.TextBox();
            this.tbSenha_admin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAcessarAjustes = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acesso Negado!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Para proseguir, informe as credenciais do administrador do sistema:";
            // 
            // tbUser_Admin
            // 
            this.tbUser_Admin.Location = new System.Drawing.Point(63, 59);
            this.tbUser_Admin.Name = "tbUser_Admin";
            this.tbUser_Admin.Size = new System.Drawing.Size(161, 20);
            this.tbUser_Admin.TabIndex = 2;
            // 
            // tbSenha_admin
            // 
            this.tbSenha_admin.Location = new System.Drawing.Point(63, 91);
            this.tbSenha_admin.Name = "tbSenha_admin";
            this.tbSenha_admin.Size = new System.Drawing.Size(161, 20);
            this.tbSenha_admin.TabIndex = 3;
            this.tbSenha_admin.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 73);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btAcessarAjustes
            // 
            this.btAcessarAjustes.Location = new System.Drawing.Point(94, 117);
            this.btAcessarAjustes.Name = "btAcessarAjustes";
            this.btAcessarAjustes.Size = new System.Drawing.Size(62, 23);
            this.btAcessarAjustes.TabIndex = 7;
            this.btAcessarAjustes.Text = "Acessar";
            this.btAcessarAjustes.UseVisualStyleBackColor = true;
            this.btAcessarAjustes.Click += new System.EventHandler(this.btAcessarAjustes_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(162, 117);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(62, 23);
            this.btSair.TabIndex = 8;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // TelaSenhaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(336, 147);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btAcessarAjustes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSenha_admin);
            this.Controls.Add(this.tbUser_Admin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaSenhaUsuarios";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TelaSenhaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUser_Admin;
        private System.Windows.Forms.TextBox tbSenha_admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAcessarAjustes;
        private System.Windows.Forms.Button btSair;
    }
}