﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// • 34, 5 -> не кратно, остаток 4 
// • 16, 4 -> кратно
Console.Clear();

Console.WriteLine("Введите первое число!");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число!");
int num_2 = int.Parse(Console.ReadLine()!);

if(num_1 % num_2 == 0) Console.WriteLine("Первое число является кратным второму!");
else Console.WriteLine($"Первое число не является кратным второму! остаток {num_1 % num_2}");