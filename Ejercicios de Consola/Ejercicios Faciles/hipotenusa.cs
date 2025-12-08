using System;

class CalculoHipotenusa
{
    static void Main(string[] args)
    {
        double cateto1 = LeerCateto("Ingrese el primer cateto: ");
        double cateto2 = LeerCateto("Ingrese el segundo cateto: ");

        double hipotenusa = CalcularHipotenusa(cateto1, cateto2);

        Console.WriteLine($"\nLa hipotenusa es: {hipotenusa}");
        Console.ReadKey();
    }

    // Función para leer y validar un cateto
    static double LeerCateto(string mensaje)
    {
        double cateto;
        string entrada;

        while (true)
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out cateto))
            {
                Console.WriteLine("Error: Ingrese un número válido.\n");
                continue;
            }

            if (cateto <= 0)
            {
                Console.WriteLine("Error: El valor debe ser mayor que cero.\n");
                continue;
            }

            return cateto;
        }
    }

    // Función para calcular la hipotenusa
    static double CalcularHipotenusa(double a, double b)
    {
        return Math.Sqrt(a * a + b * b);
    }
}