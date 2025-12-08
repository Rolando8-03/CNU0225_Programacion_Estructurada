using System;

class CajeroSimulado
{
    static void Main(string[] args)
    {
        double saldo = 1000; // Saldo inicial simulado
        Console.WriteLine($"Su saldo actual es: {saldo} córdobas\n");

        double retiro = LeerCantidad();

        if (PuedeRetirar(saldo, retiro))
        {
            saldo -= retiro;
            Console.WriteLine($"\nRetiro exitoso. Su nuevo saldo es: {saldo} córdobas.");
        }
        else
        {
            Console.WriteLine("\nError: No tiene suficientes fondos.");
        }

        Console.ReadKey();
    }

    // Leer y validar cantidad a retirar
    static double LeerCantidad()
    {
        double cantidad;
        while (true)
        {
            Console.Write("Ingrese la cantidad a retirar: ");
            string entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out cantidad))
            {
                Console.WriteLine("Error: Debe ingresar un número válido.\n");
                continue;
            }

            if (cantidad <= 0)
            {
                Console.WriteLine("Error: La cantidad debe ser mayor que cero.\n");
                continue;
            }

            return cantidad;
        }
    }

    // Ver si el retiro es posible
    static bool PuedeRetirar(double saldo, double retiro)
    {
        return retiro <= saldo;
    }
}
