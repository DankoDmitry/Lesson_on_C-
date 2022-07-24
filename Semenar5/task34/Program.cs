//Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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