using System;

class SumaDiezNaturales
{
    static void Main(string[] args)
    {
        int suma = CalcularSuma();
        MostrarResultado(suma);

        Console.ReadKey();
    }

    static int CalcularSuma()
    {
        int suma = 0;

        for (int i = 1; i <= 10; i++)
        {
            suma += i;
        }

        return suma;
    }

    static void MostrarResultado(int suma)
    {
        Console.WriteLine($"La suma de los primeros 10 números naturales es: {suma}");
    }
}
