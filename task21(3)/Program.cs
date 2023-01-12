// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Точка 1 = (" + x1 +", " + y1 + ")");
Console.WriteLine ("Точка 2 = (" + x2 + ", " + y2 + ")");

double way = Math.Sqrt( (Math.Pow(x1-x2, 2)) + (Math.Pow(y1-y2, 2)) );
Console.WriteLine(Math.Round(way, 2));

