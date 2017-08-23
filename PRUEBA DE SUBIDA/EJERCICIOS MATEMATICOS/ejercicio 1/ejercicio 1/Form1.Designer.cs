namespace ejercicio_1
{
    partial class EJERCICIO1
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
            this.txtoperador1 = new System.Windows.Forms.TextBox();
            this.txtoperador2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.operador1 = new System.Windows.Forms.Label();
            this.operador2 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtoperador1
            // 
            this.txtoperador1.Location = new System.Drawing.Point(136, 49);
            this.txtoperador1.Name = "txtoperador1";
            this.txtoperador1.Size = new System.Drawing.Size(100, 20);
            this.txtoperador1.TabIndex = 0;
            // 
            // txtoperador2
            // 
            this.txtoperador2.Location = new System.Drawing.Point(136, 92);
            this.txtoperador2.Name = "txtoperador2";
            this.txtoperador2.Size = new System.Drawing.Size(100, 20);
            this.txtoperador2.TabIndex = 1;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(136, 144);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // operador1
            // 
            this.operador1.AutoSize = true;
            this.operador1.Location = new System.Drawing.Point(13, 55);
            this.operador1.Name = "operador1";
            this.operador1.Size = new System.Drawing.Size(55, 13);
            this.operador1.TabIndex = 4;
            this.operador1.Text = "operador1";
            // 
            // operador2
            // 
            this.operador2.AutoSize = true;
            this.operador2.Location = new System.Drawing.Point(13, 98);
            this.operador2.Name = "operador2";
            this.operador2.Size = new System.Drawing.Size(55, 13);
            this.operador2.TabIndex = 5;
            this.operador2.Text = "operador2";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(16, 150);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(50, 13);
            this.resultado.TabIndex = 6;
            this.resultado.Text = "resultado";
            // 
            // EJERCICIO1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.operador2);
            this.Controls.Add(this.operador1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtoperador2);
            this.Controls.Add(this.txtoperador1);
            this.Name = "EJERCICIO1";
            this.Text = "EJERCICIO1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtoperador1;
        private System.Windows.Forms.TextBox txtoperador2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label operador1;
        private System.Windows.Forms.Label operador2;
        private System.Windows.Forms.Label resultado;
    }
}

