using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Erroe, debe ingresar datos");
            }
            else
            {
                nota1 = double.Parse(textBox1.Text);
                nota2 = double.Parse(textBox2.Text);
           

                if (nota1 >10.0 || nota2 >10.0)
                {
                    MessageBox.Show("Error, las notas deben entrar entre 0 y 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (nota1 <= 2.0 && nota2 <= 2.0)
                    {
                        MessageBox.Show("Reprobo la asignatura por que sus calificaciones fueron muy bajas, NO puede recuperar", "REPROBO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else
                    {
                        if (nota1 >= 9.0 && nota2 >= 9.0)
                        {
                            MessageBox.Show("Aprobo la materia, NO tiene que presentar evaluacion final", "APROBO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Usted tiene la posibilidad de aprobar la materia, ingrese la tercera nota y Pulse el boton VERIFICAR", "", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                            textBox3.Visible = true;
                            textBox4.Visible = true;

                            textBox1.ReadOnly = true;
                            textBox2.ReadOnly = true;
                            REPROBO.Enabled = true;
                        }
                    }
                }
            }
        }

        private void EVALUACION_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3,promedio;
            nota1 = double.Parse(textBox1.Text);
            nota2 = double.Parse(textBox2.Text);

            if (textBox1.Text == "")
            {
                MessageBox.Show("Error, debe ingresar un dato");
            }
            else
            {
                nota3 = double.Parse(textBox3.Text);

                if (nota3 > 10.0)
                {
                    MessageBox.Show("Error, las notas que ingrese deben estar entre 0 y 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    promedio = (nota1 + nota2 + nota3) / 3;

                    if (promedio >= 7.0)
                    {
                        MessageBox.Show("FELICITACIONES ,usted a aprobado la materia con un promedio de: " +promedio,"FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (promedio <3.0 )
                        {
                            MessageBox.Show("Usted es muy vago y reprobo la materia con un promedio de: " + promedio , "LO SIENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Usted tiene la posibilidad de aprobar la materia presentando una EVALUACION, tiene un promedio de: " + promedio + "pero no es suficiente para aprobar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MessageBox.Show("Ingrese la nota de la evaluacion para saber si definitivamente APROBO o REPROBO la materia");

                            textBox4.Visible = true;
                            NOTAFINAL.Visible = true;
                            textBox3.ReadOnly = true;
                            EVALUACION.Enabled = false;
                        }
                    }
                }
            }

        }

        private void NOTAFINAL_Click(object sender, EventArgs e)
        {
            double evaluacion;
            if (textBox4.Text == "")
            {
                MessageBox.Show("Error, ingrese un dato");
            }
            else
            {
                evaluacion = double.Parse(textBox4.Text);

                if (evaluacion > 10.0)
                {
                    MessageBox.Show("Error, las notas que ingrese deben edtar entre 0 y 10","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (evaluacion <= 5.0)
                    {
                        MessageBox.Show("La evaluacion final no tuvo una nota suficientemente alta para que usted pudiera aprobar la materia desafortunadamente usted REPROBO");
                    }
                    else
                    {
                        MessageBox.Show("APROBO la materia", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
