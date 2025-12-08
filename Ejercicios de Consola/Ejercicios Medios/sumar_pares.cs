using System;

class SumaPares1a100
{
    static void Main(string[] args)
    {
        int suma = CalcularSumaPares();
        MostrarResultado(suma);
        Console.ReadKey();
    }

    // Función que calcula la suma de los números pares del 1 al 100
    static int CalcularSumaPares()
    {
        int suma = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                suma += i;
            }
        }

        return suma;
    }

    // Función para mostrar el resultado
    static void MostrarResultado(int total)
    {
        Console.WriteLine($"La suma de los números pares del 1 al 100 es: {total}");
    }
}
