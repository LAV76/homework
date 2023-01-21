Console.WriteLine("Введите произвольное количество чисел, через пробел после окончания набора нажмите Enter");
String StrinArr = Console.ReadLine()!;
int i = 0;
//ConsoleKeyInfo kay;
//do
//{
    //kay = Console.ReadKey();
    string[] num = StrinArr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    //int number = Convert.ToInt32(Console.ReadLine()!);
    //if (number>0) i++;

    
//} while (kay.Key != ConsoleKey.Escape);
foreach (var item in num)
{
    if (item != "0") i++; 
}
Console.WriteLine($"Количество введеных чисел [{String.Join("|", num)}] больше 0 = {i}");