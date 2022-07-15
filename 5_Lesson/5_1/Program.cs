// поменят знак на противоположный у элементов массива

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

void ChangeNum (int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = -arr[i];
}
Console.WriteLine();
}
int[] arr_1 = MassNums(12);
Print(arr_1);
ChangeNum(arr_1);
Print(arr_1);
