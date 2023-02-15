// Для двухзначных и трехзначных чисел я сделал через метод, а вот с числом побольше не додумался пока, поэтому сделал просто.
Console.Clear();
int value (int a)
{
    int check = a/10;
    if (check<10)
    {
        Console.WriteLine ("У данного числа нет третьей цифры");
        return a*0;
    }
    int result = a%10;
    return result;
}

int c=32679;
int interm = c/100;

int digit1 = 645;
int digit2 = 78;

Console.WriteLine(value(digit1));
Console.WriteLine(value(digit2));
Console.WriteLine(interm%10);