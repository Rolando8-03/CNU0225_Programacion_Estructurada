class multiplos
{
    // Programa para mostrar los primeros 20 múltiplos de 2
        static void Main(string[] args)
    {
        MostrarMultiplos();
        Console.ReadKey();
    }

    // Función para mostrar los primeros 20 múltiplos de 2
    static void MostrarMultiplos()
    {
        int contador = 0;
        int numero = 1;

        Console.WriteLine("Los primeros 20 múltiplos de 2 son:\n");

        while (contador < 20)
        {
            if (EsMultiploDeDos(numero))
            {
                Console.Write(numero + " ");
                contador++;
            }
            numero++;
        }
    }

    // Función para verificar si es múltiplo de 2
    static bool EsMultiploDeDos(int num)
    {
        return num % 2 == 0;
    }
}