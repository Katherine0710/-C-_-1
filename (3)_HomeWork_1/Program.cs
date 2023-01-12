// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int chislo = Convert.ToInt32(Console.ReadLine());

int length = chislo.ToString().Length;

if (length == 5)
{
    int first = (chislo-chislo%1000)/1000;
    int second = chislo%10;
    if ((first-first%10)/10 == second%10 || first%10 == (second-second%10)/10)
    {
        Console.WriteLine(chislo + " - палиндром");
    }
    else
    {
        Console.WriteLine(chislo + " - не палиндром");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}