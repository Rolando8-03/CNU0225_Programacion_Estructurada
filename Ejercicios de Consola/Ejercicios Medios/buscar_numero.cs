using System;

class BuscarEnArreglo
{
    static void Main(string[] args)
    {
        int[] numeros = { 5, 12, 7, 20, 3, 9, 15, 8, 1, 10 };

        int buscado = LeerNumero("Ingrese el número que desea buscar: ");

        bool encontrado = BuscarNumero(numeros, buscado);

        if (encontrado)
            Console.WriteLine($"\nEl número {buscado} SÍ está en el arreglo.");
        else
            Console.WriteLine($"\nEl número {buscado} NO está en el arreglo.");

        Console.ReadKey();
    }

    // Función para leer y validar un número entero
    static int LeerNumero(string mensaje)
    {
        int num;
        string entrada;

        while (true)
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out num))
            {
                Console.WriteLine("Error: Ingrese un número válido.\n");
                continue;
            }

            return num;
        }
    }

    // Función para buscar un número en el arreglo
    static bool BuscarNumero(int[] arreglo, int buscado)
    {
        foreach (int n in arreglo)
        {
            if (n == buscado)
                return true;
        }
        return false;
    }
}
