
namespace ConverteTemp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fahrenheitBtt = new System.Windows.Forms.Button();
            this.kelvinBtt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira o Valor em Celsius";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fahrenheitBtt
            // 
            this.fahrenheitBtt.Location = new System.Drawing.Point(58, 93);
            this.fahrenheitBtt.Name = "fahrenheitBtt";
            this.fahrenheitBtt.Size = new System.Drawing.Size(75, 23);
            this.fahrenheitBtt.TabIndex = 2;
            this.fahrenheitBtt.Text = "fahrenheit";
            this.fahrenheitBtt.UseVisualStyleBackColor = true;
            this.fahrenheitBtt.Click += new System.EventHandler(this.fahrenheitBtt_Click);
            // 
            // kelvinBtt
            // 
            this.kelvinBtt.Location = new System.Drawing.Point(277, 93);
            this.kelvinBtt.Name = "kelvinBtt";
            this.kelvinBtt.Size = new System.Drawing.Size(75, 23);
            this.kelvinBtt.TabIndex = 3;
            this.kelvinBtt.Text = "kelvin";
            this.kelvinBtt.UseVisualStyleBackColor = true;
            this.kelvinBtt.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 146);
            this.Controls.Add(this.kelvinBtt);
            this.Controls.Add(this.fahrenheitBtt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fahrenheitBtt;
        private System.Windows.Forms.Button kelvinBtt;
    }
}

