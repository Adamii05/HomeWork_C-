Console.Clear();
Console.WriteLine ("Введите число N...");
int N = Convert.ToInt32(Console.ReadLine());
int[] array; // создаем просто массив
int length = N; // создаем переменню длинна и присваеваем ей значение N, которое вводит пользователь
array = new int[length]; // теперь говорим, что наш массив - это новый массив длинны length, то есть N

void FillArray (int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection [index] = index + 1;
        index ++;
    }
}

void PrintArray (int[] print)
{
    int count = print.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine (print[position]*print[position]*print[position]);
        position ++;
    }
}

FillArray (array);
PrintArray (array);