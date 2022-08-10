// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int ShowSecondDigit (int number)
{
    int n = (number/10)%10;
    return n;
}
int num=new Random().Next(100,1000);
Console.WriteLine("Random number is :"+num);
int num2 = ShowSecondDigit(num);
Console.WriteLine("This number without second digit: "+ num2);
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ShowThirdDigit (int number)
{
    while (number >= 1000) 
    number /= 10;
    int n3 = number % 10;
    return n3;
    
}
Console.WriteLine("Please insert the number");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100>1) 
    {int num2 = ShowThirdDigit(number);
    Console.WriteLine("The third digit: "+ num2);
    }
else Console.WriteLine("There is no third digit");
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool Dayoff (int day)
{
    if (day==6||day==7) return true;
    else return false;
}
l1: Console.WriteLine("Please insert the week day");
int d = Convert.ToInt16(Console.ReadLine());
if (d>7) 
    {
        Console.WriteLine ("Incorrect data");
        goto l1;
    }
bool isday = Dayoff(d);
Console.WriteLine(isday);
*/