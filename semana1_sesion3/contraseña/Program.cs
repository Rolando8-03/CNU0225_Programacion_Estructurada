namespace contraseña
{
    class Program
    {
        static void Main()
        {
            string contraseñaCorrecta = "1234";
            string ingreso;

            do
            {
                Console.Write("Ingrese la contraseña: ");
                ingreso = Console.ReadLine()!;

            } while (ingreso != contraseñaCorrecta);

            Console.WriteLine("¡Contraseña correcta!");
        }
    }
}