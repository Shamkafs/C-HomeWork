// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите целое число A: ");
int intA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B: ");
int intB = Convert.ToInt32(Console.ReadLine());
if (intA == intB)
{
    Console.WriteLine($"Числа A ({intA}) и B ({intB}) равны.");
}
else if (intA > intB)
{
    Console.WriteLine($"Число A ({intA}) больше числа B ({intB})");
}
else
{
    Console.WriteLine($"Число A ({intA}) меньше числа B ({intB})");
}
