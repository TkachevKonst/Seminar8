// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using System;
using static System.Console;
Clear();
Write("Введите кличество строк для 1-ой матрицы:");
int row1 = int.Parse(ReadLine());
Write("Введите кличество cтолбцов для 1-ой матрицы:");
int collums1 = int.Parse(ReadLine());
Write("Введите кличество строк для 2-ой матрицы:");
int row2 = int.Parse(ReadLine());
Write("Введите кличество cтолбцов для 2-ой матрицы:");
int collums2 = int.Parse(ReadLine());
int[,] matrix1 = new int[row1, collums1];
int[,] matrix2 = new int[row2, collums2];
GetArray(matrix1, 0, 9);
PrintArray(matrix1);
WriteLine();
GetArray(matrix2, 0, 9);
PrintArray(matrix2);
if (collums1!=row2)
{
    WriteLine ("Матрицы не являются согласованными умножение не возможно");
    return;
}
int[,] multimatrix = MultiMatrix (matrix1,matrix2);
WriteLine();
WriteLine("Произведение двух матриц : ");
PrintArray(multimatrix);

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
int[,] MultiMatrix (int[,]array1, int[,]array2)
{int[,] multiarray = new int [array1.GetLength(0),array2.GetLength(1)]; 
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            multiarray[i,j] += array1[i,k]*array2[k,j];
        }
        }
    }
    return multiarray;
}