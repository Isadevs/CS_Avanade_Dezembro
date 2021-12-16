namespace exProposto03
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
            this.lblNotaA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNotaB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNotaC = new System.Windows.Forms.TextBox();
            this.btnMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTA A:";
            // 
            // lblNotaA
            // 
            this.lblNotaA.Location = new System.Drawing.Point(35, 83);
            this.lblNotaA.Name = "lblNotaA";
            this.lblNotaA.Size = new System.Drawing.Size(100, 26);
            this.lblNotaA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOTA B:";
            // 
            // lblNotaB
            // 
            this.lblNotaB.Location = new System.Drawing.Point(35, 163);
            this.lblNotaB.Name = "lblNotaB";
            this.lblNotaB.Size = new System.Drawing.Size(100, 26);
            this.lblNotaB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOTA C:";
            // 
            // lblNotaC
            // 
            this.lblNotaC.Location = new System.Drawing.Point(35, 247);
            this.lblNotaC.Name = "lblNotaC";
            this.lblNotaC.Size = new System.Drawing.Size(100, 26);
            this.lblNotaC.TabIndex = 5;
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(35, 319);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(283, 46);
            this.btnMedia.TabIndex = 6;
            this.btnMedia.Text = "Resultado";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.lblNotaC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNotaB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNotaA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblNotaA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblNotaB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblNotaC;
        private System.Windows.Forms.Button btnMedia;
    }
}

