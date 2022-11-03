// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 2) 
{
    Console.WriteLine($"Между 1 и {n} не существует чётных числел");
}
else 
{
    int[] array = new int[] { };
    for (int i = 2; i <= n; i ++ )
    {
        if (i % 2 == 0)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = i;
        }
    }
    string strResult = $"Четные числа в диапазоне от 1 до {n}: ";
    foreach (int i in array) 
    strResult = $"{strResult} {i},";
    Console.WriteLine(strResult.TrimEnd(','));
}
