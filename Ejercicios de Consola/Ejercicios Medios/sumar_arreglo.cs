using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 2, 4, 6, 8, 10 }; // Arreglo de ejemplo

        int suma = SumarArreglo(numeros); // Llamada a la función que suma
        Console.WriteLine("La suma de los elementos es: " + suma);
    }

    // Función que recibe un arreglo y devuelve la suma de sus elementos
    static int SumarArreglo(int[] arreglo)
    {
        int total = 0;
        for (int i = 0; i < arreglo.Length; i++)
        {
            total += arreglo[i];
        }
        return total;
    }
}
