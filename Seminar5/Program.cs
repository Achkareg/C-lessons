// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(100, 1000);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int CountChetNumbers(int[] array)
{   int count=0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]%2==0) count++;
    return count;
}
Console.Write("Input size for 3-digits array: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a);
ShowArray(myArray);
Console.WriteLine ($"Число четных чисел = {CountChetNumbers(myArray)}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int SummElementsNechetPos(int[] array)
{
    int summ=0;
    for (int i = 1; i < array.Length; i=i+2)
        summ+=array[i];
    return summ;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {SummElementsNechetPos(myArray)}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int size)
{
double [] newArray = new double[size];
for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        newArray[i] = Convert.ToDouble(Console.ReadLine());
    }
    return newArray;
}
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double Raznica(double[] array)
{
    double max=array[0];
    double min=array[0];
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>max) max=array[i];
            if (array[i]<min) min=array[i];
        }
        //Console.WriteLine($"Максимальный и минимальный элементы = {max},{min}");

    return(max-min);
}
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArray (n);
PrintArray(myArray);
Console.WriteLine($"Разница между максимальным и минимальным элементов = {Raznica(myArray)}");
