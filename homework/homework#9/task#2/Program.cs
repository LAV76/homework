Console.Write("Введи первое число промежутка : ");
int N  = int.Parse(Console.ReadLine()!);
Console.Write("Введи первое число промежутка : ");
int M  = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N, M)); 

// ------------------Метод------------------
int PrintNumbers(int N, int M){
    if(M == 0) return (N * (N + 1)) / 2;
    if(M ==N) return M;
    if(M < N) return N + PrintNumbers(N-1, M);
    return N + PrintNumbers(N+1, M);
}
