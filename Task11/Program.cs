// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


Console.Write("Введите число А: ");
string strA = Console.ReadLine();
int A = int.Parse(strA);
int result1 = A % 7;
int result2 = A % 23;
if (result1 == 0 && result2 == 0) Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно ");