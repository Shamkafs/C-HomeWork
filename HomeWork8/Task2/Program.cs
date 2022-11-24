//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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



int SumElementsInArray(int[,] matrix, int i)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    return sum;
}

int FindRowWithMinSumElements(int[,] matrix)
{
    int sum = 0;
    int minRow = 0;
    int minSum = SumElementsInArray(matrix, minRow);
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        sum = SumElementsInArray(matrix, i);
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i + 1;
        }
    }
    return minRow;
}

int[,] matrix = CreateMatrix(4, 6);
PrintMatrix(matrix);
System.Console.WriteLine();
System.Console.Write($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {FindRowWithMinSumElements(matrix)} строка");