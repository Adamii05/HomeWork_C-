// Попробовал решить через метод. Вроде получилось.

Console.Clear();
int value (int abc)
{
  int result1 = abc/10;
  int result = ((abc/10)%10);
  return result;
}
int digit1 = 456;
int digit2 = 782;
int digit3 = 918;
Console.WriteLine (value(digit1));
Console.WriteLine (value(digit2));
Console.WriteLine (value(digit3));


