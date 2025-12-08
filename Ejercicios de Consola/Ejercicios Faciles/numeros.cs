class NumerosDelUnoAlCien
{
    static void Main(string[] args)
    {
        ImprimirNumeros();
        Console.ReadKey();
    }

    // Función para imprimir los números del 1 al 100
    static void ImprimirNumeros()
    {
        for (int i = 1; i <= 100; i++)
        {
            ImprimirLinea(i);
        }
    }

    // Función para imprimir un número
    static void ImprimirLinea(int numero)
    {
        Console.WriteLine(numero);
    }
}