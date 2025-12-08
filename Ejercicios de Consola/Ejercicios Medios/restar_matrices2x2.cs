using System;

class RestarMatrices2x2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Matriz A:");
        double[,] A = LeerMatriz();

        Console.WriteLine("\nMatriz B:");
        double[,] B = LeerMatriz();

        double[,] R = RestarMatrices(A, B);

        Console.WriteLine("\nResultado de A - B:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(R[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }

    // Leer una matriz 2x2 validando números
    static double[,] LeerMatriz()
    {
        double[,] M = new double[2, 2];
        double valor;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                while (true)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    if (double.TryParse(Console.ReadLine(), out valor))
                    {
                        M[i, j] = valor;
                        break;
                    }
                    Console.WriteLine("Error: ingrese un número válido.");
                }
            }
        }
        return M;
    }

    // Restar matrices A - B
    static double[,] RestarMatrices(double[,] A, double[,] B)
    {
        double[,] R = new double[2, 2];

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                R[i, j] = A[i, j] - B[i, j];

        return R;
    }
}
