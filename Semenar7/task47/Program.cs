// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

namespace Task47
{
    class Program
    {
        public static void Main()
        {
            int n = new Random().Next(1, 10);
            int m = new Random().Next(1, 10);

            double[,] matrix = new double[n, m];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(-10, 10);
                }
            }

            Console.WriteLine("m = " + m + ", n = " + n);
            PrintArray(matrix);
        }

        public static void PrintArray(double[,] args)
        {
            for (int i = 0; i < args.GetLength(0); i++)
            {
                for (int j = 0; j < args.GetLength(1); j++)
                {
                    Console.Write(args[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}