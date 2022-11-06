// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    System.Console.Write(message);
    int numberOfDay = Convert.ToInt32(Console.ReadLine());
    return numberOfDay;
}

bool ValidateNumberOfDay(int numberOfDay)
{
    if (numberOfDay < 1 || numberOfDay > 7)
    {
        System.Console.WriteLine($"Введён неверный порядковый номер дня недели");
        return false;
    }
    return true;
}

int numberOfDay = Prompt("Введите порядковый номер дня недели, где 1 - это понедельник, 2 - это вторник и так далее: ");
if (ValidateNumberOfDay(numberOfDay))
{
    if (numberOfDay < 6)
    {
        System.Console.WriteLine($"{numberOfDay} день недели не является выходным днём");
    }
    else
    {
        System.Console.WriteLine($"{numberOfDay} - Это выходной день!");
    }
}
