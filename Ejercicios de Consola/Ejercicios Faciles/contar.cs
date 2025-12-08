using System;

class ContarDescendente
{
    static void Main(string[] args)
    {
        Contar();
        Console.ReadKey();
    }

    // Función que cuenta del 10 al 1
    static void Contar()
    {
        for (int i = 10; i >= 1; i--)
        {
            MostrarNumero(i);
        }
    }

    // Función para imprimir un número
    static void MostrarNumero(int num)
    {
        Console.WriteLine(num);
    }
}
