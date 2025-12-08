using System;

class CalcularPropina
{
    static void Main(string[] args)
    {
        double monto = LeerValor("Ingrese el monto de la cuenta: ");
        double porcentaje = LeerValor("Ingrese el porcentaje de propina: ");

        double total = CalcularTotalConPropina(monto, porcentaje);
        double propina = total - monto;

        Console.WriteLine($"\nPropina: {propina}");
        Console.WriteLine($"Total a pagar: {total}");
        Console.ReadKey();
    }

    // Función para leer y validar valores
    static double LeerValor(string mensaje)
    {
        double valor;
        string entrada;

        while (true)
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out valor))
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.\n");
                continue;
            }

            if (valor < 0)
            {
                Console.WriteLine("Error: No se permiten valores negativos.\n");
                continue;
            }

            return valor;
        }
    }

    // Función para calcular el total con propina
    static double CalcularTotalConPropina(double monto, double porcentaje)
    {
        return monto + (monto * porcentaje / 100);
    }
}
