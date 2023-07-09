// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
using System;
using static System.Console;
Clear();
Write("Введите кличество строк:");
int row = int.Parse(ReadLine());
Write("Введите кличество cтолбцов:");
int collums = int.Parse(ReadLine());
int[,] matrix = new int[row, collums];
GetArray(matrix);
PrintArray(matrix);



void GetArray(int[,] array)
{
    int i = 0;
    int j = 0;
    int ibegin = 0;
    int jbegin = 0;
    int num = 0;
    while (num != array.GetLength(0) * array.GetLength(1))
    {num++;
        array[i, j] = num;
        if (i == ibegin && j < array.GetLength(1)-1 - jbegin)
        {
            j++;
        }
        else if (j == array.GetLength(1)-1 - jbegin && i < array.GetLength(0) -1- ibegin)
        {
            i++;
        }
        else if (i == array.GetLength(0)-1 - ibegin && j != jbegin)
        {
            j--;
        }
        else
        {
            i--;
        }
        if (i == ibegin + 1 && j == jbegin)
        {
            ibegin++;
            jbegin++;
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($" {array[i, j], 3}");
        }
        WriteLine();
    }
}