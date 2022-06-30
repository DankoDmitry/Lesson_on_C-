//Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//          причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

namespace task1 {
    class Program {
        static void Main(string[] args) {
            int nomberX = Convert.ToInt32(Console.ReadLine());      // Ввод чисел:
            int nomberY = Convert.ToInt32(Console.ReadLine());

            if (nomberX == 0 || nomberY == 0) {                     // Проверка на корректность ввода: 
                Console.WriteLine("We don't know");
            } else {
                if (nomberX > 0) {                                  // Начало проверки на введение:
                    if (nomberY > 0) {
                        Console.WriteLine(1);
                    } else {
                        Console.WriteLine(4);
                    }
                } else {
                    if (nomberY > 0) {
                        Console.WriteLine(2);
                    } else {
                        Console.WriteLine(3);
                    }
                }
            }
        }
    }
}