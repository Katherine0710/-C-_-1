// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int length = a.ToString().Length;


if (length==1 || length==2)
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{
    Console.WriteLine(length[3]);
}
