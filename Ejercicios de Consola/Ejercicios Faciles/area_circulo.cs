using System;

class AreaCirculo
{
    static void Main(string[] args)
    {
        double radio = LeerRadio();
        double area = CalcularArea(radio);

        Console.WriteLine($"\nEl área del círculo es: {area}");
        Console.ReadKey();
    }

    // Función para leer y validar el radio
    static double LeerRadio()
    {
        double radio;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese el radio del círculo: ");
            entrada = Console.ReadLine();

            if (!double.TryParse(entrada, out radio))
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.\n");
                continue;
            }

            if (radio <= 0)
            {
                Console.WriteLine("Error: El radio debe ser mayor que cero.\n");
                continue;
            }

            return radio;
        }
    }

    // Función para calcular el área
    static double CalcularArea(double r)
    {
        return Math.PI * r * r;
    }
}
