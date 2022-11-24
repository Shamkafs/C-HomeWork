//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

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

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int m = 0; m < matrix1.GetLength(1); m++) //Или m < matrix2.GetLength(0), роли не играет.
            {
                newMatrix[i, j] += matrix1[i, m] * matrix2[m, j];
            }
        }
    }
    return newMatrix;
}

int[,] matrix1 = CreateMatrix(4, 3);
PrintMatrix(matrix1);
System.Console.WriteLine();
int[,] matrix2 = CreateMatrix(3, 2);
PrintMatrix(matrix2);
System.Console.WriteLine();
if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    System.Console.Write("Данные матрицы нельзя перемножать!");
}
else 
{
    System.Console.Write("Произведение двух матриц равно: ");
    System.Console.WriteLine();
    PrintMatrix(MatrixMultiplication(matrix1, matrix2));
}
