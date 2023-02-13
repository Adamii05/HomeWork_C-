// Судя по условию, три тройки чисел уже определены. Поэтому будем работать с ними
// 2 3 7 -> 7 первая тройка
// 44 5 78 -> 78 вторая тройка
// 22 3 9 -> 22 третья тройка
Console.Clear();
Console.WriteLine("Из чисел: 2, 3 и 7:");
int a = 2, b = 3, c = 7;  //первая тройка чисел
int a2 = 44, b2 = 5, c2 = 78;  //вторая тройка чисел
int a3 = 22, b3 = 3, c3 = 9;  //третья тройка чисел
int max = a;
int max2 = a2;
int max3 = a3;
if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;
Console.Write("max = ");
Console.WriteLine(max);
if (a2>max) max3 = a2;
if (b2>max) max3 = b2;
if (c2>max) max3 = c2;
Console.WriteLine("Из чисел: 44, 5 и 78:");
Console.Write("max = ");
Console.WriteLine(max2);
if (a3>max) max3 = a3;
if (b3>max) max3 = b3;
if (c3>max) max3 = c3;
Console.WriteLine("Из чисел: 22, 3 и 9:");
Console.Write("max = ");
Console.WriteLine(max3);