namespace MAJONCHOSSS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CAntidadMAjonchos = new System.Windows.Forms.Label();
            this.COSTmajonchos = new System.Windows.Forms.Label();
            this.TOTALmajinchosCOSt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CAntidadMAjonchos
            // 
            this.CAntidadMAjonchos.AutoSize = true;
            this.CAntidadMAjonchos.Location = new System.Drawing.Point(161, 85);
            this.CAntidadMAjonchos.Name = "CAntidadMAjonchos";
            this.CAntidadMAjonchos.Size = new System.Drawing.Size(131, 13);
            this.CAntidadMAjonchos.TabIndex = 0;
            this.CAntidadMAjonchos.Text = "Cuantos majonchos lleva?";
            this.CAntidadMAjonchos.Click += new System.EventHandler(this.CAntidadMAjonchos_Click);
            // 
            // COSTmajonchos
            // 
            this.COSTmajonchos.AutoSize = true;
            this.COSTmajonchos.Location = new System.Drawing.Point(189, 161);
            this.COSTmajonchos.Name = "COSTmajonchos";
            this.COSTmajonchos.Size = new System.Drawing.Size(103, 13);
            this.COSTmajonchos.TabIndex = 1;
            this.COSTmajonchos.Text = "Costo de majonchos";
            // 
            // TOTALmajinchosCOSt
            // 
            this.TOTALmajinchosCOSt.AutoSize = true;
            this.TOTALmajinchosCOSt.Location = new System.Drawing.Point(189, 239);
            this.TOTALmajinchosCOSt.Name = "TOTALmajinchosCOSt";
            this.TOTALmajinchosCOSt.Size = new System.Drawing.Size(100, 13);
            this.TOTALmajinchosCOSt.TabIndex = 2;
            this.TOTALmajinchosCOSt.Text = "Total de majonchos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(336, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(336, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(336, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 66);
            this.button1.TabIndex = 6;
            this.button1.Text = "CalcularMajonchos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TOTALmajinchosCOSt);
            this.Controls.Add(this.COSTmajonchos);
            this.Controls.Add(this.CAntidadMAjonchos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CAntidadMAjonchos;
        private System.Windows.Forms.Label COSTmajonchos;
        private System.Windows.Forms.Label TOTALmajinchosCOSt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}

