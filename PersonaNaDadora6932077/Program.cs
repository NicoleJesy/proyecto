using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaNaDadora6932077
{
    public class PersonaNaDadora:Persona
    {
        public PersonaNaDadora(string ojos, string altua, string peso, string sexo) : base(ojos, altura, peso, sexo,)  {
        }
    }
    public void Nadar()
    {
        //la practica de la natación hará volver al peso inical 
        Console.WriteLine("Nadando para volver al peso ideal");
        this.peso = "85";
    }

}
