using System;

class MenuOperaciones
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ DE OPERACIONES ===");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("\nOpción inválida. Presione una tecla...");
                Console.ReadKey();
                continue;
            }

            if (opcion >= 1 && opcion <= 4)
            {
                RealizarOperacion(opcion);
            }

        } while (opcion != 5);

        Console.WriteLine("\nSaliendo del programa...");
        Console.ReadKey();
    }

    // Función que realiza la operación según la opción elegida
    static void RealizarOperacion(int opcion)
    {
        double num1, num2;

        Console.Write("Ingrese el primer número: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
            Console.Write("Error. Ingrese un número válido: ");

        Console.Write("Ingrese el segundo número: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
            Console.Write("Error. Ingrese un número válido: ");

        double resultado = 0;

        switch (opcion)
        {
            case 1: resultado = num1 + num2; break;
            case 2: resultado = num1 - num2; break;
            case 3: resultado = num1 * num2; break;
            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("\nNo se puede dividir entre cero.");
                    Console.Write("Presione una tecla...");
                    Console.ReadKey();
                    return;
                }
                resultado = num1 / num2;
                break;
        }

        Console.WriteLine($"\nResultado: {resultado}");
        Console.Write("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}
