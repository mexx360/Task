// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


string A = Console.ReadLine();

int B = int.Parse(A);

int Last = B % 10;

Console.WriteLine(Last); 