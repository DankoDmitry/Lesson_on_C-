//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

namespace task1 {
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