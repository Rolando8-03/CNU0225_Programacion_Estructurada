using System;

class ContarLetra
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un texto: ");
        string texto = Console.ReadLine();

        char letra = LeerLetra("Ingrese la letra a buscar: ");

        int contador = ContarApariciones(texto, letra);

        Console.WriteLine($"\nLa letra '{letra}' aparece {contador} veces.");
        Console.ReadKey();
    }

    // Función para leer una sola letra válida
    static char LeerLetra(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();

            if (entrada.Length != 1)
            {
                Console.WriteLine("Error: debe ingresar SOLO una letra.\n");
                continue;
            }

            return entrada[0];
        }
    }

    // Función para contar apariciones
    static int ContarApariciones(string texto, char letra)
    {
        int contador = 0;

        foreach (char c in texto)
        {
            if (char.ToLower(c) == char.ToLower(letra))
                contador++;
        }

        return contador;
    }
}
