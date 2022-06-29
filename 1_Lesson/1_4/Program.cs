Console.Clear();

int x = int.Parse(Console.ReadLine());

// 1 решение

int count = -x;

while (count < x + 1)
{
   Console.WriteLine(count); 
   count += 1;
}

// 2 решение

//int count = 0;

//while (count < 2 * x + 1)
{
//    Console.WriteLine(-x + count);
 //   count += 1;

}