//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

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