using System;

class AreaTriangulo
{
    static void Main(string[] args)
    {
        double baseT = LeerValor("Ingrese la base del triángulo: ");
        double altura = LeerValor("Ingrese la altura del triángulo: ");

        double area = CalcularArea(baseT, altura);

        Console.WriteLine($"\nEl área del triángulo es: {area}");
        Console.ReadKey();
    }

    // Función para leer y validar base y altura
    static double LeerValor(string mensaje)
    {
        double valor;
        string entrada;

        while (true)
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out valor))
            {
                Console.WriteLine("Error: ingrese un número válido.\n");
                continue;
            }

            if (valor <= 0)
            {
                Console.WriteLine("Error: el valor debe ser mayor que cero.\n");
                continue;
            }

            return valor;
        }
    }

    // Función para calcular el área
    static double CalcularArea(double baseT, double altura)
    {
        return (baseT * altura) / 2;
    }
}
