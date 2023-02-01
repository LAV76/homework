
PrintArray(GetArray(4, 4));

// -------------------Методы---------------------------------
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    int maxX = array.GetUpperBound(0) + 1;
    int maxY = array.GetUpperBound(1);
    int X = 1;
    int Y = 1;
    int x  = -1;
    int y = 0;
    int val = 1;
        while ((maxX >= 0) && (maxY >= 0))
        {
            for (int xval = 1; xval <= maxX; xval++)
            {
                array[x + X * xval, y] = val;
                val++;
            }
            x = x + X * maxX;
            X = -X;
            maxX--;
            for (int yval = 1; yval <= maxY; yval++)
            {
                array[x, y + Y * yval] = val;
                val++;
            }
            y = y + Y * maxY;
            Y = -Y;
            maxY--;
        }
        return array;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[j,i]:00} ");
        }
        Console.WriteLine();
    }
}