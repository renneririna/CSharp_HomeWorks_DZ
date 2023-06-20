/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();
Console.Write("Введите трехзначное число: ");
int Value = Convert.ToInt32(Console.ReadLine());
int Length = Value.ToString().Length;

if (Length == 3) 
{
	int result = (Value/10) % 10;
	Console.WriteLine("Вторая цифра -> " + result);
} 
else 
{
	Console.WriteLine("Ошибка не трёхзначное число");
}