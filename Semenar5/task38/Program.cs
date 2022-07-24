//Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

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