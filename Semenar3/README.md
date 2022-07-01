# Семенар 3. Задачи. 

***Домашнее задание приведино в README.md сразу в программой.***

## Задача 18. 

Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

## Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    14212 -> нет
    12821 -> да
    23432 -> да

Код программы, для удобства копирования:

    namespace task19 {
        class Program {
            static void Main(string[] args) {
                int nomberN = Convert.ToInt32(Console.ReadLine());                         // Ввод числа:

                if (nomberN < 10000 || nomberN > 99999) {                                  // Первая скорая проверка на достоверность ввода
                    Console.WriteLine("This nomber is not polindrom length five");
                } else if (nomberN % 10 == nomberN / 10000 & (nomberN / 10) % 10 == (nomberN / 1000) % 10) {
                    Console.WriteLine("Yes");
                } else {
                    Console.WriteLine("No");
                }
            }
        }
    }

## Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53

Код программы, для удобства копирования:

    namespace task19 {
        class Program {
            static void Main(string[] args) {
                float[] A = new float[3];
                float[] B = new float[3];

                Console.WriteLine("Введите координаты А через Entr:");
                for (int i = 0; i < 3; i++) {
                    A[i] = Convert.ToInt32(Console.ReadLine());
                }     
                Console.WriteLine("Введите координаты B через Entr:");
                for (int i = 0; i < 3; i++) {
                    B[i] = Convert.ToInt32(Console.ReadLine());
                }       

                float S = 0;

                for (int i = 0; i < 3; i++) {
                    S += (A[i] - B[i]) * (A[i] - B[i]);
                }

                Console.WriteLine("Растояние между А и В: " + MathF.Sqrt(S));
            }
        }
    }

## Задача 22.

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

    5 -> 1, 4, 9, 16, 25.
    2 -> 1,4

## Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

Код программы, для удобства копирования:

    namespace task1 {
        class Program {
            static void Main(string[] args) {
                int nomberN = Convert.ToInt32(Console.ReadLine());          // Ввод длины последовательности:

                int counter = 1;
                while (counter <= nomberN) {                                // Перебор циклом цисел по последовательности
                    WriteSquart(counter);
                    counter++;
                }
            }

            public static void WriteSquart(int N) {                         // Функция печати куба числа:
                Console.Write(N*N*N);
                Console.Write(" ");
            }

        }
    }