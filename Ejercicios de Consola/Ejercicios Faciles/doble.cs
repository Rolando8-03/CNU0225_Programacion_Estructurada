using System;

class DobleDeUnNumero
{
    static void Main(string[] args)
    {
        double numero = LeerNumero();
        double doble = CalcularDoble(numero);

        Console.WriteLine($"\nEl doble de {numero} es: {doble}");
        Console.ReadKey();
    }

    // Función para leer y validar el número
    static double LeerNumero()
    {
        double numero;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese un número: ");
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out numero))
            {
                Console.WriteLine("Error: Ingrese un número válido.\n");
                continue;
            }

            return numero;
        }
    }

    // Función para calcular el doble
    static double CalcularDoble(double num)
    {
        return num * 2;
    }
}
