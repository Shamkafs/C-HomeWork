//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] AveragePerColumn(int [,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average[j] += matrix[i, j];
        }
        average[j] = average[j]/matrix.GetLength(0);
    }
    return average;
}

void PrintArray(double[] array)
{
    System.Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
}

int[,] matrix = CreateMatrix(5, 5);
PrintMatrix(matrix);
System.Console.Write($"Cреднее арифметическое элементов в каждом столбце: ");
PrintArray(AveragePerColumn(matrix));
