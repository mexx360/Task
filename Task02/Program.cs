﻿// Программa, которая будет выдавать название дня недели по заданному номеру.
Console.WriteLine("Введите число ");
string inputNunber = Console.ReadLine ();
int number = int.Parse(inputNunber);

if (number == 1) Console.WriteLine("Понедельник"); else
if (number == 2) Console.WriteLine("Вторник"); else
if (number == 3) Console.WriteLine("Среда"); else 
if (number == 4) Console.WriteLine("Четверг"); else
if (number == 5) Console.WriteLine("Пятница"); else 
if (number == 6) Console.WriteLine("Суббота"); else 
if (number == 6) Console.WriteLine("Воскресенье"); else
{
    Console.WriteLine("В неделе 7 дней");
}