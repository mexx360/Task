//  Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//  Если число 2 не кратно числу 1, то программа выводит остаток от деление.


Console.Write("Введите число А: ");
string strA = Console.ReadLine();
int A = int.Parse(strA);

Console.Write("Введите число В: ");
string strВ = Console.ReadLine();
int B = int.Parse(strВ);

int result = A % B;

if (result == 0) Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно "+ result);