﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
string inputN = Console.ReadLine ();
int N = int.Parse(inputN);
Console.WriteLine ($"Вторая цифра введенного числа {N/10%10}");