// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Без использования строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 10000 || number >= 100000)
    {
        System.Console.WriteLine($"Введённое число не пятизначное!");
        return false;
    }
    return true;
}

int remainsDivision (int number)
{
    return (number % 10);
}

int removeLastDigit (int number)
{
    return (number / 10);
}

bool comparingNumbers(int number)
{
    int firstDigit = removeLastDigit(removeLastDigit(removeLastDigit(removeLastDigit(number))));
    int secondDigit = remainsDivision(removeLastDigit(removeLastDigit(removeLastDigit(number))));
    int fourthDigit = remainsDivision(removeLastDigit(number));
    int lastDigit = remainsDivision(number);
    if (firstDigit == lastDigit && secondDigit == fourthDigit)
    {
        return true;
    }
    else return false;
}
int number = Prompt("Введите пятизначное число: ");
if (ValidateNumber(number))
{
    if (comparingNumbers(number))
    {
        System.Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }
}