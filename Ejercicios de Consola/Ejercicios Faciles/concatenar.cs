class ConcatenarNombreApellido
{
    static void Main(string[] args)
    {
        string nombre = LeerTexto("Ingrese el nombre: ");
        string apellido = LeerTexto("Ingrese el apellido: ");

        string nombreCompleto = Concatenar(nombre, apellido);

        Console.WriteLine($"\nNombre completo: {nombreCompleto}");
        Console.ReadKey();
    }

    // Función para leer y validar texto
    static string LeerTexto(string mensaje)
    {
        string texto;

        while (true)
        {
            Console.Write(mensaje);
            texto = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(texto))
            {
                Console.WriteLine("Error: El campo no puede estar vacío.\n");
                continue;
            }

            return texto.Trim();
        }
    }

    // Función para concatenar nombre y apellido
    static string Concatenar(string nombre, string apellido)
    {
        return nombre + " " + apellido;
    }
}
