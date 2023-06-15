/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Clear();
Console.Write("Введите первое целое число: ");
string userInput1 = Console.ReadLine() ??"";
int a = int.Parse(userInput1);

Console.Write("Введите второе целое число: ");
string userInput2 = Console.ReadLine() ??"";
int b = int.Parse(userInput2);

if (a > b) 
{
Console.WriteLine("Первое число " + a + " больше чем второе " + b);
}
else
{
Console.WriteLine("Второе число " + b + " больше чем первое " + a);
}