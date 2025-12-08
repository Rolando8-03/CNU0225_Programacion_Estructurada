using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== CÁLCULO DE SALARIO NETO ===\n");
        
        Console.Write("¿Cuántos productos diferentes vende? ");
        int numProductos = int.Parse(Console.ReadLine());
        
        double totalVentas = 0;
        
        for (int i = 1; i <= numProductos; i++)
        {
            Console.WriteLine($"\n--- Producto {i} ---");
            Console.Write("Costo unitario: $");
            double costoUnitario = double.Parse(Console.ReadLine());
            
            Console.Write("Cantidad vendida: ");
            int cantidadVendida = int.Parse(Console.ReadLine());
            
            double subtotal = costoUnitario * cantidadVendida;
            totalVentas += subtotal;
            
            Console.WriteLine($"Subtotal producto {i}: ${subtotal:F2}");
        }
        
        Console.WriteLine($"\nTOTAL DE VENTAS: ${totalVentas:F2}");
        
        Console.Write("\nIngrese el total de deducciones: $");
        double deducciones = double.Parse(Console.ReadLine());
        
        double salarioNeto = totalVentas - deducciones;
        
        Console.WriteLine("\n=== RESUMEN ===");
        Console.WriteLine($"Total ventas: ${totalVentas:F2}");
        Console.WriteLine($"Deducciones: ${deducciones:F2}");
        Console.WriteLine($"SALARIO NETO: ${salarioNeto:F2}");
        
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}