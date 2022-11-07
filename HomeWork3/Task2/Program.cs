//Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Prompt(string message)
{
    System.Console.Write(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double x1 = Prompt("Введите значение координаты первой точки по оси Х: ");
double y1 = Prompt("Введите значение координаты первой точки по оси Y: ");
double z1 = Prompt("Введите значение координаты первой точки по оси Z: ");
double x2 = Prompt("Введите значение координаты второй точки по оси Х: ");
double y2 = Prompt("Введите значение координаты второй точки по оси Y: ");
double z2 = Prompt("Введите значение координаты второй точки по оси Z: ");

double DistanceBetweenTwoCoordinates(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
}

System.Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) в 3D пространстве равно: {DistanceBetweenTwoCoordinates(x1, y1, z1, x2, y2, z2):f2}");
