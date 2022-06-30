using System;

namespace _2_2
{
    class Program
    {
        static int CheckinValues(in int val1, in int val2)
        {
            return (val1 % val2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое число:");
            int value2 = int.Parse(Console.ReadLine());

            int val = CheckinValues(in value1, in value2);

            if (val == 0)
            {
                Console.WriteLine("Числа кратные");
            }
            else
            {
                Console.WriteLine($"Остаток от деления {val}");
            }
        }



    }


}

