// Задача не решена!!! Вернуться позже!!!
/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

Console.Clear();
Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
double[] array = new double[len];
FillArray(array, -10, 99);
Console.Write("Массив: ");
PrintArray(array);

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Минимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");

void PrintArray(double[] array)
{
    foreach (var element in array) Console.Write($"{element} ");
    Console.WriteLine();
}
void FillArray(double[] array, int min, int max)
{
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(min, max + 1);
}
