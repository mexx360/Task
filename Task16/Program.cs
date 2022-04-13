// Напишите программу, которая проверяет соответствие числа дню недели (7 дней).

Console.Write("Введите число: ");
string inputN = Console.ReadLine();
int N = int.Parse (inputN);
if (N == 6 || N == 7)
Console.WriteLine ($"Число {N} - выходной ");
else Console.WriteLine ($"Число {N} - не выходной ");