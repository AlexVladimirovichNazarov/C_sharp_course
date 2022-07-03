// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

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
