using System;

class PerimetroRectangulo
{
    static void Main(string[] args)
    {
        double largo = LeerMedida("Ingrese el largo del rectángulo: ");
        double ancho = LeerMedida("Ingrese el ancho del rectángulo: ");

        double perimetro = CalcularPerimetro(largo, ancho);

        Console.WriteLine($"\nEl perímetro del rectángulo es: {perimetro}");
        Console.ReadKey();
    }

    // Función para leer y validar una medida
    static double LeerMedida(string mensaje)
    {
        double medida;
        string entrada;

        while (true)
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out medida))
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.\n");
                continue;
            }

            if (medida <= 0)
            {
                Console.WriteLine("Error: La medida debe ser mayor que cero.\n");
                continue;
            }

            return medida;
        }
    }

    // Función para calcular el perímetro
    static double CalcularPerimetro(double largo, double ancho)
    {
        return 2 * (largo + ancho);
    }
}
