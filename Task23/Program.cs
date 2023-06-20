/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();
Console.Write("Введите целое число N: ");
int a = int.Parse(Console.ReadLine() ??"");
int b = 0;

Console.Write($" {a} -> ");
while (b != a - 1)
{
    b++;
    Console.Write($" {b * b * b}, ");
}
b++;
Console.Write($" {b * b * b}. ");
