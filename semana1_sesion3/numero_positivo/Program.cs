namespace numero_positivo
{
        class Program
    {
        static void Main()
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine()!);

            if (num > 0)
                Console.WriteLine("El número es positivo.");
            else if (num < 0)
                Console.WriteLine("El número es negativo.");
            else
                Console.WriteLine("El número es cero.");
        }
    }
}