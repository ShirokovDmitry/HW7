// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] matrix = new int [3,4];
Console.WriteLine("Задан массив: ");
for(int i =0; i<matrix.GetLength(0); i++)
{
    for(int j =0; j<matrix.GetLength(1); j++)
    {   
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j]+ "\t"); 
    }
    Console.WriteLine();
}
Console.WriteLine("Введите номер строки: ");
int row  = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите номер столбца: ");
int column  = Convert.ToInt32(Console.ReadLine()); 

if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
{
    Console.WriteLine($"Значение: {matrix[row, column]}");
}
else
{
    Console.WriteLine($"{row}{column} -> такого числа в массиве нет");
}