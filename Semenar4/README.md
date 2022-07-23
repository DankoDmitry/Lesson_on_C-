# Семенар 3. Задачи. 

***Домашнее задание приведино в README.md сразу с программой.***

## Задача 25. 

Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

    3, 5 -> 243 (3⁵)
    2, 4 -> 16

Код программы, для удобства копирования:

    namespace task25 {
        class Program {
            static void Main() {
                double nomberA = Convert.ToDouble(Console.ReadLine());          // Ввод числа А (не сказанно, что оно натуральное):
                int nomberB = Convert.ToInt32(Console.ReadLine());              // Ввод числа В (натуральное):

                double answer = 1;                                              // Ответ запишем сюда:

                for (int counter = 0; counter < nomberB; counter++) {           // Цикл:
                    answer *= nomberA;
                }

                Console.WriteLine(answer);                                      // Вывод:
            }
        }
    }

## Задача 27. 

Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    452 -> 11
    82 -> 10
    9012 -> 12

Код программы, для удобства копирования:

    namespace task27 {
        class Program {
            static void Main() {
                int nomber = Convert.ToInt32(Console.ReadLine());               // Ввод числа (натуральное):

                int answer = 0;                                                 // Ответ запишем сюда:

                while (nomber % 10 != 0) {                                      // Цикл:
                    answer += nomber % 10;
                    nomber = nomber / 10;
                }

                Console.WriteLine(answer);                                      // Вывод:
            }
        }
    }

## Задача 29.

Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) элементов (значение элементов от 1 до 40) и выводит на экран массив квадратов этих чисел.

    1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]
    6, 1, 33 -> [36, 1, 1089]

Код программы, для удобства копирования:

    namespace task29 {
        class Program {
            static void Main() {
                int size = new Random().Next(5, 11);                      // Задание псевдослучайной длины массива:
                int[] array = new int[size];                              // Создание массива псевдослучайной длины:

                FillArray(array);
                PrintArray(array);
            }
            static void PrintArray(int[] Array) {                         // Функция печати массива квадратов исходного:
                for (int i = 0; i < Array.GetLength(0); i++) {
                    Console.Write($"{Array[i] * Array[i]} ");
                }
            }

            static void FillArray(int[] Array) {                          // Функция заполнения массива:
                for (int i = 0; i < Array.GetLength(0); i++) {
                    Array[i] = new Random().Next(1,41);
                }
            }
        }
    }