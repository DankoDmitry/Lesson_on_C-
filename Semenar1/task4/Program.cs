//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

// Принимает 3 целых числа!!!

int nomberA = Convert.ToInt32(Console.ReadLine());
int nomberB = Convert.ToInt32(Console.ReadLine());
int nomberC = Convert.ToInt32(Console.ReadLine());

if (nomberA > nomberB) {
    if (nomberA > nomberC) {
        Console.WriteLine(nomberC);
    } else {
        Console.WriteLine(nomberA);
    }
} else {
    if (nomberB > nomberC) {
        Console.WriteLine(nomberB);
    } else {
        Console.WriteLine(nomberC);
    }
}