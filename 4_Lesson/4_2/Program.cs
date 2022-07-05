// Принимаем число и выдаём кол-во цифр в чиле.

int CountNum(int num) 
{
    string result = num.ToString(); // Длина строки
    return result.Length;
}

Console.WriteLine(CountNum(456));
