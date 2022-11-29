//Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29
//m = 2, n = 3 -> A(m,n) = 9

int FunctionAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return FunctionAckermann(m - 1, 1);
    }
    return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));

}

int m = 2;
int n = 3;
System.Console.WriteLine(FunctionAckermann(m, n));
