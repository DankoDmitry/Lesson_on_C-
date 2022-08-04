/*Дополнительная задача
Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4        1 2 3
12 13 14 5     8 9 4
11 16 15 6     7 6 5
10 9 8 7*/

namespace DopTask2
{
    class Program
    {
        public static void Main()
        {
            int n = 4, s = 1;
            int[,] matrix = new int[n, n];

            //Заполняем периметр массива по часовой стрелке.
            for (int y = 0; y < n; y++)
            {
                matrix[0, y] = s;
                s++;
            }
            for (int x = 1; x < n; x++)
            {
                matrix[x, n - 1] = s;
                s++;
            }
            for (int y = n - 2; y >= 0; y--)
            {
                matrix[n - 1, y] = s;
                s++;
            }
            for (int x = n - 2; x > 0; x--)
            {
                matrix[x, 0] = s;
                s++;
            }

            int c = 1;
            int d = 1;

            while (s < n * n)
            {
                while (matrix[c, d + 1] == 0)
                {
                    matrix[c, d] = s;
                    s++;
                    d++;
                }

                //Движемся вниз.
                while (matrix[c + 1, d] == 0)
                {
                    matrix[c, d] = s;
                    s++;
                    c++;
                }

                //Движемся влево.
                while (matrix[c, d - 1] == 0)
                {
                    matrix[c, d] = s;
                    s++;
                    d--;
                }

                //Движемся вверх.
                while (matrix[c - 1, d] == 0)
                {
                    matrix[c, d] = s;
                    s++;
                    c--;
                }
            }
            matrix[c, d] = s++;

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