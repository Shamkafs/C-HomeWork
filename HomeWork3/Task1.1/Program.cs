//Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

int Prompt(string message)
{
    System.Console.Write(message + " > ");
    return int.Parse(Console.ReadLine());
}

bool ValidateNumber(int number)
{
    if (number <= 0)
    {
        System.Console.WriteLine("Число должно быть положительным");
        return false;
    }
    return true;
}

int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int number = Prompt("Введите число: ");
if (ValidateNumber(number))
{
    int sum = SumNumbers(number);
    System.Console.WriteLine($"Сумма числе от 1 до {number} равно {sum}");
}