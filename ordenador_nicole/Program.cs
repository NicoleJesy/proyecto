using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenador_nicole
{
    public class Program
    {

        static void Main(string[] args)

        {
            // Crear un ordenador con valores iniciales
            ordenador miOrdenador = new ordenador("Dell", "Intel Core i7", 16, 500);

            // Mostrar información inicial
            miOrdenador.MostrarInformacion();

            // Aumentar capacidad del disco
            miOrdenador.MayorCapacidad();

            // Reducir capacidad del disco
            miOrdenador.MenorCapacidad();

            // Reducir más veces para probar la validación
            miOrdenador.MenorCapacidad();
            miOrdenador.MenorCapacidad();
            miOrdenador.MenorCapacidad();
            Console.ReadKey();
        }
    }
}
