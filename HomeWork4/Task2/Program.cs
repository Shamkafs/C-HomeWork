//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.
//452 -> 11
//82 -> 10
//9012 -> 12

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool NumberIsNegative (int number)
{
    if (number < 0)
    {
        return true;
    }
    return false;
}

int SumOfDigit(int number)
{
    if (NumberIsNegative(number))
    {
        number *= -1;
    }
    int sum = 0;
    while (number > 0)
        {
            sum = sum + number % 10;
            number /= 10;
        }
    return sum;
}
int number = Prompt("Введите число: ");
Console.WriteLine($"Сумма цифр в числе {number} равна {SumOfDigit(number)}");
