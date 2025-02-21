namespace majonchitosnico
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
            this.CantidadMajonchos = new System.Windows.Forms.Label();
            this.majonchoCost = new System.Windows.Forms.Label();
            this.TotalMajonchoCost = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CantidadMajonchos
            // 
            this.CantidadMajonchos.AutoSize = true;
            this.CantidadMajonchos.Location = new System.Drawing.Point(200, 118);
            this.CantidadMajonchos.Name = "CantidadMajonchos";
            this.CantidadMajonchos.Size = new System.Drawing.Size(125, 13);
            this.CantidadMajonchos.TabIndex = 0;
            this.CantidadMajonchos.Text = "Cuantos majonchos lleva";
            // 
            // majonchoCost
            // 
            this.majonchoCost.AutoSize = true;
            this.majonchoCost.Location = new System.Drawing.Point(203, 190);
            this.majonchoCost.Name = "majonchoCost";
            this.majonchoCost.Size = new System.Drawing.Size(103, 13);
            this.majonchoCost.TabIndex = 1;
            this.majonchoCost.Text = "Costo de majonchos";
            // 
            // TotalMajonchoCost
            // 
            this.TotalMajonchoCost.AutoSize = true;
            this.TotalMajonchoCost.Location = new System.Drawing.Point(206, 279);
            this.TotalMajonchoCost.Name = "TotalMajonchoCost";
            this.TotalMajonchoCost.Size = new System.Drawing.Size(61, 13);
            this.TotalMajonchoCost.TabIndex = 2;
            this.TotalMajonchoCost.Text = "Costo Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(402, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(411, 271);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular Total";
            this.button1.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.TotalMajonchoCost);
            this.Controls.Add(this.majonchoCost);
            this.Controls.Add(this.CantidadMajonchos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CantidadMajonchos;
        private System.Windows.Forms.Label majonchoCost;
        private System.Windows.Forms.Label TotalMajonchoCost;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}

