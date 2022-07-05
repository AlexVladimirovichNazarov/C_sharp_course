// Принимаем число А и передаём произведение от 1 до А

int MultNum(int num)
{
int all_mult = 1;
for(int i = 1; i <= num; i++)
{
    all_mult *=  i;
}
return all_mult;
}

Console.WriteLine(MultNum(4));
Console.WriteLine(MultNum(5));
