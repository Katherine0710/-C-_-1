﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Точка 1 = (" + x1 +", " + y1 +", " + z1 + ")");
Console.WriteLine ("Точка 2 = (" + x2 + ", " + y2 +", " + z2 + ")");

double way = Math.Sqrt( (Math.Pow(x1-x2, 2)) + (Math.Pow(y1-y2, 2)) + (Math.Pow(z1-z2, 2)) );
Console.WriteLine(Math.Round(way, 2));