// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int[] array = new int[3];
Console.Write("Введите целое число A: ");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B: ");
array[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число С: ");
array[2] = Convert.ToInt32(Console.ReadLine());

int max = array[0];
for (int i = 1; i <3; i++)
{
    if (array[i] > max) 
    max = array[i];
}
Console.WriteLine($"Максимальное значение среди трёх вводимых чисел: {array[0]}, {array[1]} и {array[2]}, будет число {max}.");
