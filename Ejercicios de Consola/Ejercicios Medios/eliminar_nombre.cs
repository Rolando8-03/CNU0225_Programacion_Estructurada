using System;
using System.Collections.Generic;

class EliminarNombrePorIndice
{
    static void Main(string[] args)
    {
        List<string> nombres = LeerNombres();
        EliminarPorIndice(nombres);

        Console.WriteLine("\nLista final:");
        foreach (var n in nombres)
        {
            Console.WriteLine(n);
        }

        Console.ReadKey();
    }

    // Función para leer nombres
    static List<string> LeerNombres()
    {
        List<string> lista = new List<string>();
        int cantidad;

        while (true)
        {
            Console.Write("¿Cuántos nombres desea ingresar?: ");
            if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad > 0)
                break;

            Console.WriteLine("Ingrese un número válido mayor que cero.\n");
        }

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Nombre {i}: ");
            lista.Add(Console.ReadLine());
        }

        return lista;
    }

    // Función para eliminar un nombre por índice
    static void EliminarPorIndice(List<string> nombres)
    {
        int indice;

        while (true)
        {
            Console.Write("\nIngrese el índice del nombre a eliminar: ");

            if (int.TryParse(Console.ReadLine(), out indice) &&
                indice >= 0 && indice < nombres.Count)
            {
                nombres.RemoveAt(indice);
                Console.WriteLine("Nombre eliminado correctamente.");
                break;
            }

            Console.WriteLine("Índice inválido. Intente nuevamente.\n");
        }
    }
}
