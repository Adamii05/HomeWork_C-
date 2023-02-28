// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write ("Задайте размер массива...");
int A = Convert.ToInt32(Console.ReadLine());
double [] Array;
int size = A;
Array = new double [size];

void FillArray (double [] collection)
{
    int length = collection.Length;
    int count = 0;
    while (count<length)
    {
        collection[count] = new Random().Next (1,100);
        count++;
    }

}

void PrintArray (double [] col)
{
    int length1=col.Length;
    int count1 = 0;
    while(count1<length1)
    {
        Console.WriteLine (col[count1]);
        count1++;
    }

}

double max (double [] array)
{
    int length2 = array.Length;
    int index = 0;
    double max = array[index];
    while(index<length2)
    {
        if (array [index] > max) max = array [index];
        index++; 
    }
    return max; 

}

double min (double [] array1)
{
    int length3 = array1.Length;
    int index1 = 0;
    double min = array1[index1];
    while(index1<length3)
    {
        if (array1 [index1] < min) min = array1 [index1];
        index1++; 
    }
    return min; 

}



FillArray(Array);
PrintArray(Array);
double res = max (Array) - min (Array);
Console.Write("Разница между максимальным и минимальным элементом массива = ");
Console.WriteLine(res);
