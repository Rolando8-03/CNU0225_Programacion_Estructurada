class TextoAMayusculas
{
    static void Main(string[] args)
    {
        string texto = LeerTexto();
        string resultado = ConvertirAMayusculas(texto);

        Console.WriteLine($"\nTexto en mayúsculas:");
        Console.WriteLine(resultado);

        Console.ReadKey();
    }

    // Función para leer y validar el texto
    static string LeerTexto()
    {
        string texto;

        while (true)
        {
            Console.Write("Ingrese un texto: ");
            texto = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(texto))
            {
                Console.WriteLine("Error: El texto no puede estar vacío.\n");
                continue;
            }

            return texto;
        }
    }

    // Función para convertir el texto a mayúsculas
    static string ConvertirAMayusculas(string texto)
    {
        return texto.ToUpper();
    }
}