// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write ("Введите количество чисел, которое хотите задать: ");
int A = Convert.ToInt32(Console.ReadLine());
int [] Array;
int size = A;
Array = new int [size];

void FillArray (int [] collection)
{
    int number = collection.Length;
    int index = 0;
    while (index<number)
    {
        collection[index] = Convert.ToInt32 (Console.ReadLine());
        index++;
    }

}

int positive (int [] numbers)
{
    int length1 = numbers.Length;
    int quant = 0;
    int result = 0;
    {
        while (quant<length1)
        {
            if (numbers[quant]>0) result = result + 1;
            quant ++;
        }
        
        return result;
    }
}

FillArray (Array);
int RESULT = positive(Array);
Console.WriteLine();
Console.Write("Количество положительных чисел, которые вы ввели =  ");
Console.WriteLine(RESULT);
