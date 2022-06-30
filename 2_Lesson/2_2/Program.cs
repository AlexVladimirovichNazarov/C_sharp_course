// Вывести случайное число из отрезка [10, 99] и показать наибольшую цифру числа.

int Maxnumber(int num)
{
    if (num % 10 > num / 10)
    {
        return num % 10;
    }
    else
        return num / 10;
}


int SecondNumm = new Random().Next(10, 99);

Console.WriteLine(SecondNumm);
Console.WriteLine(Maxnumber(SecondNumm));
