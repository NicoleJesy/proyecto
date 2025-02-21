using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEVALUACION2jessicahernandez
{
    public partial class Form1 : Form
    {
        // Precios por unidad
        decimal precioPupusaFrijol = 1.50m;
        decimal precioPupusaQueso = 1.75m;
        decimal precioPupusaRevuelta = 2.00m;
        decimal precioPupusaMixta = 2.25m;
        decimal precioPupusaLoroco = 2.50m;

        decimal precioAgua = 0.75m;
        decimal precioSoda = 1.00m;
        decimal precioJugoNaranja = 1.25m;

        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener cantidades ingresadas
            int cantidadFrijol = GetCantidad(txtFrijol.Text);
            int cantidadQueso = GetCantidad(txtQueso.Text);
            int cantidadRevuelta = GetCantidad(txtRevuelta.Text);
            int cantidadMixta = GetCantidad(txtMixta.Text);
            int cantidadLoroco = GetCantidad(txtLoroco.Text);

            int cantidadAgua = GetCantidad(txtAgua.Text);
            int cantidadSoda = GetCantidad(txtSoda.Text);
            int cantidadJugoNaranja = GetCantidad(txtJugoNaranja.Text);

            // Calcular subtotal
            decimal subtotalPupusas = (cantidadFrijol * precioPupusaFrijol) +
                                      (cantidadQueso * precioPupusaQueso) +
                                      (cantidadRevuelta * precioPupusaRevuelta) +
                                      (cantidadMixta * precioPupusaMixta) +
                                      (cantidadLoroco * precioPupusaLoroco);

            decimal subtotalBebidas = (cantidadAgua * precioAgua) +
                                      (cantidadSoda * precioSoda) +
                                      (cantidadJugoNaranja * precioJugoNaranja);

            // Calcular total
            decimal total = subtotalPupusas + subtotalBebidas;

            // Mostrar el total
            txtTotal.Text = total.ToString("C"); // Formatea como moneda

        }
        private int GetCantidad(string input)
        {
            if (int.TryParse(input, out int cantidad))
            {
                // Conversión exitosa, devuelve la cantidad ingresada
                return cantidad;
            }
            else
            {
                // Conversión fallida, devuelve cero
                return 0;
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void txtRevuelta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}