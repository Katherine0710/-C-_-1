// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int length = a.ToString().Length;

while (length != 3)
{
    Console.WriteLine ("Вы ввели не трёхзначное число.");
    Console.Write("Повторите ввод: ");
    a = Convert.ToInt32(Console.ReadLine());
    length = a.ToString().Length;
}

int digit2 = a/10 - a/100*10;
Console.WriteLine ("Вторая цифрав числе: " + digit2);
