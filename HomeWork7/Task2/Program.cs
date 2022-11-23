//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

void PrintMatrix (int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.Write($"{matrix[i, 0]}\t");
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($" {matrix[i, j]}\t");
        }
        System.Console.WriteLine("");    
    }
}

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void ElementSearchInMatrix(int[,] matrix, int m, int n)
{
    if (m >= 0 && n >= 0 && m < matrix.GetLength(0) && n < matrix.GetLength(1))
    {
        System.Console.WriteLine($"Элементу [{m}, {n}] в двумерном массиве соответствует число {matrix[m, n]}");
        return;
    }
    System.Console.WriteLine($"Элемент [{m}, {n}] в двумерном массиве отсутствует ");
}

int[,] matrix = CreateMatrix(5, 5);
PrintMatrix(matrix);
ElementSearchInMatrix(matrix, 3, 3);
