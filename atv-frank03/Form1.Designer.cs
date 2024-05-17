namespace atv_frank03
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
            this.txtBoxIdade1 = new System.Windows.Forms.TextBox();
            this.txtBoxIdade2 = new System.Windows.Forms.TextBox();
            this.txtBoxIdade3 = new System.Windows.Forms.TextBox();
            this.btn_Result = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelresult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxIdade1
            // 
            this.txtBoxIdade1.Location = new System.Drawing.Point(81, 147);
            this.txtBoxIdade1.Name = "txtBoxIdade1";
            this.txtBoxIdade1.Size = new System.Drawing.Size(140, 20);
            this.txtBoxIdade1.TabIndex = 0;
            // 
            // txtBoxIdade2
            // 
            this.txtBoxIdade2.Location = new System.Drawing.Point(324, 147);
            this.txtBoxIdade2.Name = "txtBoxIdade2";
            this.txtBoxIdade2.Size = new System.Drawing.Size(140, 20);
            this.txtBoxIdade2.TabIndex = 1;
            // 
            // txtBoxIdade3
            // 
            this.txtBoxIdade3.Location = new System.Drawing.Point(584, 147);
            this.txtBoxIdade3.Name = "txtBoxIdade3";
            this.txtBoxIdade3.Size = new System.Drawing.Size(140, 20);
            this.txtBoxIdade3.TabIndex = 2;
            // 
            // btn_Result
            // 
            this.btn_Result.Location = new System.Drawing.Point(324, 230);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(140, 23);
            this.btn_Result.TabIndex = 3;
            this.btn_Result.Text = "Resultaddo ";
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Media da idade ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Derxan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "2pac";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bk";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.labelresult);
            this.panel1.Location = new System.Drawing.Point(52, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 166);
            this.panel1.TabIndex = 8;
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresult.Location = new System.Drawing.Point(304, 61);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(0, 25);
            this.labelresult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.txtBoxIdade3);
            this.Controls.Add(this.txtBoxIdade2);
            this.Controls.Add(this.txtBoxIdade1);
            this.Name = "Form1";
            this.Text = "Calculo de idades";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxIdade1;
        private System.Windows.Forms.TextBox txtBoxIdade2;
        private System.Windows.Forms.TextBox txtBoxIdade3;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelresult;
    }
}

