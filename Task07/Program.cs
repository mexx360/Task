//      Рандомный метод "2 вариант" 
 

int value = RandomInt(1, 10);   
while (value !=9)                  
{
Console.WriteLine($"Случайное значение = {value}");     
value = RandomInt(1, 10);    
}
Console.WriteLine($"Случайное значение = {value}"); 

int RandomInt(int min, int max)
{
Random rnd = new Random();
int value = rnd.Next(min, max);   
return value;
}