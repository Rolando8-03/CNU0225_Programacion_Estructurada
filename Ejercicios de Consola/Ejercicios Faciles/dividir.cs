class DivisionDosNumeros
{
    static void Main(string[] args)
    {
        double num1 = LeerNumero(1);
        double num2 = LeerNumero(2);

        double resultado = Dividir(num1, num2);

        Console.WriteLine($"\nEl resultado de la división es: {resultado}");
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

    // Función para dividir dos números
    static double Dividir(double a, double b)
    {
        while (b == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            b = LeerNumero(2);
        }

        return a / b;
    }
}