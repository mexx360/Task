// Напишите программу, которая выводит случайное трёхзначное число и выводит числа без второй цифры.

Random rnd = new Random ();
int value = rnd.Next (100, 1000);
int number = value / 100 * 10 + (value % 10);
Console.WriteLine($"Вывод случайного трехзначного числа {value}");
Console.WriteLine($"Вывод числа без второй цифры {number}");