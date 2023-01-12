// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
double X = N - 1;
double numb = N - X;
double square;

while (X >= 0)
{
    numb = N - X;
    square = Math.Pow(numb, 2);
    Console.Write(square + " ");
    X = X-1;
}
