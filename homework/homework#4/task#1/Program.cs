Console.WriteLine ("Ввкдите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine ("Ввкдите степень: ");
int extent = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine ($"Возведение числа {number} в степень {extent} равно {SqrCount (number, extent)} ");


int SqrCount(int number, int extent){
 int count = 1;
    for(int i = 0; i < extent; i++){
        count=count*number;
    }
return count;
}
