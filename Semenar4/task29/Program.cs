//Задача 29: Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) 
//элементов (значение элементов от 1 до 40) и выводит на экран массив квадратов этих чисел.
//1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]
//6, 1, 33 -> [36, 1, 1089]

namespace task29
{
    class Program
    {
        static void Main()
        {
            int size = new Random().Next(5, 11);                      // Задание псевдослучайной длины массива:
            int[] array = new int[size];                              // Создание массива псевдослучайной длины:

            FillArray(array);
            PrintArray(array);
        }
        static void PrintArray(int[] Array)
        {                         // Функция печати массива квадратов исходного:
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                Console.Write($"{Array[i] * Array[i]} ");
            }
        }

        static void FillArray(int[] Array)
        {                          // Функция заполнения массива:
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                Array[i] = new Random().Next(1, 41);
            }
        }
    }
}