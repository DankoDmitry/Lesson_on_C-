/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)

Дополнительная задача
Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7*/

namespace DopTask1
{
    class Program
    {
        public static void Main()
        {
            int n = new Random().Next(2, 3);
            int[,,] matrix = new int[n, n, n];
            int a = 20;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        matrix[i, j, k] = a++;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        Console.Write(matrix[i, j, k] + "(" + i + ", " + j + ", " + k + ") ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}