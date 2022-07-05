// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void AvB(int a, int b)
{
    int AstepB = 1;
    for(int i = 1; i <= b; i++) 
    {
    AstepB *= a;
    }
    Console.WriteLine(AstepB);
}

AvB(3, 5);
AvB(2, 4);
