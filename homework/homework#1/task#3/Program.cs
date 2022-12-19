// Вариант с внесением числа вручную через консоль
/*Console.WriteLine("Введи любое число: ");
int number = int.Parse(Console.ReadLine()!);*/

int number = new Random().Next(0, 101);

if (number%2 == 0 )
{
   Console.WriteLine($"Число четное: {number}");
}
else
{
    Console.WriteLine($"Число нечетное: {number}");
}
