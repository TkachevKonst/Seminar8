// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
using System;
using static System.Console;
Clear();
Write("Введите кличество строк:");
int row = int.Parse(ReadLine());
Write("Введите кличество cтолбцов:");
int collums = int.Parse(ReadLine());
int[,] matrix = new int[row, collums];
GetArray(matrix, 0, 99);
PrintArray(matrix);
WriteLine();
int minimalrow = MinSum(matrix);
WriteLine();
PrintMinSum(matrix);
WriteLine();
WriteLine($"{minimalrow + 1}  строка с минимальной суммой в массиве");

void GetArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($" {array[i, j]}");
        }
        WriteLine();
    }
}
int MinSum(int[,] array)
{
    int minrow = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        minsum += array[0, i];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumrow = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumrow += array[i, j];
        }
        if (sumrow < minsum)
        {
            minsum = sumrow;
            minrow = i;
        }
    }
    return minrow;
}
void PrintMinSum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumrow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumrow += array[i, j];
        }
        WriteLine($"Сумма {i + 1} строки = {sumrow}");
    }
}