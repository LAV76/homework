int[] array = GetArray(7, 0, 100);
Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}] отсортированный массив: [{String.Join(", ",Sort(array))}]");

//----------------Методы-----

int[] GetArray(int size, int minVolume, int maxVolume)
{
    int[] res = new int[size];
       for(int i = 0; i < size; i++)
       {
            res[i] = new Random().Next(minVolume, maxVolume+1);
       }
    return res;
}

void Swap(int[] array, int left, int right)
{
    if (left != right)
    {
        int temp = array[left];
        array[left] = array[right];
        array[right] = temp;
    }
}
int[] Sort(int [] array)
{
    bool swapped;

    do
    {
        swapped = false;
        for (int i = 1; i < array.Length; i++) {
            if (array[i - 1] > array[i])
            {
                Swap(array, i - 1, i);
                swapped = true;
            }
        }
    } while (swapped != false);
    return array;
}

