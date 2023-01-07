// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a>7 || a<1)
{
    Console.WriteLine("Число не соответствует дню недели");
    Console.Write("Повторите ввод: "); 
    a = Convert.ToInt32(Console.ReadLine());
}

if (a==6 || a == 7)
{
    Console.WriteLine("Выходной день");
}
else 
{
    Console.WriteLine("Рабочий день");
}