// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран ОТСОРТИРОВАННЫЕ arr arr_1 заполненные случайными цифрами.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] arr = { 1, 2, 5, 7, 19, 6, 1, 33 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

 int [] EightMass()
    {
        int size = 8;

        int[] arr = new int[size];

        for (int i =  0; i < size; i++)
        {
            arr[i] = new Random().Next(1, 100);
        }
        return arr;
    }


PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);

int[] arr_1 = EightMass();
PrintArray(arr_1);
