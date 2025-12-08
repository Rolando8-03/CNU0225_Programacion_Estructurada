namespace try1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("UAM");
                Console.WriteLine("-Managua");
                int num;
                Console.Write("Dime tu edad: ");
                num = Convert.ToInt32(Console.ReadLine()!);
            }
            catch (FormatException)
            {
                Console.WriteLine("Solo se aceptan valores enteros");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado: " + ex.ToString());
            }

        }
    }
}