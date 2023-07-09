// Из двухмерного массива удалить строку и столбец на пересечении которох расположено минимальное число
using System;
using static System.Console;
Clear();
Write("Введите кличество строк:");
int row = int.Parse(ReadLine());
Write("Введите кличество cтолбцов:");
int collums = int.Parse(ReadLine());
int[,] matrix = new int[row, collums];
GetArray(matrix, 0, 9);
PrintArray(matrix);
int[] minimal = SearchMin(matrix);
WriteLine($"минимальное чило {matrix[minimal[0], minimal[1]]} находится на пересечении {minimal[0]+1} строки и {minimal[1]+1} столбца");
WriteLine();
int [,] newmatrix = DeletRowColumn(matrix,minimal);
PrintArray(newmatrix);


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
int[] SearchMin(int[,] array)
{
    int[] min = new int[2];
    int minnumb = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minnumb)
            {
                minnumb = array[i, j];
                min[0] = i;
                min[1] = j;
            }
        }
    }
    return min;
}
int[,] DeletRowColumn(int[,] array, int[] arr)
{
    int[,] delet = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int column = 0;
    int line = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != arr[0])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != arr[1])
                {
                    delet[line, column] = array[i, j];
                    column++;
                }

            }
            column = 0;
            line++;
        }
    }

    return delet;
}