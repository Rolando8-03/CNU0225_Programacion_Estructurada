using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese una cadena: ");
        string texto = Console.ReadLine();

        string textoInvertido = InvertirCadena(texto); // Función que invierte la cadena
        MostrarResultado(textoInvertido);              // Función que muestra el resultado
    }

    // Función que invierte una cadena
    static string InvertirCadena(string cadena)
    {
        char[] caracteres = cadena.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }

    // Función que muestra el resultado
    static void MostrarResultado(string resultado)
    {
        Console.WriteLine("La cadena invertida es: " + resultado);
    }
}
