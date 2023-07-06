/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();
Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = new int[len];
FillArray(array, 10, 99); 
Console.Write("Массив: ");
PrintArray(array);
SumOfOddNumbers(array);

void PrintArray(int[] array)
{
    foreach (var element in array) Console.Write($"{element} ");
    Console.WriteLine();
}
void FillArray(int[] array, int min, int max)
{
    var rand = new Random();
    for (int i = 0; i < array.Length; i++) 
        array[i] = rand.Next(min, max+1);
}

void SumOfOddNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i+=2) count = count + array[i];
    Console.WriteLine($"Сумма всех элементов, стоящих на нечётных позициях = {count}");
}
