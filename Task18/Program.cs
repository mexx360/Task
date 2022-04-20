// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int Prompt (string message) 
{
Console.Write(message);
string strInput = Console.ReadLine ();
int answer = int.Parse(strInput);
return answer;    
}

int x1 = Prompt("Введите x первой точки: ");
int y1 = Prompt("Введите y первой точки: ");
int x2 = Prompt("Введите x второй точки: ");
int y2 = Prompt("Введите y второй точки: ");
double x3 = x1 - x2;
double y3 = y1 - y2;
double N = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
Console.Write (N);