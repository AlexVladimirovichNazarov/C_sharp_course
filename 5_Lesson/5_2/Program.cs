// Задайте массив. Присутствует ли заданное число в массиве?

void Print(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-9, 10); // верхняя граница не включается
    }
    return arr;
}

void SomeNum(int[] arr, int number)
{
    // 1 вариант
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        if (arr[i] == number) Console.Write("Да ");
    //        else Console.Write("Нет ");
    //    }

    // 2 вариант
    string Flag = "No";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        {
            Flag = "Yes";
            break;
        }
    }
    Console.WriteLine(Flag);
}

    int[] arr_1 = MassNums(12);
    Print(arr_1);

    SomeNum(arr_1, 4);
 