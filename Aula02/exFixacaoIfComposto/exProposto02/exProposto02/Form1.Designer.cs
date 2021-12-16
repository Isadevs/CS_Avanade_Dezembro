namespace exProposto02
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoacao = new System.Windows.Forms.TextBox();
            this.btnInvestimento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da Doação";
            // 
            // txtDoacao
            // 
            this.txtDoacao.Location = new System.Drawing.Point(178, 23);
            this.txtDoacao.Name = "txtDoacao";
            this.txtDoacao.Size = new System.Drawing.Size(119, 26);
            this.txtDoacao.TabIndex = 1;
            // 
            // btnInvestimento
            // 
            this.btnInvestimento.Location = new System.Drawing.Point(37, 91);
            this.btnInvestimento.Name = "btnInvestimento";
            this.btnInvestimento.Size = new System.Drawing.Size(260, 44);
            this.btnInvestimento.TabIndex = 2;
            this.btnInvestimento.Text = "Calcular Investimento";
            this.btnInvestimento.UseVisualStyleBackColor = true;
            this.btnInvestimento.Click += new System.EventHandler(this.btnInvestimento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.btnInvestimento);
            this.Controls.Add(this.txtDoacao);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoacao;
        private System.Windows.Forms.Button btnInvestimento;
    }
}

