Console.Clear();
Console.Write ("Введите координату X1 ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату Y1 ");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату Z1 ");
double Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату X2 ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату Y2 ");
double Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координату Z2 ");
double Z2 = Convert.ToInt32(Console.ReadLine());

void distance (double A1, double B1, double C1, double A2, double B2, double C2)
{
double interm = Math.Sqrt(((A2-A1)*(A2-A1)+(B2-B1)*(B2-B1)+(C2-C1)*(C2-C1)));
Console.WriteLine(interm);
}

distance(X1,Y1,Z1,X2,Y2,Z2);
