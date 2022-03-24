// Программа вычисления функции: x=f(a).
Console.Write("Введите число А => ");
string inputNumber = Console.ReadLine();
int numberA = int.Parse(inputNumber);

int x = numberA + 9;
Console.WriteLine($"Функция x = f(a): {x}");