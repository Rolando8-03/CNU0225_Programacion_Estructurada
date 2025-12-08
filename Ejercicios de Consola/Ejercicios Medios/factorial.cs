using System;

class FactorialNumero
{
    static void Main(string[] args)
    {
        int numero = LeerEntero();
        long factorial = CalcularFactorial(numero);

        Console.WriteLine($"\nEl factorial de {numero} es: {factorial}");
        Console.ReadKey();
    }

    // Función para leer y validar un entero no negativo
    static int LeerEntero()
    {
        int num;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese un número entero no negativo: ");
            entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out num))
            {
                Console.WriteLine("Error: ingrese un número entero válido.\n");
                continue;
            }

            if (num < 0)
            {
                Console.WriteLine("Error: el número no puede ser negativo.\n");
                continue;
            }

            return num;
        }
    }

    // Función para calcular factorial
    static long CalcularFactorial(int n)
    {
        long resultado = 1;

        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }

        return resultado;
    }
}
