//      Рандомный метод "1 вариант" 


Random rnd = new Random();

int value = rnd.Next(1, 10);   
while (value !=9)                  
{
Console.WriteLine($"Случайное значение = {value}");     
value = rnd.Next(1, 10);    
}