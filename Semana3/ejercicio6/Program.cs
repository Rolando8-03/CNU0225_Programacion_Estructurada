//Pedir un número y verificar cómo se clasifica, usando if

try
{
    float num;
    Console.WriteLine("Bienvenido!");
    Console.Write("\nDime un número: ");
    num = float.Parse(Console.ReadLine()!);
    if (num > 0)
    {
        Console.WriteLine("\nEl número es positivo");
    } else if (num < 0)
    {
        Console.WriteLine("\nEl número es negativo");
    } else
    {
        Console.WriteLine("\nEl número es cero");
    }  
} catch (FormatException)
{
    Console.WriteLine("\nSolo se admiten números");

}