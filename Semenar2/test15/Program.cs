//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

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