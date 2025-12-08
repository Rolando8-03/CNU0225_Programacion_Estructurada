using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] logs = IngresarLogs();                  // Función para ingresar o leer logs
        Dictionary<string, int> conteo = ClasificarLogs(logs); // Clasificar por niveles
        MostrarReporte(conteo, logs);                   // Mostrar reporte detallado
    }

    // Función para ingresar logs desde el usuario
    static string[] IngresarLogs()
    {
        List<string> listaLogs = new List<string>();
        Console.WriteLine("Ingrese las líneas de log (digite 'fin' para terminar):");
        while (true)
        {
            string linea = Console.ReadLine();
            if (linea.ToLower() == "fin")
                break;
            listaLogs.Add(linea);
        }
        return listaLogs.ToArray();
    }

    // Función que clasifica los logs y cuenta cuántos hay de cada tipo
    static Dictionary<string, int> ClasificarLogs(string[] logs)
    {
        Dictionary<string, int> conteo = new Dictionary<string, int>()
        {
            {"INFO", 0},
            {"WARNING", 0},
            {"ERROR", 0},
            {"OTRO", 0} // Para logs que no tengan un nivel definido
        };

        foreach (string log in logs)
        {
            if (log.StartsWith("INFO")) conteo["INFO"]++;
            else if (log.StartsWith("WARNING")) conteo["WARNING"]++;
            else if (log.StartsWith("ERROR")) conteo["ERROR"]++;
            else conteo["OTRO"]++;
        }

        return conteo;
    }

    // Función que muestra un reporte detallado
    static void MostrarReporte(Dictionary<string, int> conteo, string[] logs)
    {
        Console.WriteLine("\n--- Reporte de Logs ---");
        Console.WriteLine($"Total de logs: {logs.Length}");
        Console.WriteLine($"INFO: {conteo["INFO"]}");
        Console.WriteLine($"WARNING: {conteo["WARNING"]}");
        Console.WriteLine($"ERROR: {conteo["ERROR"]}");
        Console.WriteLine($"Otros: {conteo["OTRO"]}");

        Console.WriteLine("\nDetalle de logs:");
        foreach (string log in logs)
        {
            Console.WriteLine(log);
        }
    }
}
