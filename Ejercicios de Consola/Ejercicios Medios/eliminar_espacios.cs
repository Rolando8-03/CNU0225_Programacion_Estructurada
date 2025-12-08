using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese una cadena: ");
        string texto = Console.ReadLine();

        string textoSinEspacios = EliminarEspacios(texto); // Función que elimina los espacios
        MostrarResultado(textoSinEspacios);               // Función que muestra el resultado
    }

    // Función que elimina todos los espacios de una cadena
    static string EliminarEspacios(string cadena)
    {
        return cadena.Replace(" ", ""); // Reemplaza los espacios por nada
    }

    // Función que muestra el resultado
    static void MostrarResultado(string resultado)
    {
        Console.WriteLine("La cadena sin espacios es: " + resultado);
    }
}
