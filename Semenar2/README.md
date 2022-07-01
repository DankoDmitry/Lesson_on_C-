# Семенар 2. Задачи. 

***Домашнее задание приведино в README.md сразу в программой.***

## Задача 10. 

Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    456 -> 5
    782 -> 8
    918 -> 1

Код программы, для удобства копирования:

    namespace task19 {
        class Program {
            static void Main(string[] args) {
                int nomber = Convert.ToInt32(Console.ReadLine());

                if (nomber > 999 || nomber < 100) {
                    Console.WriteLine("We cannot");
                } else {
                    Console.WriteLine((nomber / 10) % 10);
                }
            }
        }
    }

## Задача 13. 

Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6

Код программы, для удобства копирования:

    namespace task13 {
        class Program {
            static void Main(string[] args) {
                string nomber = Console.ReadLine();

                if (nomber.Length > 2) {
                    Console.WriteLine(nomber[2]);
                } else {
                    Console.WriteLine("Третьей цифры нет");
                }
            }
        }
    }

## Задача 15. 

Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

    6 -> да
    7 -> да
    1 -> нет

Код программы, для удобства копирования:

    namespace task15 {
        class Program {
            static void Main(string[] args) {
                int nomber = Convert.ToInt32(Console.ReadLine());

                if (nomber > 7 || nomber < 1) {
                    Console.WriteLine("Это не день недели");
                } else if (nomber < 6) {
                    Console.WriteLine("Нет");
                } else {
                    Console.WriteLine("Да");
                }
            }
        }
    }