/* 
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");

Console.Write($"N = {num} -> {RecursNto1(num)}");

string RecursNto1(int start)
{
    if (start == 1)
        return start.ToString();
    return start + ", " + RecursNto1(start - 1);
}


/*
// Задача из 9-го семинара по рекурсии
// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int value = int.Parse(Console.ReadLine()??"");

Console.Write($"{value} -> {GetNum(1, value)}");

string GetNum(int start, int end)
{
    if (start == end)
        return start.ToString();
    return start + ", " + GetNum(start + 1, value);
}
*/

