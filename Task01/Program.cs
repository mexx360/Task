//Программа, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
Console.WriteLine("Введите число => ");                                     // Вывод приглашения для ввода      
string strValue = Console.ReadLine();                                       // Ввод строки    
int value = int.Parse(strValue);                                            // Преобразуем строку в целое число

int result = value * value;                                                 // Вычесление квадрата
Console.WriteLine ($"Квадрат числа {value} равен: {result}");               // Вывод резуьтат