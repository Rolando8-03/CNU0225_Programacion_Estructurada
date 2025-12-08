using System;

class Dado
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simulación de dado (1-6):");
        int resultado = LanzarDado();
        MostrarResultado(resultado);

        Console.ReadKey();
    }

    // Función que simula el lanzamiento (número aleatorio de 1 a 6)
    static int LanzarDado()
    {
        Random random = new Random();
        return random.Next(1, 7); // 7 no se incluye → 1 a 6
    }

    // Función que muestra el resultado
    static void MostrarResultado(int numero)
    {
        Console.WriteLine($"\nEl dado cayó en: {numero}");
    }
}
