using System;

namespace BusquedaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aleatorio = new Random();
            int[,] matriz = new int[10, 10];

            Console.WriteLine("Matriz generada:\n");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = aleatorio.Next(1, 50);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("\nIngrese el número a buscar: ");
            int buscado = int.Parse(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i, j] == buscado)
                    {
                        Console.WriteLine($"Número encontrado en posición ({i}, {j})");
                        encontrado = true;
                    }
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("El número no se encontró en la matriz.");
            }
        }
    }
}
