namespace TrabalhoFinalModulo10
{
    partial class CriarConta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxNome = new System.Windows.Forms.TextBox();
            this.boxNIF = new System.Windows.Forms.TextBox();
            this.boxSaldoIn = new System.Windows.Forms.TextBox();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.Salvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.boxProfissao = new System.Windows.Forms.TextBox();
            this.boxNumConta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número da Conta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo Inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Palavra-passe:";
            // 
            // boxNome
            // 
            this.boxNome.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxNome.Location = new System.Drawing.Point(318, 102);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(128, 22);
            this.boxNome.TabIndex = 5;
            // 
            // boxNIF
            // 
            this.boxNIF.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxNIF.Location = new System.Drawing.Point(318, 146);
            this.boxNIF.Name = "boxNIF";
            this.boxNIF.Size = new System.Drawing.Size(128, 22);
            this.boxNIF.TabIndex = 6;
            // 
            // boxSaldoIn
            // 
            this.boxSaldoIn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSaldoIn.Location = new System.Drawing.Point(318, 234);
            this.boxSaldoIn.Name = "boxSaldoIn";
            this.boxSaldoIn.Size = new System.Drawing.Size(128, 22);
            this.boxSaldoIn.TabIndex = 8;
            // 
            // boxPassword
            // 
            this.boxPassword.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPassword.Location = new System.Drawing.Point(318, 322);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.PasswordChar = '*';
            this.boxPassword.Size = new System.Drawing.Size(128, 22);
            this.boxPassword.TabIndex = 10;
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(305, 368);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(196, 70);
            this.Salvar.TabIndex = 11;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(315, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Profissão:";
            // 
            // boxProfissao
            // 
            this.boxProfissao.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxProfissao.Location = new System.Drawing.Point(318, 278);
            this.boxProfissao.Name = "boxProfissao";
            this.boxProfissao.Size = new System.Drawing.Size(128, 22);
            this.boxProfissao.TabIndex = 9;
            // 
            // boxNumConta
            // 
            this.boxNumConta.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxNumConta.Location = new System.Drawing.Point(318, 190);
            this.boxNumConta.Name = "boxNumConta";
            this.boxNumConta.Size = new System.Drawing.Size(128, 22);
            this.boxNumConta.TabIndex = 7;
            // 
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxProfissao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.boxSaldoIn);
            this.Controls.Add(this.boxNumConta);
            this.Controls.Add(this.boxNIF);
            this.Controls.Add(this.boxNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CriarConta";
            this.Text = "CriarConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxNome;
        private System.Windows.Forms.TextBox boxNIF;
        private System.Windows.Forms.TextBox boxSaldoIn;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxProfissao;
        private System.Windows.Forms.TextBox boxNumConta;
    }
}