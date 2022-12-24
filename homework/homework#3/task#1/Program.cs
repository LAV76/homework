// Вариант с внесением числа вручную через консоль
// Console.WriteLine("Введи любое число: ");
//string number = Console.ReadLine()!;

string number = Convert.ToString (new Random().Next(10000, 100001));

if (number == Convert.ToString(number[4])+Convert.ToString(number[3])+Convert.ToString(number[2])+Convert.ToString(number[1])+Convert.ToString(number[0]))
{
    Console.Write ($" Палиндромом: {number} Состоит из: {number[0]} {number[1]} {number[2]} {number[3]} {number[4]}"); 
}
else 
{
    Console.Write ($" Число {number} не являеться палиндромом");
}

