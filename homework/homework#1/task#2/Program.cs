int MaxNumber (int number1, int number2, int number3)
{
    int result = number1;
    if (result < number2) result = number2;
    if (result < number3) result = number3;
    return result;
}

/*void RandomNumber(int number)
{
    number = new Random().Next(0, 101);
}*/

// Вариант с внесением числа вручную через консоль
/*Console.WriteLine("Введи первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи третье число: ");
int numberC = int.Parse(Console.ReadLine()!);*/

//int max = MaxNumber(numberA, numberB, numberC);

// Вариант с получением двух случайных числел от 0 до 100

int max = MaxNumber(new Random().Next(0, 101), new Random().Next(0, 101), new Random().Next(0, 101));
Console.WriteLine($"Максимальное число {max}");