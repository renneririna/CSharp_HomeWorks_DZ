/* 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 
*/

Console.Clear();
Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = new int[len];
FillArray(array, 100, 999); 
Console.Write("Массив: ");

void PrintArray(int[] array)
{
    foreach (var element in array) 
        Console.Write($"{element} ");
        Console.WriteLine();
}
void FillArray(int[] array, int min, int max)
{
    var rand = new Random();
    for (int i = 0; i < array.Length; i++) 
        array[i] = rand.Next(min, max+1);
}

void FindEven(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] %2 == 0)
        {
            count = count + 1;
        }
    }
    Console.WriteLine($"Чётных чисел {count}");
    }

PrintArray(array);
FindEven(array);


