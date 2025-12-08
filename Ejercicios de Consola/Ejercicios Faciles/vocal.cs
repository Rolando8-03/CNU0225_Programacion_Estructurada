public class vocal
{
    //Verificar si una letra es vocal o consonante.
    static void Main(string[] args)
    {
        char letra = LeerLetra();

        if (EsVocal(letra))
        {
            Console.WriteLine($"\nLa letra '{letra}' es una VOCAL.");
        }
        else
        {
            Console.WriteLine($"\nLa letra '{letra}' es una CONSONANTE.");
        }

        Console.ReadKey();
    }

    // Función para leer y validar la letra
    static char LeerLetra()
    {
        string entrada;

        while (true)
        {
            Console.Write("Ingrese una sola letra: ");
            entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Error: No puede estar vacío.\n");
                continue;
            }

            if (entrada.Length != 1)
            {
                Console.WriteLine("Error: Ingrese solo una letra.\n");
                continue;
            }

            if (!char.IsLetter(entrada[0]))
            {
                Console.WriteLine("Error: Debe ingresar una letra.\n");
                continue;
            }

            return char.ToLower(entrada[0]);
        }
    }

    // Función para verificar si es vocal
    static bool EsVocal(char letra)
    {
        return letra == 'a' || letra == 'e' || letra == 'i' ||
               letra == 'o' || letra == 'u';
    }
}