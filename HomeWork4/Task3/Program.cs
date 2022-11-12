//Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  
//Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)
//1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 -> 8

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void printArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

int [] CreateArray(int lenght, int minArr, int maxArr)
{
    int[] tempArray = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        tempArray[i] = new Random().Next(minArr, maxArr+1);
    }
    return tempArray;
}

int arrLenght = Prompt("Введите количество элементов массива: ");
int minArr = Prompt("Введите минимальный порог случайных значений: ");
int maxArr = Prompt("Введите максимальный порог случайных значений: ");

System.Console.Write($"Массив длиной {arrLenght} со случайными значениями от {minArr} до {maxArr}: ");
int[] array = CreateArray(arrLenght, minArr, maxArr);
printArray(array);
