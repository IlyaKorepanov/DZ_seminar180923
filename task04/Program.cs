﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());

int count = 2;

if (number > 1)
{
    while (count <= number)
    {
        Console.Write($"{count} ");
        count = count + 2;
    }
}
else if (number <= 1)
{
    Console.WriteLine($"Нет решения, число {number} меньше или равно 1");
}
Console.WriteLine();
