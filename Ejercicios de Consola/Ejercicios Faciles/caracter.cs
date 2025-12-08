using System;

class PrimerCaracter
{
    static void Main(string[] args)
    {
        string texto = LeerTexto();
        MostrarPrimerCaracter(texto);

        Console.ReadKey();
    }

    // Función para leer y validar la cadena
    static string LeerTexto()
    {
        string entrada;

        while (true)
        {
            Console.Write("Ingrese un texto: ");
            entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Error: No puede ingresar una cadena vacía.\n");
                continue;
            }

            return entrada;
        }
    }

    // Función para mostrar el primer carácter
    static void MostrarPrimerCaracter(string texto)
    {
        Console.WriteLine($"\nEl primer carácter es: {texto[0]}");
    }
}
