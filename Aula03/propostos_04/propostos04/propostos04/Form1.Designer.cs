namespace propostos04
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNotaA = new System.Windows.Forms.TextBox();
            this.lblNotaA = new System.Windows.Forms.Label();
            this.lblNotaB = new System.Windows.Forms.Label();
            this.txtNotaB = new System.Windows.Forms.TextBox();
            this.lblAulasDadas = new System.Windows.Forms.Label();
            this.txtAulasDadas = new System.Windows.Forms.TextBox();
            this.txtAulasAssistidas = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Verificar Nota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt);
            this.groupBox1.Controls.Add(this.txtAulasAssistidas);
            this.groupBox1.Controls.Add(this.txtAulasDadas);
            this.groupBox1.Controls.Add(this.lblAulasDadas);
            this.groupBox1.Controls.Add(this.txtNotaB);
            this.groupBox1.Controls.Add(this.lblNotaB);
            this.groupBox1.Controls.Add(this.lblNotaA);
            this.groupBox1.Controls.Add(this.txtNotaA);
            this.groupBox1.Location = new System.Drawing.Point(37, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 253);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtNotaA
            // 
            this.txtNotaA.Location = new System.Drawing.Point(49, 53);
            this.txtNotaA.Name = "txtNotaA";
            this.txtNotaA.Size = new System.Drawing.Size(100, 26);
            this.txtNotaA.TabIndex = 0;
            // 
            // lblNotaA
            // 
            this.lblNotaA.AutoSize = true;
            this.lblNotaA.Location = new System.Drawing.Point(67, 26);
            this.lblNotaA.Name = "lblNotaA";
            this.lblNotaA.Size = new System.Drawing.Size(62, 20);
            this.lblNotaA.TabIndex = 1;
            this.lblNotaA.Text = "Nota A:";
            // 
            // lblNotaB
            // 
            this.lblNotaB.AutoSize = true;
            this.lblNotaB.Location = new System.Drawing.Point(198, 26);
            this.lblNotaB.Name = "lblNotaB";
            this.lblNotaB.Size = new System.Drawing.Size(62, 20);
            this.lblNotaB.TabIndex = 2;
            this.lblNotaB.Text = "Nota B:";
            // 
            // txtNotaB
            // 
            this.txtNotaB.Location = new System.Drawing.Point(182, 53);
            this.txtNotaB.Name = "txtNotaB";
            this.txtNotaB.Size = new System.Drawing.Size(100, 26);
            this.txtNotaB.TabIndex = 3;
            // 
            // lblAulasDadas
            // 
            this.lblAulasDadas.AutoSize = true;
            this.lblAulasDadas.Location = new System.Drawing.Point(112, 107);
            this.lblAulasDadas.Name = "lblAulasDadas";
            this.lblAulasDadas.Size = new System.Drawing.Size(104, 20);
            this.lblAulasDadas.TabIndex = 4;
            this.lblAulasDadas.Text = "Aulas Dadas:";
            // 
            // txtAulasDadas
            // 
            this.txtAulasDadas.Location = new System.Drawing.Point(53, 130);
            this.txtAulasDadas.Name = "txtAulasDadas";
            this.txtAulasDadas.Size = new System.Drawing.Size(229, 26);
            this.txtAulasDadas.TabIndex = 5;
            // 
            // txtAulasAssistidas
            // 
            this.txtAulasAssistidas.Location = new System.Drawing.Point(53, 209);
            this.txtAulasAssistidas.Name = "txtAulasAssistidas";
            this.txtAulasAssistidas.Size = new System.Drawing.Size(229, 26);
            this.txtAulasAssistidas.TabIndex = 6;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(112, 186);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(129, 20);
            this.txt.TabIndex = 7;
            this.txt.Text = "Aulas Assistidas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txtAulasAssistidas;
        private System.Windows.Forms.TextBox txtAulasDadas;
        private System.Windows.Forms.Label lblAulasDadas;
        private System.Windows.Forms.TextBox txtNotaB;
        private System.Windows.Forms.Label lblNotaB;
        private System.Windows.Forms.Label lblNotaA;
        private System.Windows.Forms.TextBox txtNotaA;
    }
}

