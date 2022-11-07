// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message) //Функция ввода числа с консоли
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

bool ValidateNumber(int number) // Проверка на правильность ввода запрашиваемого числа
{
    if (number < 1)
    {
        System.Console.WriteLine($"Введено некорректное число!");
        return false;
    }
    return true;
}

int number = Prompt("Введите число N большее от 0: ");// Просим пользователя ввести число

if (ValidateNumber(number))
{
    string result = ""; //Присваиваем переменной result строковое значение
    for (int i = 1; i <= number; i++)
    {
        result = ($"{result}{Math.Pow(i, 3)} "); //Перезаписываем переменную result при каждом увеличении инкремента
    } 
    System.Console.Write($"Таблица кубов чисел от 1 до {number} -> {result}");
}
