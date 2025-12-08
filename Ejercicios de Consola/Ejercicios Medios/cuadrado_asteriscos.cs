using System;

class CuadradoAsteriscos
{
    static void Main(string[] args)
    {
        int tamaño = LeerEntero();
        ImprimirCuadrado(tamaño);

        Console.ReadKey();
    }

    // Función para leer y validar el tamaño del cuadrado
    static int LeerEntero()
    {
        int n;
        while (true)
        {
            Console.Write("Ingrese el tamaño del cuadrado (entero positivo): ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                return n;

            Console.WriteLine("Error: Ingrese un número entero positivo.\n");
        }
    }

    // Función para imprimir el cuadrado
    static void ImprimirCuadrado(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
