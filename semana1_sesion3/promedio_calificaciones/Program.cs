namespace promedio_calificaciones
{
        class Program
    {
        static void Main()
        {
            Console.Write("¿Cuántas calificaciones desea ingresar? ");
            int n = int.Parse(Console.ReadLine()!);

            int i = 1;
            double suma = 0;

            while (i <= n)
            {
                Console.Write("Ingrese la calificación " + i + ": ");
                double cal = double.Parse(Console.ReadLine()!);
                suma += cal;
                i++;
            }

            double promedio = suma / n;
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}