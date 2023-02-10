//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Clear();

Console.WriteLine("Введите координаты X первой точки: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Y первойConsole.ReadLine(x1); точки: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты X второй точки: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Y второй точки: ");
int y2 = int.Parse(Console.ReadLine()!);

double distance_x = Math.Pow(x1 - x2, 2);
double distance_y = Math.Pow(y1 - y2, 2);

//double distance = Math.Round(Math.Sqrt(distance_x + distance_y), 2);
double distance = Math.Sqrt(distance_x + distance_y);
Console.WriteLine($"{distance:f2}");