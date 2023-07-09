//Показать треугольник Паскаля
using System;
using static System.Console;
Clear();
const int width = 3;// количество символов в ячейке
Write("Введите нужное количество строк треугольника Паскаля: ");
int n = int.Parse(ReadLine());
int[,] pascal = new int[n, n];
GetArray(pascal);
PrintArray(pascal);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, 0] = 1;
        array[i, i] = 1;
    }
    for (int i = 2; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }
}
void PrintArray(int[,] array)
{
    int cell = width * array.GetLength(0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SetCursorPosition(cell, i + 1);
            if (array[i, j] != 0)
            {
                Write($" {array[i, j],3}");
                cell += width * 2;
            }
        }
        cell = width * array.GetLength(0) - width * (i + 1);
        WriteLine();
    }
}
