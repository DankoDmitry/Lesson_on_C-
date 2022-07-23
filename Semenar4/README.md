# Семенар 3. Задачи. 

***Домашнее задание приведино в README.md сразу с программой.***

## Задача 25. 

Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

    3, 5 -> 243 (3⁵)
    2, 4 -> 16

Код программы, для удобства копирования:

    namespace task25 {
        class Program {
            static void Main() {
                double nomberA = Convert.ToDouble(Console.ReadLine());          // Ввод числа А (не сказанно, что оно натуральное):
                int nomberB = Convert.ToInt32(Console.ReadLine());              // Ввод числа В (натуральное):

                double answer = 1;                                              // Ответ запишем сюда:

                for (int counter = 0; counter < nomberB; counter++) {           // Цикл:
                    answer *= nomberA;
                }

                Console.WriteLine(answer);                                      // Вывод:
            }
        }
    }