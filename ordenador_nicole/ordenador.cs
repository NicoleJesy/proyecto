using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenador_nicole
{
      public class ordenador
    {


        // Propiedades del ordenador
        public string Marca { get; set; }
        public string Procesador { get; set; }
        public int Memoria { get; set; } // en GB
        public int DiscoDuro { get; set; } // en GB

        // Constructor
        public ordenador(string marca, string procesador, int memoria, int discoDuro)
        {
            this.Marca = marca;
            this.Procesador = procesador;
            this.Memoria = memoria;
            this.DiscoDuro = discoDuro;
        }

        // Método para aumentar la capacidad del disco en 100GB
        public void MayorCapacidad()
        {
            DiscoDuro += 100;
            Console.WriteLine($"Capacidad aumentada. Nuevo tamaño del disco duro: {DiscoDuro} GB");
        }

        // Método para reducir la capacidad del disco en 100GB (sin permitir valores negativos)
        public void MenorCapacidad()
        {
            if (DiscoDuro >= 100)
            {
                DiscoDuro -= 100;
                Console.WriteLine($"Capacidad reducida. Nuevo tamaño del disco duro: {DiscoDuro} GB");
            }
            else
            {
                Console.WriteLine("No se puede reducir más la capacidad del disco duro.");
            }
        }

        // Método para mostrar la información del ordenador
        public void MostrarInformacion()
        {
            Console.WriteLine("\nInformación del Ordenador:");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Procesador: {Procesador}");
            Console.WriteLine($"Memoria RAM: {Memoria} GB");
            Console.WriteLine($"Disco Duro: {DiscoDuro} GB");
            Console.ReadKey();
        }
    }
}

