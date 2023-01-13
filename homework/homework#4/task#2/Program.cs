Console.WriteLine ("Ввкдите целое число: ");
string number = Console.ReadLine()!;

Console.WriteLine ($"Сумма всех чисел числа {number} равна {SumNumber(number)} ");


int SumNumber(string number){
 int count = 0;
    for(int i = 0; i < number.Length; i++){
        count=count+Convert.ToInt32(Convert.ToString(number[i]));
        Console.WriteLine(Convert.ToInt32(Convert.ToString(number[i])));
    }
return count;
}

