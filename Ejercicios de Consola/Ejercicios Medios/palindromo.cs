using System;

class Palindromo
{
    static void Main(string[] args)
    {
        string palabra = LeerPalabra();
        VerificarPalindromo(palabra);

        Console.ReadKey();
    }

    // Función para leer la palabra y validarla
    static string LeerPalabra()
    {
        string texto;

        while (true)
        {
            Console.Write("Ingrese una palabra: ");
            texto = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(texto))
            {
                Console.WriteLine("Error: No puede ingresar una cadena vacía.\n");
                continue;
            }

            return texto.Trim();
        }
    }

    // Función para verificar si es palíndromo
    static void VerificarPalindromo(string palabra)
    {
        string normal = palabra.Replace(" ", "").ToLower();
        string invertida = "";

        for (int i = normal.Length - 1; i >= 0; i--)
        {
            invertida += normal[i];
        }

        if (normal == invertida)
            Console.WriteLine($"\n\"{palabra}\" ES un palíndromo.");
        else
            Console.WriteLine($"\n\"{palabra}\" NO es un palíndromo.");
    }
}
