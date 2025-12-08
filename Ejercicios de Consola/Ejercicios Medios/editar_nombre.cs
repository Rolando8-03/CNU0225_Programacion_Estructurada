using System;
using System.Collections.Generic;

class EditarNombre
{
    static void Main(string[] args)
    {
        List<string> nombres = new List<string> { "Ana", "Luis", "Carlos", "Maria" };

        Console.WriteLine("Lista actual:");
        MostrarLista(nombres);

        EditarPorIndice(nombres);

        Console.WriteLine("\nLista actualizada:");
        MostrarLista(nombres);

        Console.ReadKey();
    }

    // Función para mostrar la lista
    static void MostrarLista(List<string> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine($"{i}. {lista[i]}");
        }
    }

    // Función para editar un elemento por índice
    static void EditarPorIndice(List<string> lista)
    {
        int indice;
        string entrada;

        while (true)
        {
            Console.Write("\nIngrese el índice que desea editar: ");
            entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out indice))
            {
                Console.WriteLine("Error: Debe ingresar un número entero.");
                continue;
            }

            if (indice < 0 || indice >= lista.Count)
            {
                Console.WriteLine("Error: Índice fuera de rango.");
                continue;
            }

            Console.Write("Ingrese el nuevo nombre: ");
            string nuevo = Console.ReadLine();

            lista[indice] = nuevo;
            break;
        }
    }
}
