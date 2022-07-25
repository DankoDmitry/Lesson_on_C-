# Семенар 6. Задачи. 

***Домашнее задание приведино в README.md сразу с программой.***

## Задача 41. 

    Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

        0, 7, 8, -2, -2 -> 2
        1, -7, 567, 89, 223-> 3

Код программы, для удобства копирования:

    namespace Task41
    {
        class Program
        {
            public static void Main()
            {
                const int M = 5;

                int[] array = new int[M];

                InputArray(array);

                CounterNombers(array);
            }

            public static void InputArray(int[] array)
            {
                string imp = Console.ReadLine();

                var text = imp.Split(" ");

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    array[i] = Convert.ToInt32(text[i]);
                }
            }

            public static void CounterNombers(int[] array)
            {
                int counter = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i] > 0) counter++;
                }
                Console.WriteLine(counter);
            }
        }
    }

## Задача 43. 

Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Код программы, для удобства копирования:

    namespace Task43
    {
        class Program
        {
            public static void Main()
            {
                double b1, k1, b2, k2;

                Console.Write("b1 = ");
                b1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("k1 = ");
                k1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("b2 = ");
                b2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("k2 = ");
                k2 = Convert.ToDouble(Console.ReadLine());
                    
                double coordinateX, coordinateY;

                coordinateX = (b2 - b1) / (k1 - k2);
                coordinateY = k1 * coordinateX + b1;

                Console.WriteLine(" -> (" + coordinateX + "; " + coordinateY + ")");
            }
        }
    }