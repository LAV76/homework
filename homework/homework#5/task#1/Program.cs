
int[] array = GetArray(8);
Console.WriteLine($"В массие: [{String.Join(", ", array)}] {GerCount(array)} четных чисел");

//----------------Методы-----

int[] GetArray(int size)
{
    int[] res = new int[size];
       for(int i = 0; i < size; i++)
       {
            res[i] = new Random().Next(100, 1000);
       }
    return res;
}

int GerCount(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if ((array[i]%2) == 0) 
        {
            count++;
        }
    }
    return count;
}