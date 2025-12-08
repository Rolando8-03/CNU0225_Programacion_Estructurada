using System;

class SegundosAMinutos
{
    static void Main(string[] args)
    {
        int segundos = LeerSegundos();
        double minutos = Convertir(segundos);

        Console.WriteLine($"\n{segundos} segundos equivalen a {minutos} minutos.");
        Console.ReadKey();
    }

    // Función para leer y validar los segundos
    static int LeerSegundos()
    {
        int s;
        string entrada;

        while (true)
        {
            Console.Write("Ingrese la cantidad de segundos: ");
            entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out s))
            {
                Console.WriteLine("Error: ingrese un número válido.\n");
                continue;
            }

            if (s < 0)
            {
                Console.WriteLine("Error: no se permiten valores negativos.\n");
                continue;
            }

            return s;
        }
    }

    // Función para convertir segundos a minutos
    static double Convertir(int segundos)
    {
        return segundos / 60.0;
    }
}
