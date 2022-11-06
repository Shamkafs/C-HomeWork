// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

int remainsDivision (int number)
{
    return (number % 10);
}

int removeLastDigit (int number)
{
    return (number / 10);
}

int newNumber = removeLastDigit(removeLastDigit(number)) * 10 + remainsDivision(number);
System.Console.WriteLine($"{number} -> {newNumber}");
