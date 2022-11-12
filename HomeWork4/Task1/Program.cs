//Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool NumberNotNull (int number)
{
    if (number != 0)
    {
        return true;
    }
    return false;
}

bool NumberIsNegative (int number)
{
    if (number < 0)
    {
        return true;
    }
    return false;
}

double Exponentiation (int intA, int intB)
{
    if (NumberNotNull(intB))
    {
            double result = 1;
            if (NumberIsNegative(intB))
            {
            intB *= -1;
            for (int i = 1; i <= intB; i++)
                {
                    result *= intA; 
                }   
                return result = 1/result;
            }
            else
            {
                for (int i = 1; i <= intB; i++)
                {
                    result *= intA; 
                }   
                return result;
            }
    }    
    return 1;
}

int intA = Prompt("Введите число A: ");
int intB = Prompt("Введите число B: ");
System.Console.WriteLine($"Возведение числа {intA} в натуральную степень числа {intB} равна {Exponentiation(intA, intB)}");