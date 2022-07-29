//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

namespace Task52
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = new Random().Next(1, 10),
                m = new Random().Next(1, 10);

            int[,] matrix = new int[n, m];

            FillRandomMatrix(matrix);

            Console.Write("Среднее арифметическое каждого столбца: ");
            for (int i = 0; i < n; i++)
            {
                FindColonAverage(matrix, i);
            }

        }


        public static void FindColonAverage(int[,] matrix, int colon)
        {
            double average = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                average += matrix[i, colon];
            }
            Console.Write(average + " ");
        }
        public static void FillRandomMatrix(int[,] matrix)
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