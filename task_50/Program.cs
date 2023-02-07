// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
//  Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// 1 1 -> 9

Console.Write("Введите индекс строки m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс элемента в строке n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] arr = new int[4, 5];

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
Console.WriteLine();

if (m < arr.GetLength(0) && n < arr.GetLength(1))
{
    Console.WriteLine($"элемент с индексом (m,n): {arr[m, n]}");
}
else
{
    Console.WriteLine($"такого числа в массиве нет");
}
Console.WriteLine();