using System;
using System.Text.RegularExpressions;
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.Write("Введие количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введие количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row, column];
double[] middleNum = new double[column];


int[,] createDoubArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}


void showArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("[" + matrix[i, j] + "]\t");
        }
    }
}


void showMiddle()
{
    Console.WriteLine("\n");
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double mid = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            mid = mid + matrix[j, i];
        }

        mid = Math.Round(mid / row, 2);
        middleNum[i] = mid;
        mid = 0;
        Console.Write($"[{middleNum[i]}]\t");
    }
}

createDoubArray();
showArray(matrix);
showMiddle();
