using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1._1carro_6932077
{
    internal class program
    {
        

        static void Main(string[] args)
        {
            //creamos nuestro coche
            Carrodeportivo micoche = new Carrodeportivo("toyota", "4x4",100);

            //Mostrar informacion inicial
            Console.WriteLine("El modelo del carro es: "+micoche.Modelo);
            Console.WriteLine("VelocidadMaxima es: "+micoche.VelocidadActual);
            micoche.acelerar(5);
            micoche.Frenar(0);
            
            Console.ReadKey();
        }
   
            
       
    }
}
