/*Задача 56.

Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

namespace Task56
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = new Random().Next(1, 10);
            int m = new Random().Next(1, 10);
            int[,] matrix = new int[n, m];

            FillRandomMatrix(matrix);
            PrintMatrix(matrix);

            Console.WriteLine();

            MinSumElementsInMatrixLion(matrix);
        }

        public static void MinSumElementsInMatrixLion(int[,] matrix)
        {
            int l = 1;
            int min = SummInMatrixLin(matrix, 0);
            for (int lion = 1; lion < matrix.GetLength(0); lion++)
            {
                if (SummInMatrixLin(matrix, lion) < min)
                {
                    min = SummInMatrixLin(matrix, lion);
                    l = lion + 1;
                }
            }
            Console.WriteLine("Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: " + l);

        }

        public static int SummInMatrixLin(int[,] matrix, int lin)
        {
            int summ = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                summ += matrix[lin, i];
            }
            return summ;
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

        public static void PrintMatrix(int[,] matrix)
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
    }
}