Console.Write("Введи первое число промежутка : ");
nint N  = nint.Parse(Console.ReadLine()!);
Console.Write("Введи первое число промежутка : ");
nint M  = nint.Parse(Console.ReadLine()!);

Console.WriteLine(Ackerman(N, M)); 

// ------------------Метод------------------


nint Ackerman(nint N, nint M)
{
  if (N == 0)
    return M + 1;
  else
    if ((N > 0) && (M == 0))
      return Ackerman(N - 1, 1);
    else
      return Ackerman(N - 1, Ackerman(N, M - 1));
}
