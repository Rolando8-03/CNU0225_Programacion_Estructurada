using System;

class PalabraMasCorta
{
    static void Main(string[] args)
    {
        string[] palabras = LeerPalabras();
        string masCorta = ObtenerMasCorta(palabras);

        Console.WriteLine($"\nLa palabra más corta es: {masCorta}");
        Console.ReadKey();
    }

    // Función para leer y validar palabras
    static string[] LeerPalabras()
    {
        string entrada;

        while (true)
        {
            Console.Write("Ingrese varias palabras separadas por espacio: ");
            entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Error: Debe ingresar al menos una palabra.\n");
                continue;
            }

            string[] lista = entrada.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (lista.Length == 0)
            {
                Console.WriteLine("Error: Ingrese palabras válidas.\n");
                continue;
            }

            return lista;
        }
    }

    // Función para obtener la palabra más corta
    static string ObtenerMasCorta(string[] palabras)
    {
        string corta = palabras[0];

        foreach (string p in palabras)
        {
            if (p.Length < corta.Length)
                corta = p;
        }

        return corta;
    }
}
