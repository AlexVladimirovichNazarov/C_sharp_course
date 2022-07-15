// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
        arr[i] = new Random().Next(0, 100); // верхняя граница не включается
    }
    return arr;
}

void RaznizaMaxMin(int[] arr)
{
    int max = arr[0];
    int min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    int result = max - min;
    Console.WriteLine(result);
}

int[] arr_1 = MassNums(4);
Print(arr_1);

RaznizaMaxMin(arr_1);
