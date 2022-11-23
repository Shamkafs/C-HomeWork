//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int Promt(string message)
{
    System.Console.Write(message);
    int msg = Convert.ToInt32(System.Console.ReadLine());
    return msg;
}

void PrintMatrix (double[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.Write($"{matrix[i, 0]:f1}\t");
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($" {matrix[i, j]:f1}\t");
        }
        System.Console.WriteLine("");    
    }
}

double[,] CreateMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
        }
    }
    return matrix;
}

int m = Promt("Введите количество столбцов в двумерном массиве: ");
int n = Promt("Введите количество строк в двумерном массиве: ");
double[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);
