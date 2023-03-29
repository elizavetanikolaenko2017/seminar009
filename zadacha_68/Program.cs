/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int ReadInt(string promt)
{
    Console.WriteLine(promt);
     Convert.ToInt32(Console.ReadLine());
}

 int Recursion(int m, int n)
{
 if(m==0)
 {
   return n +1; 
 }
  
  else if(n==0 && m>0)
  {
    return Recursion(m-1,1);
  }
  else
  {
    return Recursion(m-1,Recursion(m, n-1));
  }

}

int m= ReadInt("Введите число m: ");
int n= ReadInt("Введите число n: ");
int AkkermanF=Recursion(m,n);
Console.Write($"Функция Аккермана= {AkkermanF}");