﻿//Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

namespace task10 {
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