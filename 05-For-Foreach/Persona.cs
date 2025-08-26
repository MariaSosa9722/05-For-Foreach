using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_For_Foreach
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void imprimirPersona()
        {
            List<Persona> lista = new List<Persona>()
            {
                new Persona {Nombre = "Majo",Edad = 25},
                new Persona {Nombre = "Jose",Edad = 26},
                new Persona {Nombre = "Fuentes",Edad = 29}
            };

            foreach (Persona persona in lista) {

                Console.WriteLine("Los datos son los siguientes:");
                Console.WriteLine($" Nombre: "+persona.Nombre);
                Console.WriteLine($" Edad: " + persona.Edad);
            }

        }
    }
}
