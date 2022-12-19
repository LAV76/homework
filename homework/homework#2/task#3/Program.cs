// Вариант с внесением числа вручную через консоль
Console.WriteLine("Введи номер дня недели: ");
int number = int.Parse(Console.ReadLine()!);

//int number = new Random().Next(1, 8);

if ((number<1) || (number>7))
{
   Console.Write($"Не являеться цифрой дня недели"); 
}
else
{
    if (number == 1) Console.Write($"Понедельник"); 
    if (number == 2) Console.Write($"Вторник"); 
    if (number == 3) Console.Write($"Среда"); 
    if (number == 4) Console.Write($"Четверг"); 
    if (number == 5) Console.Write($"Пятница"); 
    if (number == 6) Console.Write($"Суббота"); 
    if (number == 7) Console.Write($"Воскресенье"); 
}
