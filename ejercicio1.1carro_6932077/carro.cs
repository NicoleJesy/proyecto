using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1._1carro_6932077
{
    public  class carro
    {
        //propiedades del coche

        public string Marca { get; set; }
        public string Modelo { get; set;}
        public int VelocidadMaxima { get; set; } 
        public int VelocidadActual { get; set; }

    }

    //contructor

    public carro (string marca, string modelo, int VelocidadMaxima)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.VelocidadMaxima = VelocidadMaxima;
        this.VelocidadActual = 0; //comenzaremos desde velocidad 0
    }

    //empezaremos aumentando la velocidad de 0 a 5 y asi en 5
     public void acelerar()
    {
        if(VelocidadActual +5 <= VelocidadMaxima)
        {
            Velocidad += 5;
            Console.WriteLine("aceleramos velocidad actual: {VelocidadActual}km/h");
        }
        else
        {
            VelocidadActual = VelocidadMaxima;
            Console.writeline("Velocidad maxima que emos alcanzado: {VelocidadMaxima}km/h");
        }
        //metodo para desacelerar nuestro auto
        public void Declarar()
        {
            if(VelocidadActual -5>=0)
            {
                VelocidadActual -= 5;
                Console.WriteLine(Decelerando velocidad actual: { VelocidadActual} km/h);
            }
            else
            {
                VelocidadActual = 0;
                Console.WriteLine("el coche esta detenido");
            }

            Console.readLine();
        }
     }
}
