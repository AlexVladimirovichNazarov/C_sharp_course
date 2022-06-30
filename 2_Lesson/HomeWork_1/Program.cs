// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Number2(int num)
{
    return (num / 10) % 10;
}
int n = new Random().Next(100, 999);
Console.WriteLine("Трёхзначное число:");
Console.WriteLine(n);


Console.WriteLine("Вторая цифра числа:");
Console.WriteLine(Number2(n));
