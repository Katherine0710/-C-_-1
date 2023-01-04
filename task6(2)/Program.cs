// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);
Console.WriteLine("Ваше случайное число: " + number);
int  digit1 = number/100;
int digit3 = number%10;

Console.WriteLine (digit1*10 + digit3);

// Например число 456
// digit1 = 4, digit3 = 6
// 4*10 = 40 + 6 = 46