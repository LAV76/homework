// Вариант с внесением числа вручную через консоль
// Console.WriteLine("Введи любое 5-ти значное число: ");
//int number = Convert.ToInt32(Console.ReadLine()!);

 int number = Convert.ToInt32(new Random().Next(10000, 100001));

 int number5 =(number-(number%10000))/10000;
 int number4 = ((number%10000)/1000)*10;
 int number3 = ((number%1000)/100)*100;
 int number2 = ((number%100)/10)*1000;
 int number1 = (number%10)*10000;

if (number==(number5+number4+number3+number2+number1))
{
    Console.Write ($"Палиндромом: {number} {number5+number4+number3+number2+number1}"); 
}
else 
{
    Console.Write ($"Число {number} не являеться палиндромом");
}

