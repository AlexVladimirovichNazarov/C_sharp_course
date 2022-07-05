// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// 1 решение

void palindrome(int num)
{
    Console.WriteLine(num);
    if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}

palindrome(14212);
palindrome(12821);
palindrome(23432);

// 2 решение

void Palindrome(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "yes";

    while (i < size / 2)
    {
        if (num[i] != num[size - 1])
        {
            flag = "no";
            break;
        }
        i += 1;
    }
    Console.WriteLine($"{n}" -> {flag});
}
Palindrome(14212);
Palindrome(12821);
Palindrome(23432);
Palindrome(12488421);
