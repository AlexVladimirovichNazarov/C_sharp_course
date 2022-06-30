// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

void Number3_2(int num)
{
    Console.WriteLine("Первая и третья цифры числа:");
    Console.WriteLine($"{num / 100}{num % 10}");
}
int n = new Random().Next(100, 999);
Console.WriteLine("Трёхзначное число:");
Console.WriteLine(n);

Number3_2(n);
