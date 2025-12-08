using System;

class TotalSupermercado
{
    static void Main(string[] args)
    {
        double precio = LeerValor("Ingrese el precio del producto: ");
        int cantidad = (int)LeerValor("Ingrese la cantidad: ");

        double total = CalcularTotal(precio, cantidad);

        Console.WriteLine($"\nTotal a pagar: {total}");
        Console.ReadKey();
    }

    // Función para leer y validar valores numéricos
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
                Console.WriteLine("Error: ingrese un número válido.\n");
                continue;
            }

            if (valor < 0)
            {
                Console.WriteLine("Error: no se permiten números negativos.\n");
                continue;
            }

            return valor;
        }
    }

    // Función para calcular el total
    static double CalcularTotal(double precio, int cantidad)
    {
        return precio * cantidad;
    }
}
