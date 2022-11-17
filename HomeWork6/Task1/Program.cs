//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

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

int [] CreateArray(int lenght)
{
    int[] tempArray = new int[lenght];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = Prompt("Введите целое число: ");
    }
    return tempArray;
}

int QuantityOverNull(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

int lenght = Prompt("Введите количество целых чисел, которые будете вводить постепенно: ");
int[] array = CreateArray(lenght);
printArray(array);
System.Console.WriteLine();
System.Console.Write($"Количество чисел больше 0 из вами введённых ->  {QuantityOverNull(array)}");
