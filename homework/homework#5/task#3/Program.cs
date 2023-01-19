int[] array = GetArray(6);
Console.WriteLine($"В массие: [{String.Join(", ", array)}] произведение пар [{String.Join(", ",GerCount(array))}]");

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

int[] GerCount(int[] array)
{
    int size = array.Length/2;
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
      res[i] =  array[i]*array[(array.Length-1)-i];
    }
    return res;
}

