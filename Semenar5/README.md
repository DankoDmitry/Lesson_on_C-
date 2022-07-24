# Семенар 5. Задачи. 

***Домашнее задание приведино в README.md сразу с программой.***

## Задача 34.

Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

    [345, 897, 568, 234] -> 2

Код программы, для удобства копирования:

    namespace task34
    {
        class Program
        {
            public static void Main()
            {
                int[] args = new int[new Random().Next(1, 20)];

                FillArrayRandom(args);

                EvenNombersCounter(args);
            }

            public static void FillArrayRandom(int[] args)
            {
                for (int i = 0; i < args.GetLength(0); i++)
                {
                    args[i] = new Random().Next(100, 1000);
                }
            }

            public static void EvenNombersCounter(int[] args)
            {
                int counter = 0;
                for (int i = 0; i < args.GetLength(0); i++)
                {
                    if (args[i] % 2 == 0) counter++;
                    Console.Write(args[i] + " ");
                }
                Console.WriteLine(" -> " + counter);
            }
        }
    }

## Задача 36.

Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0

Код программы, для удобства копирования:

    namespace task36
    {
        class Program
        {
            public static void Main()
            {
                int[] args = new int[new Random().Next(1, 20)];

                FillArrayRandom(args);

                UnEvenNombersSum(args);
            }

            public static void FillArrayRandom(int[] args)
            {
                for (int i = 0; i < args.GetLength(0); i++)
                {
                    args[i] = new Random().Next(-9, 10);
                }
            }

            public static void UnEvenNombersSum(int[] args)
            {
                int summ = 0;
                for (int i = 0; i < args.GetLength(0); i++)
                {
                    if (i % 2 == 0) summ += args[i];
                    Console.Write(args[i] + " ");
                }
                Console.WriteLine(" -> " + summ);
            }
        }
    }

## Задача 38. 

Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

    [3 7 22 2 78] -> 76

Код программы, для удобства копирования:

    namespace task38
    {
        class Program
        {
            public static void Main()
            {
                double[] array = new double[new Random().Next(1, 21)];

                FillArrayRandomNumber(array);

                double v = FindMaxNomber(array) - FindMinNomber(array);
                Console.WriteLine("-> " + v);
            }

            public static void FillArrayRandomNumber(double[] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    array[i] = new Random().Next(-999, 1000);
                    Console.Write(array[i] + " ");
                }
            }

            public static double FindMaxNomber(double[] array)
            {
                double maxNomber = array[0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i] > maxNomber)
                    {
                        maxNomber = array[i];
                    }
                }
                return maxNomber;
            }
            public static double FindMinNomber(double[] array)
            {
                double minNomber = array[0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i] < minNomber)
                    {
                        minNomber = array[i];
                    }
                }
                return minNomber;
            }
        }
    }