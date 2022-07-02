// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Week(int num)
{
    // int index = 1;

    if (num == 6)
    {
        Console.WriteLine("Ура выходной!");
    }
    else if (num == 7)
    {
        Console.WriteLine("Ура выходной!");
    }
    else
    {
        Console.WriteLine("Будни. Хнык, хнык... Опять идни на работу.");
    }
   
}

int n = new Random().Next(1, 7);
Console.WriteLine("День недели:");
Console.WriteLine(n);

Week(n);
