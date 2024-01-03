
namespace WindowsFormsApp1
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
            this.NumeroPar = new System.Windows.Forms.GroupBox();
            this.sendPar = new System.Windows.Forms.Button();
            this.numPar = new System.Windows.Forms.TextBox();
            this.NumeroPar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumeroPar
            // 
            this.NumeroPar.Controls.Add(this.numPar);
            this.NumeroPar.Controls.Add(this.sendPar);
            this.NumeroPar.Location = new System.Drawing.Point(29, 13);
            this.NumeroPar.Name = "NumeroPar";
            this.NumeroPar.Size = new System.Drawing.Size(204, 83);
            this.NumeroPar.TabIndex = 0;
            this.NumeroPar.TabStop = false;
            this.NumeroPar.Text = "Número Par";
            this.NumeroPar.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // sendPar
            // 
            this.sendPar.Location = new System.Drawing.Point(123, 54);
            this.sendPar.Name = "sendPar";
            this.sendPar.Size = new System.Drawing.Size(75, 23);
            this.sendPar.TabIndex = 0;
            this.sendPar.Text = "send";
            this.sendPar.UseVisualStyleBackColor = true;
            this.sendPar.Click += new System.EventHandler(this.sendPar_Click);
            // 
            // numPar
            // 
            this.numPar.Location = new System.Drawing.Point(6, 54);
            this.numPar.Name = "numPar";
            this.numPar.Size = new System.Drawing.Size(100, 20);
            this.numPar.TabIndex = 1;
            this.numPar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumeroPar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NumeroPar.ResumeLayout(false);
            this.NumeroPar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NumeroPar;
        private System.Windows.Forms.TextBox numPar;
        private System.Windows.Forms.Button sendPar;
    }
}

