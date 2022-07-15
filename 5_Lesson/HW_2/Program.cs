// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        arr[i] = new Random().Next(-100, 100); // верхняя граница не включается
    }
    return arr;
}

void NumSumNeChot(int[] arr)
{
    int N = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((i % 2) == 1) N += arr[i];
    }

    Console.WriteLine(N);
}

int[] arr_1 = MassNums(4);
Print(arr_1);

NumSumNeChot(arr_1);