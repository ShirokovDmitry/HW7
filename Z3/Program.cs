// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, {8, 4, 2, 4 } };
Console.WriteLine("Задан массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    sum = sum / arr.GetLength(0);
    Console.Write($" {sum.ToString("0.00")}");
}