using System;

class OrdenarNumeros
{
    static void Main(string[] args)
    {
        double[] numeros = LeerNumeros();
        OrdenarDescendente(numeros);

        Console.WriteLine("\nNúmeros ordenados de mayor a menor:");
        foreach (double n in numeros)
            Console.WriteLine(n);

        Console.ReadKey();
    }

    // Función para leer los 10 números
    static double[] LeerNumeros()
    {
        double[] lista = new double[10];
        string entrada;
        double valor;

        for (int i = 0; i < 10; i++)
        {
            while (true)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                entrada = Console.ReadLine();

                if (!double.TryParse(entrada, out valor))
                {
                    Console.WriteLine("Error: Ingrese un número válido.\n");
                    continue;
                }

                lista[i] = valor;
                break;
            }
        }

        return lista;
    }

    // Función para ordenar de mayor a menor
    static void OrdenarDescendente(double[] arreglo)
    {
        Array.Sort(arreglo);      // Ordena de menor a mayor
        Array.Reverse(arreglo);   // Lo invierte → mayor a menor
    }
}
