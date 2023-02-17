// Показать натуральные числа от M до N, N и M заданы


string NumbersFor(int M, int N)
{
    string result = String.Empty;
    for (int i = M; i <=N; i++)
    {
        result += $"{i} ";
    }
return result;
}

string NumbersRec(int M, int N)
{
    if (M<=N) return $"{M} " + NumbersRec(M + 1, N);
    else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));