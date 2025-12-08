using System;

class MayorDeCinco
{
    static void Main(string[] args)
    {
        double[] numeros = LeerNumeros();
        double mayor = EncontrarMayor(numeros);

        Console.WriteLine($"\nEl número mayor es: {mayor}");
        Console.ReadKey();
    }

    // Función para leer y validar los 5 números
    static double[] LeerNumeros()
    {
        double[] nums = new double[5];
        double valor;
        string entrada;

        for (int i = 0; i < 5; i++)
        {
            while (true)
            {
                Console.Write($"Ingrese el número #{i + 1}: ");
                entrada = Console.ReadLine();

                if (!double.TryParse(entrada, out valor))
                {
                    Console.WriteLine("Error: ingrese un número válido.\n");
                    continue;
                }

                nums[i] = valor;
                break;
            }
        }

        return nums;
    }

    // Función para obtener el mayor
    static double EncontrarMayor(double[] nums)
    {
        double mayor = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > mayor)
                mayor = nums[i];
        }

        return mayor;
    }
}
