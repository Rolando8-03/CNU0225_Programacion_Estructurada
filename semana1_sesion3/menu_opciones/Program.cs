namespace menu_opciones
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Mostrar la fecha actual");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine()!);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola! Espero que tengas un gran día.");
                    break;
                case 2:
                    Console.WriteLine("La fecha actual es: " + DateTime.Now);
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}