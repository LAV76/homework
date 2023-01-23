
int rows =new Random().Next(2, 9);
int columns =new Random().Next(2, 9);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine($"[{String.Join("|", ArithmeticMean(array))}]");



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

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[] ArithmeticMean(int[,] array){
    double[] result = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++){
        double count = 0;
        for(int i = 0; i < array.GetLength(0); i++){
            count +=array[i, j];
        }
        result[j] = Math.Round(count/array.GetLength(0), 2);
    }
    return result;
}
