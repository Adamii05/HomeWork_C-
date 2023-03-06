//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.Write ("b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x (double b1, double k1, double b2, double k2)
{
    double result = (b2-b1) / (k1-k2);
    return result;
}


double y (double b1, double k1, double x)
{
    double result1 = k1*x+b1;
    return result1;
}

double xresult = x (b1,k1,b2,k2);
double yresult = y (b1,k1,xresult);
Console.Write (yresult);
Console.WriteLine (xresult);

