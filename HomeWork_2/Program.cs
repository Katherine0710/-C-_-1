// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write ("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max;

if (a > b)
{
    if (a > c)
    {
        max = a;
        Console.WriteLine("Максимальное число " + max);
    }
    else
    {
        max = c;
        Console.WriteLine("Максимальное число " + max);
    }
}
else
{
    if (b > c)
    {
        max = b;
        Console.WriteLine("Максимальное число " + max);
    }
    else
    {
        max=c;
        Console.WriteLine("Максимальное число " + max);
    }    
}