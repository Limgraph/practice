// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// • 5, 25  ->  да
// • -4, 16  ->  да
// • 25, 5  ->  да
// • 8,9  ->  нет
Console.Clear();

Console.WriteLine("Введите первое число!");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число!");
int num_2 = int.Parse(Console.ReadLine()!);

if(Math.Pow(num_1,2) == num_2) Console.WriteLine($"Первое число {num_1} является квадратом второго {num_2}");
else if(Math.Pow(num_2,2) == num_1) Console.WriteLine($"Второе число {num_2} является квадратом первого {num_1}");
else Console.WriteLine($"Одно число не является квадратом другого.");