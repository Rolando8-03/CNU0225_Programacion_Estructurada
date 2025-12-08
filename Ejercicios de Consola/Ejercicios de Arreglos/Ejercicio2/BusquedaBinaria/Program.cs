using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aleatorio = new Random();
            List<int> lista = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                lista.Add(aleatorio.Next(1, 100));
            }

            lista.Sort();

            Console.WriteLine("Lista ordenada:");
            foreach (var n in lista)
            {
                Console.Write(n + " ");
            }

            Console.Write("\nEscriba un número para buscar: ");
            int buscado = int.Parse(Console.ReadLine());

            int izquierda = 0;
            int derecha = lista.Count - 1;
            bool encontrado = false;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;

                if (lista[medio] == buscado)
                {
                    Console.WriteLine($"El número {buscado} se encontró en la posición {medio}.");
                    encontrado = true;
                    break;
                }
                else if (lista[medio] < buscado)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    derecha = medio - 1;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"El número {buscado} no se encontró.");
            }
        }
    }
}
