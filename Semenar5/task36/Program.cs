//Задача 36. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


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