namespace triangulo
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
            this.Triângulos = new System.Windows.Forms.GroupBox();
            this.lblX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.TextBox();
            this.lblZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Triângulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Triângulos
            // 
            this.Triângulos.Controls.Add(this.label3);
            this.Triângulos.Controls.Add(this.label2);
            this.Triângulos.Controls.Add(this.label1);
            this.Triângulos.Controls.Add(this.lblZ);
            this.Triângulos.Controls.Add(this.lblY);
            this.Triângulos.Controls.Add(this.lblX);
            this.Triângulos.Location = new System.Drawing.Point(58, 39);
            this.Triângulos.Name = "Triângulos";
            this.Triângulos.Size = new System.Drawing.Size(288, 265);
            this.Triângulos.TabIndex = 0;
            this.Triângulos.TabStop = false;
            this.Triângulos.Text = "Triângulos:";
            // 
            // lblX
            // 
            this.lblX.Location = new System.Drawing.Point(6, 67);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(274, 26);
            this.lblX.TabIndex = 0;
            // 
            // lblY
            // 
            this.lblY.Location = new System.Drawing.Point(7, 139);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(274, 26);
            this.lblY.TabIndex = 1;
            // 
            // lblZ
            // 
            this.lblZ.Location = new System.Drawing.Point(7, 216);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(274, 26);
            this.lblZ.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lado X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lado Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lado Z:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Triângulos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Triângulos.ResumeLayout(false);
            this.Triângulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Triângulos;
        private System.Windows.Forms.TextBox lblX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblZ;
        private System.Windows.Forms.TextBox lblY;
        private System.Windows.Forms.Button button1;
    }
}

