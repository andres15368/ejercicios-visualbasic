namespace notas
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
            this.REPROBO = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.EVALUACION = new System.Windows.Forms.Button();
            this.NOTAFINAL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // REPROBO
            // 
            this.REPROBO.Location = new System.Drawing.Point(216, 12);
            this.REPROBO.Name = "REPROBO";
            this.REPROBO.Size = new System.Drawing.Size(103, 42);
            this.REPROBO.TabIndex = 0;
            this.REPROBO.Text = "CLICK";
            this.REPROBO.UseVisualStyleBackColor = true;
            this.REPROBO.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 24);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 24);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 24);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(177, 24);
            this.textBox4.TabIndex = 4;
            // 
            // EVALUACION
            // 
            this.EVALUACION.Location = new System.Drawing.Point(216, 69);
            this.EVALUACION.Name = "EVALUACION";
            this.EVALUACION.Size = new System.Drawing.Size(103, 42);
            this.EVALUACION.TabIndex = 5;
            this.EVALUACION.Text = "EVALUACION";
            this.EVALUACION.UseVisualStyleBackColor = true;
            this.EVALUACION.Visible = false;
            this.EVALUACION.Click += new System.EventHandler(this.EVALUACION_Click);
            // 
            // NOTAFINAL
            // 
            this.NOTAFINAL.Location = new System.Drawing.Point(216, 129);
            this.NOTAFINAL.Name = "NOTAFINAL";
            this.NOTAFINAL.Size = new System.Drawing.Size(103, 42);
            this.NOTAFINAL.TabIndex = 6;
            this.NOTAFINAL.Text = "OK";
            this.NOTAFINAL.UseVisualStyleBackColor = true;
            this.NOTAFINAL.Visible = false;
            this.NOTAFINAL.Click += new System.EventHandler(this.NOTAFINAL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 208);
            this.Controls.Add(this.NOTAFINAL);
            this.Controls.Add(this.EVALUACION);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.REPROBO);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "NOTAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button REPROBO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button EVALUACION;
        private System.Windows.Forms.Button NOTAFINAL;
    }
}

