# Семенар 9. Задачи. 

***Домашнее задание приведино в README.md сразу с программой.***

## Задача 64.

Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

    M = 1; N = 5. -> ""1, 2, 3, 4, 5""
    M = 4; N = 8. -> ""4, 6, 7, 8""

Код программы, для удобства копирования:

    namespace Task64
    {
        class Program
        {
            public static void Main()
            {
                const int M = 1, N = 100;

                for (int i = M; i < N; i++)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }

## Задача 66.

Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30

Код программы, для удобства копирования:

    namespace Task66
    {
        class Program
        {
            public static void Main()
            {
                const int M = 1, N = 100;
                int summ = 0;

                for (int i = M; i < N; i++)
                {
                    summ += i;
                }

                Console.WriteLine(summ);
            }
        }
    }

## Задача 68.

Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

    m = 2, n = 3 -> A(m,n) = 29

Код программы, для удобства копирования:

    namespace Task68
    {
        class Program
        {
            public static void Main()
            {
                const int N = 2, M = 3;

                Console.WriteLine(AkkermanFanction(M, N));
            }

            public static int AkkermanFanction(int m, int n)
            {
                if (m < 0 || n < 0) return 0;
                if (m == 0) return n + 1;
                if (n == 0 && m > 0) return AkkermanFanction(m - 1, 1);
                return AkkermanFanction(m - 1, AkkermanFanction(m, n - 1));
            }
        }
    }
