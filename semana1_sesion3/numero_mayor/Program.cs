namespace numero_mayor
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el primer número: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el segundo número: ");
            int b = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el tercer número: ");
            int c = int.Parse(Console.ReadLine()!);

            if (a > b && a > c)
                Console.WriteLine("El mayor es: " + a);
            else if (b > a && b > c)
                Console.WriteLine("El mayor es: " + b);
            else
                Console.WriteLine("El mayor es: " + c);
        }
    }
}