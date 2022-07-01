// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void Number3(int num)
{
    // int index = 1;

    if (num < 99)
    {
        Console.WriteLine("Третьей цифры в числе нет.");
        // break;
    }

    while (num > 1000)
    {
        num /= 10;
    }

    Console.WriteLine("Третья цифра числа:");
    // Console.WriteLine((num / 100) % 10);
    Console.WriteLine(num % 10);
}

int n = new Random().Next(1, 1000000);
Console.WriteLine("Число:");
Console.WriteLine(n);

Number3(n);
