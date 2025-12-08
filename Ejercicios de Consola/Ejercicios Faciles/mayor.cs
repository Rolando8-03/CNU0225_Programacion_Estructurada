using System;

class MayorDeDos
{
    static void Main(string[] args)
    {
        double n1 = LeerNumero("Ingrese el primer número: ");
        double n2 = LeerNumero("Ingrese el segundo número: ");

        double mayor = ObtenerMayor(n1, n2);

        Console.WriteLine($"\nEl número mayor es: {mayor}");
        Console.ReadKey();
    }

    // Función para leer y validar números
    static double LeerNumero(string mensaje)
    {
        double valor;
        string entrada;

        while (true)
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out valor))
            {
                Console.WriteLine("Error: Ingrese un número válido.\n");
                continue;
            }

            return valor;
        }
    }

    // Función para obtener el mayor de dos números
    static double ObtenerMayor(double a, double b)
    {
        if (a > b)
            return a;
        else
            return b;
    }
}
