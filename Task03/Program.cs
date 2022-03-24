// Программа проверяет, является ли первое число квадратом второго.
Console.Write("Введите число А => ");
string inputA = Console.ReadLine();
int numberA = int.Parse(inputA);

Console.Write("Введите число В => ");
string inputВ = Console.ReadLine();
int numberB = int.Parse(inputВ);

int value = numberA * numberA;
if (numberB == value) Console.WriteLine("Да");
else
{
    Console.WriteLine("Нет");
}