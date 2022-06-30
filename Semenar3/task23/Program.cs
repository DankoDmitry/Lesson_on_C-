//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

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