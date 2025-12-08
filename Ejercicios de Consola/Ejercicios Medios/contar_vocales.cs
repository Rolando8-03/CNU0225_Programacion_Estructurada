using System;

class ContarVocales
{
    static void Main(string[] args)
    {
        string frase = LeerFrase();
        int totalVocales = ContarVocalesEnFrase(frase);

        Console.WriteLine($"\nLa frase tiene {totalVocales} vocal(es).");
        Console.ReadKey();
    }

    // Función para leer la frase
    static string LeerFrase()
    {
        string frase;

        while (true)
        {
            Console.Write("Ingrese una frase: ");
            frase = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(frase))
            {
                Console.WriteLine("Error: la frase no puede estar vacía.\n");
                continue;
            }

            return frase;
        }
    }

    // Función para contar vocales
    static int ContarVocalesEnFrase(string frase)
    {
        int contador = 0;
        frase = frase.ToLower();

        foreach (char c in frase)
        {
            if ("aeiou".Contains(c))
            {
                contador++;
            }
        }

        return contador;
    }
}
