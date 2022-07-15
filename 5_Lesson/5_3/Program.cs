// Задайте массив от 0 до 123. Найдите количество элементов массива которое лежит на отрезке [10, 99].

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
        arr[i] = new Random().Next(0, 123); // верхняя граница не включается
    }
    return arr;
}

void SomeNum(int[] arr)
{
    int Number_1 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 99 && arr[i] > 10) Number_1 +=1;
    }

    Console.WriteLine(Number_1);
}

int[] arr_1 = MassNums(12);
Print(arr_1);

SomeNum(arr_1);
