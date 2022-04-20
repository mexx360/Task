// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int Prompt (string message)
{
Console.Write(message);
string strInput = Console.ReadLine ();
int answer = int.Parse(strInput);
return answer;    
}
int quarter = Prompt ("Введите четверть: ");

if (quarter < 1 || quarter > 4) Console.WriteLine ("Невозможные координаты");
if (quarter == 1) Console.Write("Диапазон возможных координат x > 0 и y > 0");
if (quarter == 2) Console.Write("Диапазон возможных координат x < 0 и y > 0");
if (quarter == 3) Console.Write("Диапазон возможных координат x < 0 и y < 0");
if (quarter == 4) Console.Write("Диапазон возможных координат x > 0 и y < 0");