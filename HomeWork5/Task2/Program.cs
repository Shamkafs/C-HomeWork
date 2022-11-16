//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 26
//[-4, -6, 4, 6] -> 0

void printArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

int [] CreateArray(int lenght)
{
    int[] tempArray = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        tempArray[i] = new Random().Next(1, 100);
    }
    return tempArray;
}

int SumOfOddPosition (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int lenght = 10;
int[] array = CreateArray(lenght);
printArray(array);
System.Console.WriteLine();
System.Console.Write($"Сумма элементов массива, стоящих на нечётных позициях ->  {SumOfOddPosition(array)}");
