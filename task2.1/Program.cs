// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write ("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 8 && a > 0)
{
    switch(a)
    {
        case 1: Console.WriteLine ("Понедельник"); return;
        case 2: Console.WriteLine ("Вторник"); return;
        case 3: Console.WriteLine ("Среда"); return;
        case 4: Console.WriteLine ("Четверг"); return;
        case 5: Console.WriteLine ("Пятница"); return;
        case 6: Console.WriteLine ("Суббота"); return;
        case 7: Console.WriteLine ("Воскресенье"); return;
    }
}
else
{
    Console.WriteLine ("Число не соответствует дню недели");
}

// Версия ВАНИ