// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] CreateRandomArray (int rows, int columns, double minValue, double maxValue)
{
    double [,] newArray = new double[rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
    newArray[i,j] = new Random().NextDouble()*(maxValue - minValue) + minValue;
    return newArray;
}
void ShowArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
        }
}
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное число: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите максимально возможное число: ");
double max = Convert.ToDouble(Console.ReadLine());
double [,] myarray = CreateRandomArray(m, n, min, max);
ShowArray (myarray);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
int [,] newArray = new int[rows,columns];
for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
    newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
        }
}
void FindElement(int [,] array, int rowNumber, int colNumber)
{
    if (rowNumber<array.GetLength(0) && colNumber<array.GetLength(1))
    Console.WriteLine ($"Искомый элемент = {array[rowNumber, colNumber]}");
    else Console.WriteLine ($"Элемента с индексом ({rowNumber};{colNumber}) не существует");
}
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное число: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки искомого элемента: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца искомого элемента: ");
int colNumber = Convert.ToInt32(Console.ReadLine());

int [,] myarray = CreateRandomArray(m, n, min, max);
ShowArray (myarray);
FindElement(myarray,rowNumber,colNumber);
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
double[] Average(int[,] array)
{

    double[] avg = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
            sum += array[j, i];
        avg[i] = sum / array.GetLength(0);
    }
    return (avg);
}
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myarray = CreateRandomArray(m, n, min, max);
ShowArray(myarray);
Console.WriteLine("Среднее арифметическое по столбцам: ");
double[] avg = Average(myarray);
for (int i = 0; i < avg.Length; i++) Console.Write(avg[i] + " ");