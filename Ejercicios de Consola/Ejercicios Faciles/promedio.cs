class promedio
{
    //Calcular el promedio de tres números ingresados por el usuario
        static void Main(string[] args)
    {
        double num1 = LeerNumero(1);
        double num2 = LeerNumero(2);
        double num3 = LeerNumero(3);

        double promedio = CalcularPromedio(num1, num2, num3);

        Console.WriteLine($"\nEl promedio de los tres números es: {promedio}");
        Console.ReadKey();
    }

    // Función para leer y validar un número
    static double LeerNumero(int posicion)
    {
        double numero;
        string entrada;

        while (true)
        {
            Console.Write($"Ingrese el número {posicion}: ");
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out numero))
            {
                Console.WriteLine("Error: Ingrese un número válido.\n");
                continue;
            }

            return numero;
        }
    }

    // Función para calcular el promedio
    static double CalcularPromedio(double a, double b, double c)
    {
        return (a + b + c) / 3;
    }
}