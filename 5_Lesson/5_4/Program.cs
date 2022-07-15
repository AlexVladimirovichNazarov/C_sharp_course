// Найти произведение пар чисел в одномерном массиве.
// 1 и последнийб 2 и предпоследний и т.д.
// Результат запишите в новом массиве.

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
        arr[i] = new Random().Next(0, 10); // верхняя граница не включается
    }
    return arr;
}

int[] NewMass(int[] arr)
{
    int size = arr.Length;
    int[] result = new int[size / 2 + size % 2];

    for (int i = 0; i < size / 2 + size % 2; i++)
    {
        result[i] = arr[i] * arr[size - i - 1];

        if (size % 2 != 0 && i == size / 2 + size % 2 - 1) result[i] = arr[i];
    }

    return result;
}

int[] arr_1 = MassNums(5);
Print(arr_1);

Print(NewMass(arr_1));
