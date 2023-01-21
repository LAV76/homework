Console.WriteLine("Введите произвольное количество чисел, через пробел после окончания набора нажмите Enter");
String StrinArr = Console.ReadLine()!;
int i = 0;
string[] num = StrinArr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
foreach (var item in num)
{
    if (item != "0") i++; 
}
Console.WriteLine($"Количество введеных чисел [{String.Join("|", num)}] больше 0 = {i}");