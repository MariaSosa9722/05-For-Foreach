using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _05_For_Foreach
{
    public class ejercicio
    {
        public void inicio()
        {

            Console.WriteLine("Cuantos numeros deseas capturar");
            int cantidad = int.Parse(Console.ReadLine());

            // declaramos los numeros en el arreglo
            int[] numeros = new int[cantidad];

            for (int i = 0; i < numeros.Length; i++) 
            {

                Console.WriteLine($"Ingresa el número {i+1} : ");
                numeros[i] = int.Parse(Console.ReadLine());
            
            }

            int sumarFor = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                sumarFor += numeros[i];
                

            }

            Console.WriteLine($"La suma en for es :"+sumarFor);
        
        }

    }
}
