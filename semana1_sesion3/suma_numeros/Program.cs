namespace suma_numeros
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese un número positivo: ");
            int n = int.Parse(Console.ReadLine()!);
            int suma = 0;
            int i = 1;

            while (i <= n)
            {
                suma += i;
                i++;
            }

            Console.WriteLine("La suma es: " + suma);
        }
    }
}