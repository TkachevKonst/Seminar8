// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
using System;
using static System.Console;
Clear();
Write("Введите высоту массива:");
int height = int.Parse(ReadLine());
Write("Введите длину массива:");
int length = int.Parse(ReadLine());
Write("Введите ширину массива:");
int width = int.Parse(ReadLine());
int[,,] matrix = new int[height, length, width];
GetArray(matrix, 10, 99);
PrintArray(matrix);



void GetArray(int[,,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int num = new Random().Next(min, max + 1);
                if (SearchNumb(array, num)) continue;
                array[i, j, k] = num;
            }
        }
    }
}
bool SearchNumb(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Write($" {array[i, j, k]} ({i},{j},{k})");
            }
            WriteLine();
        }
        WriteLine();
    }

}