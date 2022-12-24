// Вариант с внесением числа вручную через консоль
Console.WriteLine("Введи любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

//int number = Convert.ToInt32(new Random().Next(1, 20));

Console.Write($"таблицу кубов чисел от 1 до {number} ");

if (number>0)
{
   for (int i = 1; i <= number; i++)
{
   Console.Write(Math.Pow(i, 3)+" ");
} 
}
else
{
    Console.Write($"Число: {number} не натуральное");
}

