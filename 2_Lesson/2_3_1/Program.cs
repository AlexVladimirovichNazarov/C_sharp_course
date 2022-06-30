// Принимаем два числа на вход и выводимб является ли 2 число кратным 1. Если число 2 не кратно числу 1б то выводим остаток от деления.

void OneOfNum(int num_1, int num_2)
{
if (num_1 % num_2 == 0)
{
    Console.WriteLine($"{num_1}, {num_2} -> multiple");
}
else
{
    Console.WriteLine($"{num_1}, {num_2} -> not multiple, theremainder {num_1 % num_2}");
}
}OneOfNum(16, 4);