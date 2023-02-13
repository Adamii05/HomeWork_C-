// судя по условию задачи числа уже даны: a = 5, b = 7; a = 2, b = 10; a = -9, b = -3;
Console.Clear();
Console.WriteLine("a = 5, b = 7");
int a = 5, b = 7;
int a2 = 2, b2 = 10;
int a3 = -9, b3 = -3;
if (a>b) 
{
  Console.Write("max = ");
  Console.WriteLine(a);  
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b);
}
Console.WriteLine("a = 2, b = 10");
if (a2>b2) 
{
  Console.Write("max = ");
  Console.WriteLine(a2);  
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b2);
}
Console.WriteLine("a = -9, b = -3");
if (a3>b3) 
{
  Console.Write("max = ");
  Console.WriteLine(a3);  
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b3);
}