// Вариант с внесением числа вручную через консоль
/*Console.WriteLine("Введи первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int numberB = int.Parse(Console.ReadLine()!);*/

// Вариант с получением двух случайных числел от 0 до 100

int numberA = new Random().Next(0, 101);
int numberB = new Random().Next(0, 101);


if (numberA == numberB)
{
    Console.WriteLine($"Два числа одинаковых Первое число: {numberA} Второе число: {numberB}");
}
else if (numberA > numberB)
{
    Console.WriteLine($"Первое число больше второго: {numberA} Первое число: {numberA} Второе число: {numberB}");
}
else
{
   Console.WriteLine($"Второе число больше первого: {numberB} Первое число: {numberA} Второе число: {numberB}"); 
}
