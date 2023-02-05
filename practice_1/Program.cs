//практика решения задач, первый семинар

Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// int sqr = number * number;

// int sqr1 = Convert.ToInt32(Math.Pow(number, 2));

// Console.WriteLine($"Квадрат числа {number} равен {sqr}");
// Console.WriteLine($"Квадрат числа {number} равен {sqr1}");

//задача 5 счётчик

// Console.WriteLine("Введите число: ");

// int n = int.Parse(Console.ReadLine()!);
// int k = -n;
// while(k <= n)
// {
//     Console.Write($"{k} ");
//     k += 1;
// }

//задача 7

Console.WriteLine("Введите трёхзначное число");
int x = int.Parse(Console.ReadLine()!);
int b = x % 10;
Console.WriteLine(b);
