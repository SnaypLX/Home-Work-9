// Найти сумму цифр числа


int SumDigits(int number)
{
    if (number < 1) return 0;
    int result = 0;
    return SumDigits(number / 10) + number % 10;
}
Console.Write("Число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр: {SumDigits(number)}");