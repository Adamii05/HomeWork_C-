// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
// то есть по сути, нам нужно сравнить между собой цифры данного числа
// а именно: 1 цифра должна равняться 5, и вторая цифра должна равняться 4. 
// в этом случае пятизначное число будет полиндромом. 
Console.Clear();
Console.Write ("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); //данный оператор преобразует строку в число

void check (int limitdigit)
{
   if (limitdigit>=10000 && limitdigit <=99999)
  Console.WriteLine ("Число введено верно, ожидайте результат");
  else
  Console.WriteLine ("Число не является 5-ти значным, попробуйте другое число");
  
}

check (number);


int first = number/10000;
int fifth = number%10;
int second = (number/1000)%10;
int fourth = (number%100)/10;

if (first==fifth && second == fourth)
Console.WriteLine ("Данное выражение является полиндромом");
else
Console.WriteLine ("Данное выражение не является полиндромом 5-ти значного числа");