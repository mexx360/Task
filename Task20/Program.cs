// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt (string message)
{
    Console.Write (message);
    string strValue = Console.ReadLine ();
    int Value = int.Parse (strValue);
    return Value;
}
    int N = Prompt ("Введите число: ");
    int A = 1;
    Console.Write (A+ " ");
    while (A < N)
{
    A++;
    Console.Write (A*A+ " ");
}