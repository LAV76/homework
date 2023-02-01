



PrintArray(GetArray(2, 2, 2, 10, 99));



//-------------------Методы---------------------------------
int[,,] GetArray(int a, int b, int c, int minValue, int maxValue){
    int[,,] result = new int[a,b,c];
    for(int i = 0; i < result.GetLength(0); i++){
        for(int j = 0; j < result.GetLength(1); j++){
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i,j,k] = GetRnd(result, minValue, maxValue);
            }
        }
    }
    return result;
}
int GetRnd(int[,,] array, int minValue, int maxValue)
{
    int num = new Random().Next(minValue, maxValue + 1);
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i,j,k] == num) num = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return num ;
}

void PrintArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
	{
        for(int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();   
        }
    }
}
