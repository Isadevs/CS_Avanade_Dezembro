namespace exProp01
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
            this.lblDoacao = new System.Windows.Forms.Label();
            this.txtValDolar = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnConversor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDoacao
            // 
            this.lblDoacao.AutoSize = true;
            this.lblDoacao.Location = new System.Drawing.Point(172, 98);
            this.lblDoacao.Name = "lblDoacao";
            this.lblDoacao.Size = new System.Drawing.Size(178, 20);
            this.lblDoacao.TabIndex = 1;
            this.lblDoacao.Text = "Valor Doação em Dolar:";
            // 
            // txtValDolar
            // 
            this.txtValDolar.Location = new System.Drawing.Point(164, 133);
            this.txtValDolar.Name = "txtValDolar";
            this.txtValDolar.Size = new System.Drawing.Size(186, 26);
            this.txtValDolar.TabIndex = 2;
            this.txtValDolar.TextChanged += new System.EventHandler(this.txtValDolar_TextChanged);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(195, 303);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(108, 20);
            this.lblRes.TabIndex = 3;
            this.lblRes.Text = "RESULTADO";
            // 
            // btnConversor
            // 
            this.btnConversor.Location = new System.Drawing.Point(176, 202);
            this.btnConversor.Name = "btnConversor";
            this.btnConversor.Size = new System.Drawing.Size(161, 66);
            this.btnConversor.TabIndex = 5;
            this.btnConversor.Text = "Conversor";
            this.btnConversor.UseVisualStyleBackColor = true;
            this.btnConversor.Click += new System.EventHandler(this.btnConversor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cotação do Dolar: $USD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "5.62";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConversor);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtValDolar);
            this.Controls.Add(this.lblDoacao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoacao;
        private System.Windows.Forms.TextBox txtValDolar;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnConversor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

