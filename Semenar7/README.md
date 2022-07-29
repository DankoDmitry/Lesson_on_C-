# Семенар 7. Задачи. 

***Домашнее задание приведино в README.md сразу с программой.***

## Задача 47. 

Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9

Код программы, для удобства копирования:

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

## Задача 50. 

Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    17 -> такого числа в массиве нет

Код программы, для удобства копирования:

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

## Задача 52. 

Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Код программы, для удобства копирования:

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