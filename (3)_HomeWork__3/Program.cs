// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
double X = N - 1;
double numb = N - X;
double kub;

while (X >= 0)
{
    numb = N - X;
    kub = Math.Pow(numb, 3);
    Console.Write(kub + " ");
    X = X-1;
}
