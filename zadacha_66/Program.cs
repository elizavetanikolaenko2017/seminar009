/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

static void ReadInt(string promt)
{
    Console.WriteLine(promt);
     Convert.ToInt32(Console.ReadLine());
}

static int NewSum(int m, int n)
{
    if(m==n)
    return n;
    return n + NewSum(m,n-1);
}

static void Main(string[]args)
{
  Console.WriteLine(NewSum(ReadInt("Введите число m: "),ReadInt("Введите число n: "));
}
