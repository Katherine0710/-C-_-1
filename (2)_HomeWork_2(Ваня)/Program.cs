// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int length = a.ToString().Length;


if (length<3)
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{
    int value1 = Convert.ToInt32("1" + new string('0',length-2));
    int value2 = Convert.ToInt32("1" + new string('0',length-3));
    Console.Write((a % value1 - a % value2) / value2);
}