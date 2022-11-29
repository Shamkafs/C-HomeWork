//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

int SumNumbers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else 
    {
        return m + SumNumbers(m + 1, n);
    }
}

int m = 4;
int n = 8;
System.Console.WriteLine($"Сумма натуральных чисел в промежутке от M до N равна -> {SumNumbers(m, n)}");
