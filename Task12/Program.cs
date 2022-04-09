// Метод перевода из отрицательнго значения числа "-n"  в  "n" значение. 


int promt(string strValue)
{
    Console.WriteLine(strValue);
    string Value = Console.ReadLine ();
    int a = int.Parse(Value);
    return a;
}

int M(int a)
{
    if (a < 0) a = -a;
    return a;
}
int A = promt("Введите число: ");
Console.WriteLine(M(A));