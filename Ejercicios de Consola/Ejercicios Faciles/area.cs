class AreaCuadrado
{
    static void Main(string[] args)
    {
        double lado = LeerLado();
        double area = CalcularArea(lado);

        Console.WriteLine($"\nEl área del cuadrado es: {area}");
        Console.ReadKey();
    }

    // Función para leer y validar el lado del cuadrado
    static double LeerLado()
    {
        double lado;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese el lado del cuadrado: ");
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out lado))
            {
                Console.WriteLine("Error: Ingrese un número válido.\n");
                continue;
            }

            if (lado <= 0)
            {
                Console.WriteLine("Error: El lado debe ser mayor que cero.\n");
                continue;
            }

            return lado;
        }
    }

    // Función para calcular el área
    static double CalcularArea(double lado)
    {
        return lado * lado;
    }
}
