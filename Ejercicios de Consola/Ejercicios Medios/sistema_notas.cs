using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la nota del estudiante (0-100): ");
        double nota = double.Parse(Console.ReadLine());

        bool aprobado = VerificarAprobacion(nota); // Función que determina si aprueba
        MostrarResultado(aprobado);                // Función que muestra el resultado
    }

    // Función que verifica si el estudiante aprueba
    static bool VerificarAprobacion(double nota)
    {
        double notaMinima = 60; // Nota mínima para aprobar
        return nota >= notaMinima;
    }

    // Función que muestra el resultado
    static void MostrarResultado(bool aprobado)
    {
        if (aprobado)
        {
            Console.WriteLine("¡El estudiante ha aprobado!");
        }
        else
        {
            Console.WriteLine("El estudiante ha reprobado.");
        }
    }
}
