class RestaDosNumeros
{
    static void Main(string[] args)
    {
        double num1 = LeerNumero(1);
        double num2 = LeerNumero(2);

        double resultado = Restar(num1, num2);

        Console.WriteLine($"\nEl resultado de la resta es: {resultado}");
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

    // Función para restar dos números
    static double Restar(double a, double b)
    {
        return a - b;
    }
}
