//Contar números pares e impares
//Usuario ingresa 10 números, usando if and for, y se cuenta cuándo son pares

try
{
    List<int> pares = new List<int>();
    List<int> impares = new List<int>();

    for (int i = 1; i <= 10; i++)
    {
        Console.Write($"\nIngrese el número {i}: ");
        int numero = int.Parse(Console.ReadLine()!);
        if (numero % 2 == 0)
        {
            pares.Add(numero);
        }
        else
        {
            impares.Add(numero);
        }
    }
    Console.WriteLine($"\nNúmeros pares: ");
    Console.WriteLine(string.Join(", ", pares));
    Console.WriteLine("\nEl total de números pares son: " + pares.Count);
    Console.WriteLine($"\nNúmeros impares: ");
    Console.WriteLine(string.Join(", ", impares));
    Console.WriteLine("\nEl total de números impares son: " + impares.Count);
}
catch (FormatException)
{
    Console.WriteLine("\nError: Ingrese un número válido");
}
