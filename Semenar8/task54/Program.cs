/*## Задача 54. 
Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
В итоге получается вот такой массив:
    1 2 4 7
    2 3 5 9
    2 4 4 8
*/

namespace Task54
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

            ArrangeElementsInMatrix(matrix);
            PrintMatrix(matrix);
        }

        public static void ArrangeElementsInMatrix(int[,] matrix)
        {
            for (int lion = 0; lion < matrix.GetLength(0); lion++)
            {
                ArrangeElementsInMatrixLin(matrix, lion);
            }
        }

        public static void ArrangeElementsInMatrixLin(int[,] matrix, int lin)
        {
            int temp;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[lin, i] > matrix[lin, j])
                    {
                        temp = matrix[lin, i];
                        matrix[lin, i] = matrix[lin, j];
                        matrix[lin, j] = temp;
                    }
                }
            }
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