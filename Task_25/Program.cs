/* Программа, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵);  2, 4 -> 16 */

double usePow (int A, int B)
{
    double result = Math.Pow (A,B);
    Console.WriteLine (result);
    return result;
}

usePow (3, 5);
Console.WriteLine ();
usePow (2, 4);