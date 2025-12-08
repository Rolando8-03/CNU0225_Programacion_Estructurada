using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> productos = IngresarProductos();   // Función para ingresar productos
        Dictionary<string, int> duplicados = DetectarDuplicados(productos); // Detectar duplicados
        MostrarDuplicados(duplicados);                 // Mostrar duplicados

        Console.Write("¿Desea depurar los duplicados? (s/n): ");
        string respuesta = Console.ReadLine();
        if (respuesta.ToLower() == "s")
        {
            productos = DepurarDuplicados(productos); // Eliminar duplicados
            Console.WriteLine("\nLista depurada:");
            foreach (string p in productos)
            {
                Console.WriteLine(p);
            }
        }
    }

    // Función para ingresar productos
    static List<string> IngresarProductos()
    {
        List<string> lista = new List<string>();
        Console.WriteLine("Ingrese productos (digite 'fin' para terminar):");
        while (true)
        {
            string nombre = Console.ReadLine();
            if (nombre.ToLower() == "fin") break;
            lista.Add(nombre);
        }
        return lista;
    }

    // Función que detecta duplicados
    static Dictionary<string, int> DetectarDuplicados(List<string> productos)
    {
        Dictionary<string, int> conteo = new Dictionary<string, int>();
        foreach (string p in productos)
        {
            if (conteo.ContainsKey(p))
                conteo[p]++;
            else
                conteo[p] = 1;
        }

        // Filtrar solo los duplicados
        Dictionary<string, int> duplicados = new Dictionary<string, int>();
        foreach (var item in conteo)
        {
            if (item.Value > 1)
                duplicados[item.Key] = item.Value;
        }
        return duplicados;
    }

    // Función que muestra duplicados
    static void MostrarDuplicados(Dictionary<string, int> duplicados)
    {
        Console.WriteLine("\n--- Productos duplicados ---");
        if (duplicados.Count == 0)
        {
            Console.WriteLine("No se encontraron duplicados.");
        }
        else
        {
            foreach (var item in duplicados)
            {
                Console.WriteLine($"Producto: {item.Key} - Cantidad: {item.Value}");
            }
        }
    }

    // Función que depura duplicados dejando solo una instancia de cada producto
    static List<string> DepurarDuplicados(List<string> productos)
    {
        List<string> depurados = new List<string>();
        foreach (string p in productos)
        {
            if (!depurados.Contains(p))
                depurados.Add(p);
        }
        return depurados;
    }
}

