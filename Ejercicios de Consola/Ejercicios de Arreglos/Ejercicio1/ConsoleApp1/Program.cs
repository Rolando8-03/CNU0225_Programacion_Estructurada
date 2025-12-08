using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void BuscarNumeroEnLista() 
        {

        
        }
        static void Main(string[] args)
        {
            var rand = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i <= 20; i++)
            {
                numbers.Add(rand.Next(1, 100));
            }
            Console.Write("Escriba un número para buscar en la lista: ");
            int numeroBuscado = int.Parse(Console.ReadLine());
            foreach (var numero in numbers)
            {
                if (numero == numeroBuscado)
                {
                    
                    Console.WriteLine($"El número {numeroBuscado} se encontró en la lista.");
                }
                else
                {
                    Console.WriteLine($"El número {numeroBuscado} no se encontró en la lista.");
                }
            }

        }
    }
}
