﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write ("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
int numb = a%b;

if (numb == 0)
{
    Console.WriteLine("Число 2 кратно числу 1");
}
else
{
    Console.WriteLine("Число 2 не кратно числу 1");
    Console.WriteLine("Остаток от деления: " + numb);
}

