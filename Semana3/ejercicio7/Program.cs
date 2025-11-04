//Solicitar calificaciones usando while y promedio
try
{
    int total;
    int contador = 0;
    float calificacion;
    float suma = 0;
    float promedio;
    Console.WriteLine("Bienvenido!");
    Console.Write("\n¿Cuántas calificaciones desea agregar? ");
    total = int.Parse(Console.ReadLine()!);
    if (total < 0)
    {
        Console.WriteLine("Error: No puedes poner números negativos");
        return;
    }
    while (contador < total)
    {
        Console.Write($"\nIngrese la calificación {contador + 1}: ");
        calificacion = float.Parse(Console.ReadLine()!);
        if (calificacion < 0 || calificacion > 100)
        {
            Console.WriteLine("El rango de calificaciones es de 0 a 100");
            return;
        }
        else
        {
            suma += calificacion;
            contador++;
        }
    }
    promedio = suma / total;
    Console.WriteLine($"\nEl promedio de las calificaciones es: {promedio:F2}");
}
catch (FormatException)
{
    Console.WriteLine("Error: Ingrese un número válido.");
}
