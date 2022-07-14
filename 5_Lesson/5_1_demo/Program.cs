// Задача 1: Задайте массив из 12 элементов заполненные случайными цифрами [-9, 9] Найдите сумму отрицательных и положителььных элементов массива.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void Print(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

 int [] MassNums(int size)
    {
    int[] arr = new int[size];

        for (int i =  0; i < size; i++)
        {
            arr[i] = new Random().Next(-9, 10); // верхняя граница не включается
        }
        return arr;
    }

void SumMaxMin(int[] arr)
{
int s_max, s_min;
 s_max = s_min = 0;

for (int i =  0; i < arr.Length; i++)
        {
            if (arr[i] >= 0) s_max += arr[i];
            else s_min += arr[i];
        }
Console.WriteLine($"sun max:{s_max}, sun min:{s_min}");
}

int[] arr_1 = MassNums(12);
Print(arr_1);
SumMaxMin(arr_1);
