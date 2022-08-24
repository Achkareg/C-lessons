//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] CreateArray(int size)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-е число: ");
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
int CountPos(int[] array)
{   int count=0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]>0) count++;
    return(count);
}
Console.Write("Введите число М: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray (n);
PrintArray(myArray);
Console.WriteLine($"Количество чисел больше 0 = {CountPos(myArray)}");
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double CrossingPointX (double k1, double b1, double k2,double b2)
{
    double x = (b1-b2)/(k1-k2);
    return(-x);
}
double CrossingPointY (double k1, double x, double b1)
{
    double y = k1*x+b1;
    return(y);
}
Console.Write("Введите значение к1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение к2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Координаты точки пересечения = ({CrossingPointX(k1,b1,k2,b2)};{CrossingPointY(k1,CrossingPointX(k1,b1,k2,b2),b1)})");


