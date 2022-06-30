//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. (не включая N)

//5 -> 2, 4
//8 -> 2, 4, 6

//Считаем, что поумолчанию (N) не менее 2.

int nomberN = Convert.ToInt32(Console.ReadLine());
int counter = 2;

while (counter < nomberN) {
    Console.Write(counter);
    Console.Write(" ");
    counter = counter + 2;
}