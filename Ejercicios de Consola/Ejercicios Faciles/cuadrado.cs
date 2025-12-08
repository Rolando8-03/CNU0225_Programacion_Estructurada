class CuadradoDeUnNumero
{
    static void Main(string[] args)
    {
        double numero = LeerNumero();
        double cuadrado = CalcularCuadrado(numero);

        Console.WriteLine($"\nEl cuadrado de {numero} es: {cuadrado}");
        Console.ReadKey();
    }

    // Función para leer y validar el número
    static double LeerNumero()
    {
        double numero;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese un número: ");
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out numero))
            {
                Console.WriteLine("Error: Ingrese un número válido.\n");
                continue;
            }

            return numero;
        }
    }

    // Función para calcular el cuadrado
    static double CalcularCuadrado(double num)
    {
        return num * num;
    }
}