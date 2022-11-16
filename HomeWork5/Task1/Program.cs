//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
        tempArray[i] = new Random().Next(100, 1000);
    }
    return tempArray;
}

int QuantityEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

int lenght = 10;
int[] array = CreateArray(lenght);
printArray(array);
System.Console.WriteLine();
System.Console.Write($"Количество чётных чисел в массиве с случайными трёхзначными значениями ->  {QuantityEvenNumbers(array)}");
