int rows =new Random().Next(2, 9);
int columns =new Random().Next(2, 9);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

for(int i = 0; i < array.GetLength(0); i++)
{
	SortArray(array,  i);
}
Console.WriteLine();
PrintArray(array);



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

void SortArray(int [,] array, int row)
{
    bool swapped;

    do
    {
        swapped = false;
        for (int i = 1; i < array.GetLength(1); i++) {
            if (array[row, i - 1] < array[row, i])
            {
                
				int temp = array[row, i - 1];
				array[row, i - 1] = array[row, i];
				array[row, i] = temp;
                swapped = true;
            }
        }
    } while (swapped != false);
}
 

