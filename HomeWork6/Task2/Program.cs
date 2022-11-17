//Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    System.Console.Write(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

void IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = (k2*b2-k2*b1)/(k1-k2) + b2;
    if (k1 == k2)
    {
        System.Console.Write("Заданные прямые не пересекаются!");
    }
    System.Console.Write($"Прямые пересекаются в точке с координатами: ({x:f2}, {y:f2})");
}

double k1 = Prompt("Введите число k1 из уравнения y = k1 * x + b1: ");
double b1 = Prompt("Введите число b1 из уравнения y = k1 * x + b1: ");
double k2 = Prompt("Введите число k2 из уравнения y = k2 * x + b2: ");
double b2 = Prompt("Введите число b2 из уравнения y = k2 * x + b2: ");
IntersectionPoint(k1, b1, k2, b2);
