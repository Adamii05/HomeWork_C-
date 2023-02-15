//буду делать через метод

Console.Clear();
Console.Write ("Введите день недели цифрой: ");
int number = Convert.ToInt16(Console.ReadLine()); //данный оператор преобразует строку в число
void day (int name)
{
if (name==6 || name==7) 
Console.WriteLine("этот день является выходным");
else Console.WriteLine ("это рабочий день, беги работать!");
}
day(number);

