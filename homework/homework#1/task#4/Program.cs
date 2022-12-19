// Вариант с внесением числа вручную через консоль
/*Console.WriteLine("Введи любое число: ");
int number = int.Parse(Console.ReadLine()!);*/

int number = new Random().Next(1, 50);
int i = 1;
Console.Write($"число {number}");
Console.WriteLine();
Console.Write($"Четное число: ");
while (number > i)
{
   if (i%2 == 0 )
   {
      Console.Write($" {i}, ");
   }
   i++; 
}

