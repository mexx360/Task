Console.WriteLine("Введите число => ");                                     // Вывод приглашения для ввода      
string strValue = Console.ReadLine();                                       // Ввод строки    
int value = int.Parse(strValue);                                            // Преобразуем строку в целое число

int result = value * value;                                                 // Вычесление квадрата
Console.WriteLine ($"Квадрат числа {value} равен: {result}");               // Вывод резуьтат