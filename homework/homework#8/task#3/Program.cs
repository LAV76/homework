int rows1, columns1, rows2, columns2 =0;
do
{
rows1 = new Random().Next(2, 9);
columns1 = new Random().Next(2, 9);
rows2 = new Random().Next(2, 9);
columns2 = new Random().Next(2, 9);
}while (columns1 != rows2);



int[,] array1 = GetArray(rows1, columns1, 0, 10);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(rows2, columns2, 0, 10);
PrintArray(array2);
Console.WriteLine();
PrintArray(SumOfTwoArray(array1, array2));




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
            Console.Write($"{array[i,j]:00} ");
        }
        Console.WriteLine();
    }
}

int[,] SumOfTwoArray(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0),array2.GetLength(1)];
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j =0; j < array2.GetLength(1); i++)
        {
            for(int k=0; k < array1.GetLength(1); i++)
            {
                result[i,j]+=array1[i,k]*array2[k,j];
            }
        }
    }
    return result;
}

