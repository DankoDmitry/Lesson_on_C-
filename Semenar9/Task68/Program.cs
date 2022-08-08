//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29


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