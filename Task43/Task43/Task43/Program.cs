// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
using System;
Console.WriteLine("Введите b1");
double b1 = ReadInt();
Console.WriteLine("Введите k1");
double k1 = ReadInt();
Console.WriteLine("Введите b2");
double b2 = ReadInt();
Console.WriteLine("Введите k2");
double k2 = ReadInt();
double x = ((b2 - b1) / (k1 - k2));
double y = ((k1*x) + b1);


Console.Write($"{x}; ");
Console.WriteLine($" {y}");

double ReadInt()
{
    string s = Console.ReadLine();

    if (double.TryParse(s, out double i))
        return i;

    return -1;
}