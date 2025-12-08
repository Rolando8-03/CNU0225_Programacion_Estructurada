using System;

class ContarPalabra
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un texto: ");
        string texto = Console.ReadLine();

        Console.Write("Ingrese la palabra a buscar: ");
        string palabra = Console.ReadLine();

        int cantidad = ContarApariciones(texto, palabra);

        Console.WriteLine($"\nLa palabra \"{palabra}\" aparece {cantidad} veces.");
        Console.ReadKey();
    }

    // Función principal para contar apariciones
    static int ContarApariciones(string texto, string palabra)
    {
        if (string.IsNullOrWhiteSpace(texto) || string.IsNullOrWhiteSpace(palabra))
            return 0;

        string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int contador = 0;

        foreach (string p in palabras)
        {
            if (p.Equals(palabra, StringComparison.OrdinalIgnoreCase))
                contador++;
        }

        return contador;
    }
}
