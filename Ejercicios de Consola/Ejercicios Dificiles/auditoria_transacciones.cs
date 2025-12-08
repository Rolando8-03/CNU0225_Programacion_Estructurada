using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<string> transacciones = IngresarTransacciones(); // Función para ingresar transacciones
        List<string> errores = AuditarTransacciones(transacciones); // Función que audita y detecta anomalías
        GenerarReporte(errores); // Función que muestra el reporte
    }

    // Función para ingresar transacciones
    // Formato esperado: "2025-12-04,100.50" (fecha, monto)
    static List<string> IngresarTransacciones()
    {
        List<string> lista = new List<string>();
        Console.WriteLine("Ingrese las transacciones (formato 'AAAA-MM-DD,monto'). Escriba 'fin' para terminar:");

        while (true)
        {
            string linea = Console.ReadLine();
            if (linea.ToLower() == "fin") break;
            lista.Add(linea);
        }

        return lista;
    }

    // Función que audita las transacciones y retorna las anomalías
    static List<string> AuditarTransacciones(List<string> transacciones)
    {
        List<string> errores = new List<string>();

        for (int i = 0; i < transacciones.Count; i++)
        {
            string t = transacciones[i];
            string[] partes = t.Split(',');

            if (partes.Length != 2)
            {
                errores.Add($"Transacción {i + 1}: Formato incorrecto.");
                continue;
            }

            // Validar fecha
            if (!DateTime.TryParseExact(partes[0], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
            {
                errores.Add($"Transacción {i + 1}: Fecha inválida ('{partes[0]}').");
            }

            // Validar monto
            if (!decimal.TryParse(partes[1], out decimal monto))
            {
                errores.Add($"Transacción {i + 1}: Monto inválido ('{partes[1]}').");
            }
            else if (monto < 0)
            {
                errores.Add($"Transacción {i + 1}: Monto negativo ({monto}).");
            }
        }

        return errores;
    }

    // Función que genera un reporte con las anomalías encontradas
    static void GenerarReporte(List<string> errores)
    {
        Console.WriteLine("\n--- Reporte de Auditoría ---");
        if (errores.Count == 0)
        {
            Console.WriteLine("No se encontraron anomalías.");
        }
        else
        {
            Console.WriteLine($"Se encontraron {errores.Count} anomalía(s):");
            foreach (string error in errores)
            {
                Console.WriteLine(error);
            }
        }
    }
}
