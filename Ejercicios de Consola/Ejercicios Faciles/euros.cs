class euros
{
    // Tasa de conversión de euros a dólares
    const double TS = 1.25;

    static void Main(string[] args)
    {
        double euros = LeerEuros();
        double dolares = ConvertirADolares(euros);

        Console.WriteLine($"\n{euros} euros equivalen a {dolares} dólares.");
        Console.ReadKey();
    }

    // Función para leer y validar los euros
    static double LeerEuros()
    {
        double euros;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese la cantidad en euros: ");
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out euros))
            {
                Console.WriteLine("Error: Ingrese un número válido.\n");
                continue;
            }

            if (euros < 0)
            {
                Console.WriteLine("Error: No se aceptan valores negativos.\n");
                continue;
            }

            return euros;
        }
    }

    // Función para convertir euros a dólares
    static double ConvertirADolares(double euros)
    {
        return euros * TS;
    }
}