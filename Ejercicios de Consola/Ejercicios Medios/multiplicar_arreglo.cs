using System;

class MultiplicarArreglo
{
    static void Main(string[] args)
    {
        int[] numeros = LeerArreglo();
        int producto = Multiplicar(numeros);

        Console.WriteLine($"\nEl producto de todos los elementos es: {producto}");
        Console.ReadKey();
    }

    // Leer 5 números y guardarlos en un arreglo
    static int[] LeerArreglo()
    {
        int[] arreglo = new int[5];
        string entrada;
        int numero;

        Console.WriteLine("Ingrese 5 números:");

        for (int i = 0; i < arreglo.Length; i++)
        {
            while (true)
            {
                Console.Write($"Número {i + 1}: ");
                entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out numero))
                {
                    Console.WriteLine("Error: ingrese un número válido.\n");
                    continue;
                }

                arreglo[i] = numero;
                break;
            }
        }

        return arreglo;
    }

    // Multiplica todos los elementos del arreglo
    static int Multiplicar(int[] arr)
    {
        int producto = 1;

        foreach (int n in arr)
        {
            producto *= n;
        }

        return producto;
    }
}
