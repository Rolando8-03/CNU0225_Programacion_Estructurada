namespace tabla_multiplicar
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine()!);
            int i = 1;

            do
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
                i++;
            } while (i <= 10);
        }
    }
}