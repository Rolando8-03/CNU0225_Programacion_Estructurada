class MetrosAKilometros
{
    static void Main(string[] args)
    {
        double metros = LeerMetros();
        double kilometros = ConvertirAKilometros(metros);

        Console.WriteLine($"\n{metros} metros equivalen a {kilometros} kilómetros.");
        Console.ReadKey();
    }

    // Función para leer y validar los metros
    static double LeerMetros()
    {
        double metros;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese la cantidad en metros: ");
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out metros))
            {
                Console.WriteLine("Error: Ingrese un número válido.\n");
                continue;
            }

            if (metros < 0)
            {
                Console.WriteLine("Error: No se permiten valores negativos.\n");
                continue;
            }

            return metros;
        }
    }

    // Función para convertir metros a kilómetros
    static double ConvertirAKilometros(double metros)
    {
        return metros / 1000;
    }
}