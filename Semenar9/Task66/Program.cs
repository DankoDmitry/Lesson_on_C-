//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

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