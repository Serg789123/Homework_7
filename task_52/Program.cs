// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] arr = new int[3, 4];
double result = 0;
double sum = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(0, 10);
    }
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine();
}
Console.Write($"Среднее арифметическое каждого столбца: ");

for (int j = 0; j < arr.GetLength(1); j++)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = sum + arr[i, j];
    }
    result = sum / arr.GetLength(0);
    Console.Write($"{Math.Round(result, 1)}; ");
    sum = 0;
}
Console.WriteLine("\b\b ");






