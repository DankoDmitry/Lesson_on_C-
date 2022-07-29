//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

namespace Task50
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = new Random().Next(1, 10);
            int m = new Random().Next(1, 10);

            double[,] matrix = new double[n, m];

            FillRandomMatrix(matrix);
            Console.WriteLine("n = " + n + ", m = " + m);
            PrintMatrix(matrix);

            PrintNomberOfMatrix(matrix);
        }


        public static void PrintNomberOfMatrix(double[,] matrix)
        {
            Console.WriteLine("Введите позицию элемента:");
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());

            if (n <= matrix.GetLength(0)
                && m <= matrix.GetLength(1)
                && n > 0
                && m > 0)
            {
                Console.WriteLine(" -> " + matrix[n - 1, m - 1]);
            }
            else
            {
                Console.WriteLine(" -> такого числа в массиве нет");
            }
        }
        public static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void FillRandomMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(-10, 10);
                }
            }
        }
    }
}