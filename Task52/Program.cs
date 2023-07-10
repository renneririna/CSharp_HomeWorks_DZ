/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();
Console.Write("Введите число столбцов: ");
var n = int.Parse(Console.ReadLine());
Console.Write("Введите число сторк: ");
var m = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
GetArray(array, 0, 9);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();
GetArithmeticMeanOfColumnsArray(array);

void GetArray(int[,] array, int min, int max)
{
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = rand.Next(min, max + 1);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

void GetArithmeticMeanOfColumnsArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++) // Это столбцы
    {
        for (int j = 0; j < array.GetLength(0); j++) // Это строки
        {
            sum += array[j, i];
        }
        Console.WriteLine($"Среденее арифметичекое {i + 1} столбца = {(float)sum / array.GetLength(0)}");
        sum = 0;
    }
}