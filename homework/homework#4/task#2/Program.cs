Console.WriteLine ("Ввкдите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()!);


Console.WriteLine ($"Сумма всех чисел числа {number} равна {SumNumber(number)} ");


int SumNumber(int number){
 string sum = Convert.ToString(number);
 int summa = 0;
    for(int i = 0; i < sum.Length; i++){
        
        summa = summa + number%10;
        number=number/10;
        
    }
return summa;
}

