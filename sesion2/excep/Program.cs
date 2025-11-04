namespace excep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int edad;
                string edad1;
                Console.Write("Dime tu edad: ");
                edad1 = Console.ReadLine()!;
                if (string.IsNullOrEmpty(edad1))
                {
                    Console.WriteLine("No puedes dejar el campo vacío");
                    return;
                }
                edad = int.Parse(edad1);
                if (edad < 14 && edad > 0)
                {
                    Console.WriteLine("Eres un niño");
                }
                else if (edad > 0)
                {
                    Console.WriteLine("Eres adulto");
                }
                else
                {
                    Console.WriteLine("No pongas números negativos");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Solo debes de introducir números enteros");
            }
        }
    }
}