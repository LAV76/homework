// Вариант с внесением числа вручную через консоль
Console.WriteLine("Введи любое трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

//int number = new Random().Next(100, 1000);


if ((99<number) && (number<1000))
{
    Console.Write($"Трехзначное число: {number} Второй знак числа: {((number%100)-(number%100)%10)/10}");
}
else
{
    Console.Write($"Число вне заданого диапазона");
}
