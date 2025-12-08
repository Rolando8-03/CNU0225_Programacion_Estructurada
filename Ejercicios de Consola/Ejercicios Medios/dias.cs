using System;

class DiasEntreFechas
{
    static void Main(string[] args)
    {
        DateTime fecha1 = LeerFecha("Ingrese la primera fecha (dd/mm/aaaa): ");
        DateTime fecha2 = LeerFecha("Ingrese la segunda fecha (dd/mm/aaaa): ");

        int dias = CalcularDias(fecha1, fecha2);

        Console.WriteLine($"\nDías entre ambas fechas: {dias}");
        Console.ReadKey();
    }

    // Función para leer y validar una fecha
    static DateTime LeerFecha(string mensaje)
    {
        DateTime fecha;
        string entrada;

        while (true)
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine();

            if (!DateTime.TryParse(entrada, out fecha))
            {
                Console.WriteLine("Error: Formato de fecha no válido. Use dd/mm/aaaa.\n");
                continue;
            }

            return fecha;
        }
    }

    // Función para calcular la diferencia en días
    static int CalcularDias(DateTime f1, DateTime f2)
    {
        return Math.Abs((f2 - f1).Days);
    }
}
