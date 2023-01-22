Console.WriteLine("Введите произвольное количество чисел, после окончания набора нажмите Escape");
int i = 0;
int j = 0;
ConsoleKeyInfo kay;
do
{
    string number = Console.ReadLine()!;
    Console.WriteLine("Введите следующее число или нажмите Escape");
    kay = Console.ReadKey();
    j++;
    if (number != "0") i++;

} while (kay.Key != ConsoleKey.Escape);

Console.WriteLine($"Количество введеных чисел больше 0 = {i} всего введено {j} числел");
