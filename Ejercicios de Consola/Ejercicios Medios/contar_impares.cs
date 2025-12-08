using System;

class ContarImpares
{
    static void Main(string[] args)
    {
        int contador = ContarNumerosImpares();
        Console.WriteLine($"\nCantidad de números impares ingresados: {contador}");
        Console.ReadKey();
    }

    // Función que pide 10 números y cuenta los impares
    static int ContarNumerosImpares()
    {
        int impares = 0;

        for (int i = 1; i <= 10; i++)
        {
            int numero = LeerNumero($"Ingrese el número #{i}: ");

            if (numero % 2 != 0)
                impares++;
        }

        return impares;
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
                Console.WriteLine("Error: ingrese un número entero válido.\n");
                continue;
            }

            return num;
        }
    }
}
