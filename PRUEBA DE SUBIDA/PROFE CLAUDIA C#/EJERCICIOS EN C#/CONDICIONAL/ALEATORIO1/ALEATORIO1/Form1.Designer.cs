namespace ALEATORIO1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NUMERO = new System.Windows.Forms.TextBox();
            this.ADIVINAR = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NUMERO
            // 
            this.NUMERO.Location = new System.Drawing.Point(46, 33);
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.Size = new System.Drawing.Size(206, 20);
            this.NUMERO.TabIndex = 0;
            this.NUMERO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ADIVINAR
            // 
            this.ADIVINAR.Location = new System.Drawing.Point(46, 107);
            this.ADIVINAR.Name = "ADIVINAR";
            this.ADIVINAR.Size = new System.Drawing.Size(206, 20);
            this.ADIVINAR.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ADIVINAR);
            this.Controls.Add(this.NUMERO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NUMERO;
        private System.Windows.Forms.TextBox ADIVINAR;
        private System.Windows.Forms.Button button1;
    }
}

