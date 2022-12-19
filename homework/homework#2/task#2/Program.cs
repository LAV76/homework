// Вариант с внесением числа вручную через консоль
Console.WriteLine("Введи любое трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

//int number = new Random().Next(-99999, 100001);


if ((number>999999) || (number<-100000))
{
    Console.Write($"Число вне заданого диапазона");
}
else if ((number<99) || (number>-99))
{
  Console.Write($"Третьей цифры нет");  
}
else
{
   Console.Write($"Трехзначное число: {number} Третий знак числа: {(number%1000-number%100)/100}");
}
