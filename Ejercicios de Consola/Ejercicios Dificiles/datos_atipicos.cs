using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double[] datos = IngresarDatos();                         // Función para que el usuario ingrese datos
        double media = CalcularMedia(datos);                      // Calcula la media
        double desviacion = CalcularDesviacionEstandar(datos, media); // Calcula la desviación estándar
        List<double> outliers = DetectarOutliers(datos, media, desviacion); // Detecta outliers
        MostrarResultados(datos, media, desviacion, outliers);   // Muestra resultados
    }

    // Función para que el usuario ingrese los datos
    static double[] IngresarDatos()
    {
        List<double> listaDatos = new List<double>();
        Console.WriteLine("Ingrese números (digite 'fin' para terminar):");

        while (true)
        {
            Console.Write("Número: ");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "fin")
                break;

            if (double.TryParse(entrada, out double numero))
            {
                listaDatos.Add(numero);
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingrese un número o 'fin'.");
            }
        }

        return listaDatos.ToArray();
    }

    // Función que calcula la media
    static double CalcularMedia(double[] datos)
    {
        double suma = 0;
        for (int i = 0; i < datos.Length; i++)
        {
            suma += datos[i];
        }
        return suma / datos.Length;
    }

    // Función que calcula la desviación estándar
    static double CalcularDesviacionEstandar(double[] datos, double media)
    {
        double sumaCuadrados = 0;
        for (int i = 0; i < datos.Length; i++)
        {
            sumaCuadrados += Math.Pow(datos[i] - media, 2);
        }
        return Math.Sqrt(sumaCuadrados / datos.Length);
    }

    // Función que detecta outliers usando la regla: fuera de media ± 2*desviación
    static List<double> DetectarOutliers(double[] datos, double media, double desviacion)
    {
        List<double> outliers = new List<double>();
        foreach (double valor in datos)
        {
            if (valor > media + 2 * desviacion || valor < media - 2 * desviacion)
            {
                outliers.Add(valor);
            }
        }
        return outliers;
    }

    // Función que muestra resultados y explica los outliers
    static void MostrarResultados(double[] datos, double media, double desviacion, List<double> outliers)
    {
        Console.WriteLine("\nConjunto de datos: " + string.Join(", ", datos));
        Console.WriteLine($"Media: {media:F2}");
        Console.WriteLine($"Desviación estándar: {desviacion:F2}");
        Console.WriteLine("\nValores atípicos detectados:");

        if (outliers.Count == 0)
        {
            Console.WriteLine("No se detectaron outliers.");
        }
        else
        {
            foreach (double valor in outliers)
            {
                Console.WriteLine($"{valor} es un outlier porque está fuera del rango [{media - 2 * desviacion:F2}, {media + 2 * desviacion:F2}]");
            }
        }
    }
}
