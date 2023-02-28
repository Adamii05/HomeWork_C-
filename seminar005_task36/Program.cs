// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Задайте размер массива...");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [] Array;
int size = A;
Array = new int [size];
void FillArray (int [] collection)
{
    int length = collection.Length;
    int count = 0;
    while (count<length)
    {
        collection[count] = new Random().Next (1,100);
        count++;
    }

}

void PrintArray (int [] col)
{
    int length1=col.Length;
    int count1 = 0;
    while(count1<length1)
    {
        Console.WriteLine (col[count1]);
        count1++;
    }

}

FillArray(Array);
PrintArray(Array);

int Sum (int [] array)
{
    int size0 = array.Length;
    int index = 0;
    int result = 0;
    while (index<size0)
    {
        if (index%2!=0)
        result = result + array[index];
        index++;
    }

        return result;
}

int RESULT = Sum (Array);
Console.Write ("Сумма нечетных элементов массива = ");
Console.WriteLine (RESULT);
