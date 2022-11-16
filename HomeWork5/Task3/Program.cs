//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3, 7.4, 22.3, 2, 78] -> 76

void printArray(double[] array)
{
    System.Console.Write($"{array[0]:f4}");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]:f4}");
    }
}

double [] CreateArray(int lenght)
{
    double[] tempArray = new double[lenght];
    for(int i = 0; i < lenght; i++)
    {
        tempArray[i] = new Random().Next(1, 10) + new Random().NextDouble();
    }
    return tempArray;
}

double MaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double MinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double DifferenceBetweenMaxMin(double[] array)
{
    double diffMaxMin = MaxElement(array) - MinElement(array);
    return diffMaxMin;
}

int lenght = 10;
double[] array = CreateArray(lenght);
printArray(array);
System.Console.WriteLine();
System.Console.Write($"Разница между максимальным и минимальным элементами массива ->  {DifferenceBetweenMaxMin(array):f4}");
