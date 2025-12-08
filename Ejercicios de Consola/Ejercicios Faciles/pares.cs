class NumerosPares
{
    //Imprimir los números pares del 1 al 50.
    static void Main(string[] args)
    {
        ImprimirPares();
        Console.ReadKey();
    }

    // Función para imprimir los números pares del 1 al 50
    static void ImprimirPares()
    {
        Console.WriteLine("Números pares del 1 al 50:\n");

        for (int i = 1; i <= 50; i++)
        {
            if (EsPar(i))
            {
                Console.Write(i + " ");
            }
        }
    }

    // Función para verificar si un número es par
    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }
}