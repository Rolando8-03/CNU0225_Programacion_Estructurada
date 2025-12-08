//Usando modularidad convierta temperatura de grados celcius a fahrenheit
using System;
namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese un número: ");
                int num = int.Parse(Console.ReadLine()!);
                if (num % 2 == 0)
                {
                    Console.WriteLine("El número es par");

                }
                else
                {
                    Console.WriteLine("El número es impar");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debe ingresar un número entero.");
            }
        }
    }
}
