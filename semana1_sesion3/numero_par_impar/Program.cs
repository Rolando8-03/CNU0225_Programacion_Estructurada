namespace numero_par_impar
{
    class Program
    {
        static void Main()
        {
            int pares = 0, impares = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese el número " + i + ": ");
                int num = int.Parse(Console.ReadLine()!);

                if (num % 2 == 0)
                    pares++;
                else
                    impares++;
            }

            Console.WriteLine("Cantidad de pares: " + pares);
            Console.WriteLine("Cantidad de impares: " + impares);
        }
    }
}