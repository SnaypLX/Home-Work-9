// Написать программу возведения числа А в целую стень B



int DegreeOfNumber(int numberA, int numberB)
{
    if (numberB < 1) return 1;
    return numberA * (DegreeOfNumber(numberA, numberB - 1));
}

Console.Write("A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"{numberA} в степени {numberB}: {DegreeOfNumber(numberA, numberB)}");