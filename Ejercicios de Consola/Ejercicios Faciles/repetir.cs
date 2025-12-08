using System;

class RepetirPalabra
{
    static void Main(string[] args)
    {
        string palabra = LeerPalabra();
        int veces = LeerEntero();

        Repetir(palabra, veces);

        Console.ReadKey();
    }

    // Leer palabra (validación simple)
    static string LeerPalabra()
    {
        string texto;

        while (true)
        {
            Console.Write("Ingrese una palabra: ");
            texto = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(texto))
            {
                Console.WriteLine("Error: No puede estar vacío.\n");
                continue;
            }

            return texto;
        }
    }

    // Leer número entero positivo
    static int LeerEntero()
    {
        int numero;
        string entrada;

        while (true)
        {
            Console.Write("¿Cuántas veces quiere repetirla?: ");
            entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out numero) || numero <= 0)
            {
                Console.WriteLine("Error: Ingrese un número entero mayor que 0.\n");
                continue;
            }

            return numero;
        }
    }

    // Función que repite la palabra N veces
    static void Repetir(string palabra, int veces)
    {
        for (int i = 1; i <= veces; i++)
        {
            Console.WriteLine($"{i}. {palabra}");
        }
    }
}
