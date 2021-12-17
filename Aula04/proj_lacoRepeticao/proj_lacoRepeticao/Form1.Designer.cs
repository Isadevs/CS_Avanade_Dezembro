namespace proj_lacoRepeticao
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
            this.lblTabuada = new System.Windows.Forms.TextBox();
            this.btnWhile = new System.Windows.Forms.Button();
            this.ltsTabuada = new System.Windows.Forms.ListBox();
            this.btnDo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite Um Numero:";
            // 
            // lblTabuada
            // 
            this.lblTabuada.Location = new System.Drawing.Point(46, 51);
            this.lblTabuada.Name = "lblTabuada";
            this.lblTabuada.Size = new System.Drawing.Size(209, 26);
            this.lblTabuada.TabIndex = 1;
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(46, 83);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(209, 38);
            this.btnWhile.TabIndex = 2;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            // 
            // ltsTabuada
            // 
            this.ltsTabuada.FormattingEnabled = true;
            this.ltsTabuada.ItemHeight = 20;
            this.ltsTabuada.Location = new System.Drawing.Point(46, 250);
            this.ltsTabuada.Name = "ltsTabuada";
            this.ltsTabuada.Size = new System.Drawing.Size(209, 344);
            this.ltsTabuada.TabIndex = 3;
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(46, 127);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(209, 33);
            this.btnDo.TabIndex = 4;
            this.btnDo.Text = "Do-While";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tabuada - Do";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(46, 205);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(209, 33);
            this.btnFor.TabIndex = 6;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 634);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.ltsTabuada);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.lblTabuada);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblTabuada;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.ListBox ltsTabuada;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFor;
    }
}

