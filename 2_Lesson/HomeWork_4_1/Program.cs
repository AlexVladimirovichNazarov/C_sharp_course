// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Weekend(int num)
{
    string text = "no"; // вводитьься переменная флага
   if (num == 6 || num == 7) text = "eys"; // флаг меняет осстояние!
    {
        Console.WriteLine($"{num} -> {text}");
    }
}

int n = new Random().Next(1, 7);
Console.WriteLine("День недели:");
Console.WriteLine(n);

Weekend(n);