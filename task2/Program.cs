// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введие количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введие количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row, column];


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

void checkArray(int[,] matrix)
{
    Console.Write("Введие номер строки для проверки: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введие номер столбца для проверки: ");
    int y = Convert.ToInt32(Console.ReadLine());

    if (x > row || y > column || x <= 0 || y <= 0)
    {
        Console.Write("Такого числа нет ! ");
    }
    else
    {
        Console.Write($"в строке: {x} в столбце: {y} ===> [{matrix[x - 1, y - 1]}]");
    }
}

void showArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("[" + matrix[i, j] + "]" + " ");
        }

    }

}

checkArray(createDoubArray());
showArray(matrix);