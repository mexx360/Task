// Напишите программу, которая получает число и выводит третью и последнюю цифру числа.

Console.WriteLine($"Введите число: ");
string inputN = Console.ReadLine();
int N = int.Parse (inputN);
if (N > 100)
{
    Console.Write ("Третья цифра: " + N % 10);
}
else
{
    Console.Write("Нет последней цифры");
}
Console.WriteLine ();
if (N > 100)
{
 Console.WriteLine("Последняя цифра: " + N / 10 / 10 % 10);   
}