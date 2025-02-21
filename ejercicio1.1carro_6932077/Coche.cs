using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1._1carro_6932077
{
    public  class Coche
    {
       
            //propiedades del coche

            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int VelocidadMaxima { get; set; }
            public int VelocidadActual { get; set; }
              

        //contructor

        public Coche(string marca, string modelo, int VelocidadMaxima)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.VelocidadMaxima = VelocidadMaxima;
            this.VelocidadActual = 0; //comenzaremos desde velocidad 0
        }

        //empezaremos aumentando la velocidad de 0 a 5 y asi en 5
        public void acelerar(int velocidad)
        {
            
            velocidad += 5;
            Console.WriteLine("aceleramos velocidad actual:  "+velocidad);
        }

        public void Decelerar(int velocidad)
        {

            velocidad -= 5;
            Console.WriteLine("aceleramos velocidad actual:  " + velocidad);
        }

    }
}
