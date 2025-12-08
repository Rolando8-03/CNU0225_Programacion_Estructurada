using System;

class FibonacciSerie
{
    static void Main(string[] args)
    {
        int n = LeerCantidad();
        MostrarFibonacci(n);

        Console.ReadKey();
    }

    // Función para leer y validar N
    static int LeerCantidad()
    {
        int n;
        while (true)
        {
            Console.Write("¿Cuántos números de Fibonacci desea mostrar? ");
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Error: Ingrese un número entero mayor que 0.\n");
                continue;
            }
            return n;
        }
    }

    // Función para imprimir la serie Fibonacci
    static void MostrarFibonacci(int n)
    {
        int a = 0, b = 1;

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            int c = a + b;
            a = b;
            b = c;
        }

        Console.WriteLine();
    }
}
