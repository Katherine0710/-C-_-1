﻿// Напишите программу, которая принимает на вход координаты (X и Y), причём X и У не равно 0 и выдаёт номер плоскости четверти, в которой находится точка

// 1-ая четверть: X > 0, Y > 0
// 2-ая четверть: X < 0, Y > 0
// 3-ая четверть: X < 0, Y < 0
// 4-ая четверть: X > 0, Y < 0

Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 || y>0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if (x<0 || y>0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
else if (x<0 || y<0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}
else 
{
    Console.WriteLine("Точка находится в четвёртой четверти");
}