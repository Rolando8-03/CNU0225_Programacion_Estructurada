class DescuentoProducto
{
    static void Main(string[] args)
    {
        double precio = LeerValor("Ingrese el precio del producto: ");
        double descuento = LeerValor("Ingrese el porcentaje de descuento: ");

        double precioFinal = CalcularPrecioFinal(precio, descuento);
        double montoDescuento = precio - precioFinal;

        Console.WriteLine($"\nMonto del descuento: {montoDescuento}");
        Console.WriteLine($"Precio final a pagar: {precioFinal}");
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

    // Función para calcular el precio final con descuento
    static double CalcularPrecioFinal(double precio, double porcentaje)
    {
        return precio - (precio * porcentaje / 100);
    }
}
