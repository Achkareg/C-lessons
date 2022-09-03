// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void SumNumbers(int m, int n, int summ)
{
    if (n >= m)
    {   summ = summ + n;
        SumNumbers(m, n - 1, summ);
    }
    else Console.Write($"Сумма элементов в промежутке от M до N = {summ}");
}
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int summ=0;
SumNumbers(m,n,summ);

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Ackerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ackerman(m - 1, 1);
  else return Ackerman(m - 1, Ackerman(m, n - 1));
}
Console.WriteLine("Введите два неотрицательных числа m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Функция Аккермана = {Ackerman(m,n)} ");
*/