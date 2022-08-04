# Семенар 8. Задачи. 

***Домашнее задание приведино в README.md сразу с программой.***

## Задача 54. 

Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

Например, задан массив:

    1 4 7 2
    5 9 2 3
    8 4 2 4

В итоге получается вот такой массив:

    1 2 4 7
    2 3 5 9
    2 4 4 8

Код программы, для удобства копирования:

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
                        if (matrix[lin,i] > matrix[lin,j])
                        {
                            temp = matrix[lin,i];
                            matrix[lin,i] = matrix[lin,j];
                            matrix[lin,j] = temp;
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

## Задача 56.

Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Код программы, для удобства копирования:

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


## Задача 58. 

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

Код программы, для удобства копирования:

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

## Дополнительная задача

### Задача 60. 

Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

    12(0,0,0) 22(0,0,1)
    45(1,0,0) 53(1,0,1)

Код программы, для удобства копирования:

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

## Дополнительная задача

### Задача 62. 

Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

    1 2 3 4
    12 13 14 5
    11 16 15 6
    10 9 8 7

Код программы, для удобства копирования:

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








## Ниже представлены наброски к задачам:

### 58

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

    namespace Task56
    {
        class Program
        {
            public static void Main(string[] args)
            {
                int n = new Random().Next(1, 10);
                int[,] matrixA = new int[n, n];
                int[,] matrixB = new int[n, n];

                FillRandomMatrix(matrixA);
                FillRandomMatrix(matrixB);

                PrintMatrix(matrixA);

                Console.WriteLine();

                PrintMatrix(matrixB);

                Console.WriteLine();

                int[,] matrixC = MatrixMull(matrixA, matrixA);

                PrintMatrix(matrixC);
            }

            public static int[,] MatrixMull(int[,] matrixA, int[,] matrixB)
            {
                int[,] matrixC = new int[matrixA.GetLength(0), matrixA.GetLength(0)];
                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixA.GetLength(1); j++)
                    {
                        matrixC[i, j] = MatrixForm(matrixA, matrixB, i, j);
                    }
                }
                return matrixC;
            }

            public static int MatrixForm(int[,] matrixA, int[,] matrixB, int i, int j)
            {
                int summ = 0;
                for (int k = 0; k < matrixA.GetLength(0); k++)
                {
                    summ += matrixA[i, k] * matrixB[k, j];
                }
                return summ;
            }

            public static void FillRandomMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = new Random().Next(-1, 2);
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