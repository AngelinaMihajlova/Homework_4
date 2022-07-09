/* Программа, которая принимает на вход число и выдаёт сумму цифр в числе
452 -> 11; 82 -> 10; 9012 -> 12 */

int SumNumbers (int N)
{
    int sum = 0;
    while (N > 0)
    {
        sum = sum + N % 10;
        N = N / 10;
    }
Console.WriteLine (sum);
return sum;
}

SumNumbers (452);
SumNumbers (82);
SumNumbers (9012);