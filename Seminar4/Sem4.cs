// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Stepen (int a, int b)
{   
    int res=1;
    for (int i = 1; i <= b; i++)
        res = res * a;   
    return res;
}
Console.Write("Input integer number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer number B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a} в степени {b} = {Stepen(a,b)}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumOfDigits (int number)
{
    int sum = 0; 
    while (number>0)
    {
        sum += number%10;
        number=number/10;
    }            
    return sum;
}
Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = SumOfDigits(a);
Console.WriteLine($"Sum of digits of {a} is {result}");
*/

// Задача 29: Напишите программу, которая запрашивает массив из N элементов и выводит их на экран.

int[] CreateArray(int size)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray (n);
PrintArray(myArray);
