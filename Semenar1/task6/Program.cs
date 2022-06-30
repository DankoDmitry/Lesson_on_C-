//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

int nomber = Convert.ToInt32(Console.ReadLine());

if (nomber % 2 == 0) {
    Console.WriteLine("Yes");
} else {
    Console.WriteLine("No");
}