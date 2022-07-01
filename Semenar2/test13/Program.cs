//Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

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