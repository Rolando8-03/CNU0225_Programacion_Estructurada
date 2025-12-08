using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string texto = IngresarTexto(); // Función para que el usuario ingrese el texto
        Dictionary<string, int> conteoPalabras = ContarPalabras(texto); // Contar palabras y frecuencias
        List<string> masFrecuentes = PalabrasMasFrecuentes(conteoPalabras); // Palabras más frecuentes
        List<string> menosComunes = PalabrasMenosComunes(conteoPalabras);   // Palabras menos frecuentes
        int totalUnicas = TotalPalabrasUnicas(conteoPalabras);              // Total de palabras únicas
        GenerarInforme(masFrecuentes, menosComunes, totalUnicas);          // Mostrar informe
    }

    // Función para ingresar texto
    static string IngresarTexto()
    {
        Console.WriteLine("Ingrese el texto a analizar (finalice con una línea vacía):");
        string linea;
        string texto = "";
        while (true)
        {
            linea = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(linea))
                break;
            texto += linea + " ";
        }
        return texto;
    }

    // Función que cuenta las palabras y sus frecuencias
    static Dictionary<string, int> ContarPalabras(string texto)
    {
        Dictionary<string, int> conteo = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        // Limpiar texto y separar palabras
        string[] palabras = Regex.Split(texto, @"\W+"); // separa por cualquier carácter no alfanumérico

        foreach (string palabra in palabras)
        {
            if (string.IsNullOrWhiteSpace(palabra)) continue;
            if (conteo.ContainsKey(palabra))
                conteo[palabra]++;
            else
                conteo[palabra] = 1;
        }
        return conteo;
    }

    // Función para obtener las palabras más frecuentes
    static List<string> PalabrasMasFrecuentes(Dictionary<string, int> conteo)
    {
        int maxFrecuencia = conteo.Values.Max();
        return conteo.Where(p => p.Value == maxFrecuencia).Select(p => p.Key).ToList();
    }

    // Función para obtener las palabras menos comunes
    static List<string> PalabrasMenosComunes(Dictionary<string, int> conteo)
    {
        int minFrecuencia = conteo.Values.Min();
        return conteo.Where(p => p.Value == minFrecuencia).Select(p => p.Key).ToList();
    }

    // Función que retorna el total de palabras únicas
    static int TotalPalabrasUnicas(Dictionary<string, int> conteo)
    {
        return conteo.Count;
    }

    // Función para generar el informe final
    static void GenerarInforme(List<string> masFrecuentes, List<string> menosComunes, int totalUnicas)
    {
        Console.WriteLine("\n--- Informe de análisis de texto ---");
        Console.WriteLine($"Total de palabras únicas: {totalUnicas}");
        Console.WriteLine("\nPalabras más frecuentes: " + string.Join(", ", masFrecuentes));
        Console.WriteLine("Palabras menos comunes: " + string.Join(", ", menosComunes));
    }
}
