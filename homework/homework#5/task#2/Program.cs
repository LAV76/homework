int[] array = GetArray(5);
Console.WriteLine($"В массие: [{String.Join(", ", array)}] сумма стоящих на нечетных элементах массива{GerCount(array)}");

//----------------Методы-----

int[] GetArray(int size)
{
    int[] res = new int[size];
       for(int i = 0; i < size; i++)
       {
            res[i] = new Random().Next(-10, 10);
       }
    return res;
}

int GerCount(int[] array)
{
    int count = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
        count = count + array[i];
    }
    return count;
}
