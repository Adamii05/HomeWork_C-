// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
Console.Write ("Введите число элементов массива  ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [] Array;
int size0 = A;
Array = new int [size0];

void FillArray (int[] collection)
{
    int size = collection.Length;
    int index = 0;
    while (index<size)
    {
        collection [index] = new Random().Next (100,999);
        index++;
    }
}

void PrintArray (int[] col)
{
    int size1 = col.Length;
    int index1=0;
    while (index1<size1)
    {
        Console.WriteLine (col[index1]);
        index1++;
    }
}

int result (int [] sellection)
{
    int size2 = sellection.Length;
    int index2 = 0;
    int result1 = 0;
    while (index2<size2)
    {
        if (sellection[index2]%2==0)
        result1 = result1 + 1;
        index2++;
    }
        return result1;
    

}
FillArray(Array);
PrintArray(Array);
int RESULT = result(Array);
Console.WriteLine();
Console.Write("Количество четных элементов массива = ");
Console.WriteLine(RESULT);
