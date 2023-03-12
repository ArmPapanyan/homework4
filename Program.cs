// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine(" Input digit A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Input digit B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int c = a; 

//  for (int i = 1; i < b; i++)
//  {
//     c = c *a;
   
//  }   
//  Console.WriteLine ($"A to the extent B equasls  {c} ");



// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// Console.Write("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int len = Length(a);
// Console.Write($" Sum digit in number {a} equals: {Sum(a,len)}");


// int Length(int a)
// {
// int index = 0;
// while (a > 0)
// {
// a /= 10;
// index++;
// }
// return index;
// }

// int Sum(int a, int len)
// {
// int sum = 0;
// for (int i = 1; i <= len; i++)
// {
// sum += a % 10;
// a /= 10;
// }
// return sum;
// }


// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



 int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
    Console.WriteLine ();
}

Console.WriteLine ("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input minimal value of array element:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input maximal value of array element:");
int maxValue = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateRandomArray(size, minValue, maxValue));
