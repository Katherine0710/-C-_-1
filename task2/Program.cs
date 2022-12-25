// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write ("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
    {
        Console.WriteLine ("Сегодня понедельник");
    }
if (a == 2)
    {
        Console.WriteLine ("Сегодня вторник");
    }
if (a == 3)
    {
        Console.WriteLine ("Сегодня среда");
    }
if (a == 4)
    {
        Console.WriteLine ("Сегодня четверг");
    }
if (a == 5)
    {
        Console.WriteLine ("Сегодня пятница");
    }
if (a == 6)
    {
        Console.WriteLine ("Сегодня суббота");
    }
if (a == 7)
    {
        Console.WriteLine ("Сегодня восресенье");
    }
if (a > 7 || a < 1)
    {
        Console.WriteLine ("Число не соответствует дню недели");
    }
