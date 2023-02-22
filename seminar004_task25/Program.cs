Console.Clear();
Console.WriteLine ("Введите число A:...");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число B:...");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int degree (int X, int Y)
{
    int result = 1;
    int index = 0;
    while (index<Y)
    {
        result = result*X;
        index ++;

    }
    return result;

}

degree (A,B);
Console.Write("Ваш результат ");

Console.WriteLine (degree (A,B));

