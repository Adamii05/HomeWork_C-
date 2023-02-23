Console.Clear();
Console.Write ("Введите число элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array;
int size = N;
array = new int [size];
void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection [index] = new Random().Next (1,length);
        index++;
    }
}

void PrintArray (int[] col)
{
    int size1 = col.Length;
    int index = 0;
    while (index<size1)
    {
        Console.WriteLine (col [index]);
        index++;
    }
}

FillArray (array);
PrintArray (array);