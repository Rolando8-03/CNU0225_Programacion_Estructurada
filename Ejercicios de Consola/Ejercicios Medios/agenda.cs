using System;

class AgendaSimple
{
    static void Main(string[] args)
    {
        Console.Write("¿Cuántos contactos desea agregar?: ");
        int cantidad = LeerEntero();

        string[] nombres = new string[cantidad];
        string[] telefonos = new string[cantidad];

        GuardarContactos(nombres, telefonos);

        Console.WriteLine("\n--- AGENDA ---");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"[{i}] Nombre: {nombres[i]}, Teléfono: {telefonos[i]}");
        }

        Console.ReadKey();
    }

    // Función para leer un entero válido
    static int LeerEntero()
    {
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
        {
            Console.Write("Error. Ingrese un número válido: ");
        }
        return numero;
    }

    // Función para registrar los contactos
    static void GuardarContactos(string[] nombres, string[] telefonos)
    {
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write($"\nIngrese el nombre #{i + 1}: ");
            nombres[i] = Console.ReadLine();

            Console.Write("Ingrese el teléfono: ");
            telefonos[i] = Console.ReadLine();
        }
    }
}
