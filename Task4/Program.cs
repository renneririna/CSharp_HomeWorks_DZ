﻿/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Clear();
Console.Write("Введите первое целое число: ");
string userInput1 = Console.ReadLine() ??"";
int a = int.Parse(userInput1);

Console.Write("Введите второе целое число: ");
string userInput2 = Console.ReadLine() ??"";
int b = int.Parse(userInput2);

Console.Write("Введите третье целое число: ");
string userInput3 = Console.ReadLine() ??"";
int c = int.Parse(userInput3);

int max = a;

if (b > max)
{
max = b;
}

if (c > max)
{
max = c;
}

Console.WriteLine("Максимальное из этих чисел -> " + max);
