using System;

class Program
{
    static void Main(string[] args)
    {
        int sumaImpares = SumarImpares(1, 100); // Llamada a la función que suma los impares
        MostrarResultado(sumaImpares);          // Llamada a la función que muestra el resultado
    }

    // Función que suma todos los números impares entre un rango
    static int SumarImpares(int inicio, int fin)
    {
        int suma = 0;
        for (int i = inicio; i <= fin; i++)
        {
            if (i % 2 != 0) // Verifica si es impar
            {
                suma += i;
            }
        }
        return suma;
    }

    // Función que muestra el resultado
    static void MostrarResultado(int resultado)
    {
        Console.WriteLine("La suma de los números impares del 1 al 100 es: " + resultado);
    }
}
