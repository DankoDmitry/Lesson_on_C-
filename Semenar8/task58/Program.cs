/*## Задача 58. 
Задайте две матрицы. Напишите программу, которая выведет матрицу произведения элементов двух предыдущих матриц.
Например, заданы 2 массива:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
и
    1 5 8 5
    4 9 4 2
    7 2 2 6
    2 3 4 7
Их произведение будет равно следующему массиву:
    1 20 56 10
    20 81 8 6
    56 8 4 24
    10 6 24 49
*/

using System.Windows;

namespace Task58
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = new Random().Next(1, 10);
            int m = new Random().Next(1, 10);
            int k = new Random().Next(1, 10);
            int[,] matrixA = new int[n, m];
            int[,] matrixB = new int[m, k];

            FillRandomMatrix(matrixA);
            FillRandomMatrix(matrixB);
            PrintMatrix(matrixA);
            Console.WriteLine();
            PrintMatrix(matrixB);
            Console.WriteLine();

            MatrixMull(matrixA, matrixB);
        }

        public static void MatrixMull(int[,] matrixA, int[,] matrixB)
        {
            int[,] matrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixA.GetLength(1); k++)
                    {
                        counter += matrixA[i, k] * matrixB[k, j];
                    }
                    matrix[i, j] = counter;
                    counter = 0;
                }
            }
            PrintMatrix(matrix);
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