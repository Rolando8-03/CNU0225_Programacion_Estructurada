using System;

class TablaMultiplicar
{
    static void Main(string[] args)
    {
        int numero = LeerNumero();
        MostrarTabla(numero);

        Console.ReadKey();
    }

    // Función para leer y validar el número
    static int LeerNumero()
    {
        int num;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese un número para mostrar su tabla de multiplicar: ");
            entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out num))
            {
                Console.WriteLine("Error: debe ingresar un número entero.\n");
                continue;
            }

            return num;
        }
    }

    // Función para mostrar la tabla del 1 al 10
    static void MostrarTabla(int n)
    {
        Console.WriteLine($"\nTabla del {n} (1 al 10):\n");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}
