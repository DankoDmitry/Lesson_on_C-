//Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

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

        public static void WriteSquart(int N) {                         // Функция печати квадрата числа:
            Console.Write(N*N);
            Console.Write(" ");
        }

    }
}