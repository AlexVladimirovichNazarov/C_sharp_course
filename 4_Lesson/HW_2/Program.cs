// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void SumZifr(int num)
{
    int all_num = 0;

    // 1 решение

    for(int i = num; i > 0; i /= 10) 
    {
        all_num += num%10;
        num /= 10;
    }

    // 2 решение

    // while (num > 1)
    // {
    //     all_num += num%10;
    //     num /= 10;
    // }

    Console.WriteLine(" ");
    Console.WriteLine(all_num);
}

SumZifr(452);
SumZifr(82);
SumZifr(9012);
