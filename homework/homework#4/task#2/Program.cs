Console.WriteLine ("Ввкдите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()!);


Console.WriteLine ($"Сумма всех чисел числа {number} равна {SumNumber(number)} ");


int SumNumber(int number){
 int count = 0;
 int digit = 1;
 string sum = Convert.ToString(number);
    for(int i = 0; i < sum.Length; i++){
        digit=digit*10;
        count=number%digit;
        Console.WriteLine(count);
    }
return count;
}

