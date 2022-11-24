//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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

void SortByDecreaseInRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int m = 0; m < matrix.GetLength(1) - 1; m++)
            {
                while (matrix[j, m] < matrix[j, m + 1])
                {
                SwapElements(matrix, j, m, m + 1);
                }
            }
        }
    }
}

void SwapElements(int[,] matrix, int i, int j1, int j2)
{
    (matrix[i, j1], matrix[i, j2]) = (matrix[i, j2], matrix[i, j1]);
}

int[,] matrix = CreateMatrix(6, 6);
PrintMatrix(matrix);
System.Console.WriteLine();
SortByDecreaseInRows(matrix);
PrintMatrix(matrix);
