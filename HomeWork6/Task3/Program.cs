//Задача 3. (*) Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
//1 2 3
//3 4 5
//3+5=8, 1+2+3=6, 8-6=2

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
    System.Console.WriteLine();
    }
}

int[,] CreateMatrix(int x, int y)
{
    int[,] matrix = new int[x, y];
    for(int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

int SumMaxInMatrix(int[,] matrix)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        int max = matrix[j, 0];
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (max < matrix[j, i])
            {
                max = matrix[j, i];
            }
        }
        sum += max;
    }
    return sum;
}

int SumMinInMatrix(int[,] matrix)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int min = matrix[0, j];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
            }
        }
        sum += min;
    }
    return sum;
}

int x = Prompt("Введите количество столбцов в матрице: ");
int y = Prompt("Введите количество строк в матрице: ");
int[,] matrix = CreateMatrix(x, y);
printMatrix(matrix);
System.Console.Write($"Сумма максимумов в каждой строке: {SumMaxInMatrix(matrix)}");
System.Console.WriteLine();
System.Console.Write($"Сумма минимумов в каждом столбце: {SumMinInMatrix(matrix)}");
System.Console.WriteLine();
System.Console.Write($"Разница сумм максимумов и минимумов -> {SumMaxInMatrix(matrix) - SumMinInMatrix(matrix)}");