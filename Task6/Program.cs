/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.Clear();
Console.Write("Введите число: ");
string userInput = Console.ReadLine() ??"";
int Number = int.Parse(userInput);

if (Number % 2 == 1)
{
Console.WriteLine("Число " + Number + " является НЕчетным -> нет");
}
else
{
Console.WriteLine("Число " + Number + " является четным -> да");
}