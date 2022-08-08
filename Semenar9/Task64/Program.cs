//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

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