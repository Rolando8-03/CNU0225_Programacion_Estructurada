using System;

class MultiploDeTres
{
    static void Main(string[] args)
    {
        int numero = LeerNumero();
        VerificarMultiplo(numero);

        Console.ReadKey();
    }

    // Función para leer y validar número entero
    static int LeerNumero()
    {
        int num;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese un número entero: ");
            entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out num))
            {
                Console.WriteLine("Error: debe ingresar un número entero.\n");
                continue;
            }

            return num;
        }
    }

    // Función para verificar si es múltiplo de 3
    static void VerificarMultiplo(int n)
    {
        if (n % 3 == 0)
            Console.WriteLine($"\nEl número {n} SÍ es múltiplo de 3.");
        else
            Console.WriteLine($"\nEl número {n} NO es múltiplo de 3.");
    }
}
