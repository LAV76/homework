Console.Write("Введи число: ");
int N  = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N)); 

// ------------------Метод------------------
string PrintNumbers(int N){
    if(N < 1) return ""; 
    return (N + " " + PrintNumbers(N-1));
}
