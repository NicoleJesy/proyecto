using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1._1carro_6932077
{
    public class Carrodeportivo : Coche
    {

        // construimos la clase heredera para el carro
        public Carrodeportivo(string marca, string modelo, int Velocidad) : base(marca, modelo, Velocidad) { }

        public void Frenar(int velocidad)
        {

            velocidad = 0;
            Console.WriteLine("Frenamos y la  velocidad actual es:  " + velocidad);
        }

    }
}
