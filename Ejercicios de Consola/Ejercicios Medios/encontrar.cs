using System;

class PalabraMasLarga
{
    static void Main(string[] args)
    {
        Console.Write("¿Cuántas palabras desea ingresar? ");
        int cantidad = LeerEnteroPositivo();

        string palabraLarga = EncontrarMasLarga(cantidad);

        Console.WriteLine($"\nLa palabra más larga es: {palabraLarga}");
        Console.ReadKey();
    }

    // Función para leer y validar un entero positivo
    static int LeerEnteroPositivo()
    {
        int numero;

        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Error: ingrese un número válido: ");
                continue;
            }

            if (numero <= 0)
            {
                Console.Write("Debe ser un número mayor que cero: ");
                continue;
            }

            return numero;
        }
    }

    // Función para leer palabras y determinar la más larga
    static string EncontrarMasLarga(int cantidad)
    {
        string palabraActual, palabraLarga = "";

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Ingrese la palabra {i}: ");
            palabraActual = Console.ReadLine();

            if (palabraActual.Length > palabraLarga.Length)
            {
                palabraLarga = palabraActual;
            }
        }

        return palabraLarga;
    }
}
