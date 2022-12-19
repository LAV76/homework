// Вариант с внесением числа вручную через консоль
/*Console.WriteLine("Введи любое число: ");
int number = int.Parse(Console.ReadLine()!);*/

int number = new Random().Next(1, 101);
int i = 0;
Console.Write($"число {number}");
Console.WriteLine();
while (number < i)
{
   if (i%2 == 0)
   {
    Console.WriteLine($"Являеться четным числом {i}");
   }
    
   i++; 
}
