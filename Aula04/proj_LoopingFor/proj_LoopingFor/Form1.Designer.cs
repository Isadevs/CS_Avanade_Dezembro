namespace proj_LoopingFor
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
            this.numA = new System.Windows.Forms.TextBox();
            this.numB = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(38, 62);
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(271, 26);
            this.numA.TabIndex = 0;
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(38, 136);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(271, 26);
            this.numB.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(38, 36);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(80, 20);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "Numero A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(38, 113);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(84, 20);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "Numero B:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Verificar a Soma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numA;
        private System.Windows.Forms.TextBox numB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button button1;
    }
}

