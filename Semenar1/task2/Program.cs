﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

// Принимает 2 целых числа!!!

int nomberA = Convert.ToInt32(Console.ReadLine());
int nomberB = Convert.ToInt32(Console.ReadLine());

if (nomberA > nomberB) {
    Console.WriteLine(nomberA);
} else {
    Console.WriteLine(nomberB);
}
