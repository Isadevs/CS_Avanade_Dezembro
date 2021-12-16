namespace exProposto04
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtSaldoMedio = new System.Windows.Forms.TextBox();
            this.btnCredito = new System.Windows.Forms.Button();
            this.lblCredito = new System.Windows.Forms.Label();
            this.lblcred = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtSaldoMedio);
            this.groupBox1.Location = new System.Drawing.Point(74, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saldo Medio";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 26);
            this.textBox2.TabIndex = 1;
            // 
            // txtSaldoMedio
            // 
            this.txtSaldoMedio.Location = new System.Drawing.Point(17, 26);
            this.txtSaldoMedio.Name = "txtSaldoMedio";
            this.txtSaldoMedio.Size = new System.Drawing.Size(146, 26);
            this.txtSaldoMedio.TabIndex = 0;
            // 
            // btnCredito
            // 
            this.btnCredito.Location = new System.Drawing.Point(40, 176);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(319, 64);
            this.btnCredito.TabIndex = 3;
            this.btnCredito.Text = "Ver Crédito";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(49, 301);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(0, 20);
            this.lblCredito.TabIndex = 4;
            // 
            // lblcred
            // 
            this.lblcred.AutoSize = true;
            this.lblcred.Location = new System.Drawing.Point(40, 278);
            this.lblcred.Name = "lblcred";
            this.lblcred.Size = new System.Drawing.Size(112, 20);
            this.lblcred.TabIndex = 5;
            this.lblcred.Text = "RESULTADO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.lblcred);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtSaldoMedio;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label lblcred;
    }
}

