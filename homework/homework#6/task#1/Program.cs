Console.WriteLine("Введите произвольное количество чисел, через пробел после окончания набора нажмите Enter");
int i = 0;
ConsoleKeyInfo kay;
do
{
    kay = Console.ReadKey();
    int number = Convert.ToInt32(Console.ReadLine()!);
    if (number>0) i++;

    
} while (kay.Key != ConsoleKey.Escape);

Console.WriteLine($"Количество введеных чисел больше 0 = {i}");
