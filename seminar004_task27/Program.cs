Console.Clear();
Console.WriteLine ("Введите число...");
int A = Convert.ToInt32(Console.ReadLine());
//int y = A.ToString().Length;

int Sum (int number)
{
    int result = 0;
    while (number>0)
    {
        result = result + number%10;
        number = number/10;
    }

    return result;
}

int SumDigit = Sum (A);
Console.WriteLine (SumDigit);