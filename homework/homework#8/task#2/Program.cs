int rows =new Random().Next(2, 9);
int columns =new Random().Next(2, 9);
int sum = 0;
int row = 0;

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($" Сумма всех чисел в строке {0} равна {RowtArray(array, 0)}");
sum = RowtArray(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    Console.WriteLine($" Сумма всех чисел в строке {i} равна {RowtArray(array, i)}");
    if (RowtArray(array, i) < sum)
    {
        sum = RowtArray(array, i);
        row = i;
    }
}
Console.WriteLine();
Console.WriteLine($" Сумма всех чисел в строке {row}  найменьшей суммой равна {sum}");





// -------------------Методы---------------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
	{
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int RowtArray(int [,] array, int row)
{
    int count = 0;

    for(int j = 0; j < array.GetLength(1); j++)
    {
        count += array[row, j];
    }
    return count;    
}