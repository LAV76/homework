Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int rows =new Random().Next(1, 9);
int columns =new Random().Next(1, 9);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

if (SearchNumber(array, number)) {Console.Write($"Введенное число {number} есть масиве");}
else {Console.Write($"Введенное число {number} отсутствует в масиве");}




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

bool SearchNumber(int[,] array, int number){
    bool result = false;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if(array[i, j] == number ) result = true;
        }
    }
    return result;
}
