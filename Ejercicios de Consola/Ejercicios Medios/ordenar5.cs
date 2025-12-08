using System;

class OrdenarCincoNumeros
{
    static void Main(string[] args)
    {
        int[] numeros = LeerNumeros();
        Ordenar(numeros);

        Console.WriteLine("\nNúmeros ordenados de menor a mayor:");
        foreach (int n in numeros)
            Console.Write(n + " ");

        Console.ReadKey();
    }

    // Función para leer y validar los 5 números
    static int[] LeerNumeros()
    {
        int[] arr = new int[5];
        string entrada;
        int numero;

        for (int i = 0; i < 5; i++)
        {
            while (true)
            {
                Console.Write($"Ingrese el número #{i + 1}: ");
                entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out numero))
                {
                    Console.WriteLine("Error: debe ingresar un número válido.\n");
                    continue;
                }

                arr[i] = numero;
                break;
            }
        }

        return arr;
    }

    // Función para ordenar el arreglo
    static void Ordenar(int[] arr)
    {
        Array.Sort(arr);
    }
}
