int[] array = GetArray(5));
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
  if (array.Length%2 == 1) size++;

    int[] res = new int[size];
    for (int i = 0; i < array.Length/2; i++)
    {
      res[i] =  array[i]*array[(array.Length-1)-i];
    } 
    if (array.Length%2 == 1) res[^1] = array[array.Length/2];
    return res;
}

