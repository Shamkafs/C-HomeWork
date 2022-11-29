//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

void PrintNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m % 2 == 0)
    {
        System.Console.WriteLine(m);
    }
    PrintNumbers(m + 1, n);
}

int m = 4;
int n = 8;
PrintNumbers(m, n);
