// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементов каждой строки двумерного массива.
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
int [,] SortByRows (int [,] array)
{   int temp=0;
    for (int i = 0; i < array.GetLength(0); i++)
        for(int k=0; k< array.GetLength(1)-1; k++)
           for (int j = 0; j < array.GetLength(1)-1; j++)
                if (array[i,j+1]>array[i,j])
                {
                    temp=array[i,j];
                    array[i,j]=array[i,j+1];
                    array[i,j+1]=temp;
                }
    return array;
}

Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] myarray = CreateRandomArray(m, n, min, max);
ShowArray (myarray);
Console.WriteLine("Массив, упорядоченный по убыванию элементов каждой строки");
SortByRows (myarray);
ShowArray (myarray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int FindRowMinSumm (int [,] array)
{   int [] arraysum = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        {   int summ=0;
            for (int j = 0; j < array.GetLength(1); j++)
                summ+=array[i,j];
            arraysum[i]=summ;
        }
    int min=arraysum[0];
    int minpos=0;
    Console.Write("Массив сумм по строкам: ");
    for (int i = 0; i < arraysum.GetLength(0); i++)
        {Console.Write(arraysum[i] + " ");
        if (arraysum[i]<min) 
            {   
                minpos=i;
                min=arraysum[i];
            }
        }
    Console.WriteLine();
    return minpos;
}
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] myarray = CreateRandomArray(m, n, min, max);
ShowArray (myarray);
Console.WriteLine($"Номер строки с минимальной суммой элементов = {FindRowMinSumm(myarray)}");
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
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
int [,] MatrixMultiplication (int [,] matrix1, int[,] matrix2) 
{
    int[,] resultMatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int i = 0; i < matrix1.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            {
            int summ=0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
                summ += matrix1[i,k] * matrix2[k,j];
      
            resultMatrix[i,j] = summ;
            }
    return resultMatrix;
}
Console.Write("Введите число строк 1й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 1й матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 2й матрицы: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] matrix1 = CreateMatrix(m, n, min, max);
int [,] matrix2 = CreateMatrix(n, k, min, max);
Console.WriteLine("Матрица 1:");
ShowArray (matrix1);
Console.WriteLine("Матрица 2:");
ShowArray (matrix2);
Console.WriteLine("Результат умножения матриц:");
ShowArray(MatrixMultiplication(matrix1,matrix2));
*/

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[] CreateRandomDifferentArray(int size) //Создание одномерного массива из неповторяющихся элементов
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(10, 100);
        for (int j = 0; j < i; j++)
            while (newArray[i] == newArray[j])
                {
                    newArray[i] = new Random().Next(10, 100);
                    j = 0;
                }
                    
    }
    return newArray;
}
int[,,] CreateRandomDifferent3DArray(int x, int y, int z, int [] array) // Создание 3х мерного массива из одномерного
{   int [,,] array3d = new int[x,y,z];
    int count=0;
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < z; k++)
                {
                    array3d[i, j, k] = array[count];
                    count++;
                }
    return array3d;
}
void ShowArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
        Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
        Console.WriteLine();
        }
}
Console.Write("Введите размерность массива х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность массива y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность массива z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Трехмерный массив из разных элементов:");
int [,,] array3d = CreateRandomDifferent3DArray(x,y,z, CreateRandomDifferentArray(x*y*z));
ShowArray (array3d);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив M на N.

void SpiralFillMatrix(int m, int n)
{int [,] matrix = new int[m,n];
int count=1;
int t=0;  //сдвиг от края матрицы после первого прохода по периметру
int i = 0;
int j = 0;
do  {
    if (count>m*n) break;     
    for (i=t; i<n-t; i++)     // движение вправо
        matrix[t,i]=count++;
    if (count>m*n) break;    
    for (j=1+t; j<m-t; j++)   // движение вниз  
        matrix[j,n-1-t]=count++;
    if (count>m*n) break;
    for (i=n-2-t; i>=t; i--)  // движение влево  
        matrix[m-1-t,i]=count++;
    if (count>m*n) break;
    for (j=m-2-t; j>t; j--)   // движение вверх  
        matrix[j,t]=count++;
    t++;
    
} while (count<=m*n);   
Console.WriteLine();
for (i=0; i<m; i++)
    {
    for (j=0; j<n; j++)
        if (matrix[i,j] / 10 <= 0)
            Console.Write($" {matrix[i,j]} ");
        else Console.Write($"{matrix[i,j]} ");
    Console.WriteLine();
    }
}
Console.Write("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
SpiralFillMatrix(m,n);