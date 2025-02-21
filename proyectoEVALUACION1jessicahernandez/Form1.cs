using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEVALUACION1jessicahernandez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener las notas ingresadas (supongamos que los cuadros de texto se llaman txtTeo1, txtTeo2, etc.)
            double notaTeo1 = GetNota(txtTeo1.Text);
            double notaTeo2 = GetNota(txtTeo2.Text);
            double notaTeo3 = GetNota(txtTeo2.Text);

            double notaLab1 = GetNota(txtLab1.Text);
            double notaLab2 = GetNota(txtLab2.Text);
            double notaLab3 = GetNota(txtLab3.Text);

            // Calcular el promedio
            double promedio = (notaTeo1 + notaTeo2 + notaTeo3 + notaLab1 + notaLab2 + notaLab3) / 6.0;

            // Mostrar el promedio
            txtPromedio.Text = promedio.ToString("F2"); // Formatea con dos decimales

            // Verificar si aprobó o reprobó
            if (promedio >= 6.0)
            {
                lblResultado.Text = "¡Aprobado!";
            }
            else
            {
                lblResultado.Text = "Reprobado";
            }


        }
        private double GetNota(string input)
        {
            if (double.TryParse(input, out double nota))
            {
                // Conversión exitosa, devuelve la nota ingresada
                return nota;
            }
            else
            {
                // Conversión fallida, devuelve cero
                return 0.0;
            }
        }

        private void txtTeo1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



