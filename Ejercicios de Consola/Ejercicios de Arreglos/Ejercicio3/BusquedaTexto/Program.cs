using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un párrafo:");
            string texto = Console.ReadLine().ToLower();

            Console.Write("Escriba la palabra a buscar: ");
            string palabra = Console.ReadLine().ToLower();

            int contador = 0;

            for (int i = 0; i < texto.Length - palabra.Length + 1; i++)
            {
                bool coincide = true;

                for (int j = 0; j < palabra.Length; j++)
                {
                    if (texto[i + j] != palabra[j])
                    {
                        coincide = false;
                        break;
                    }
                }

                if (coincide)
                {
                    contador++;
                }
            }

            Console.WriteLine($"La palabra \"{palabra}\" aparece {contador} veces.");
        }
    }
}
