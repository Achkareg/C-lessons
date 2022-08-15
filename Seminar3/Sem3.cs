//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*void Polindrom (int number)
{
    int firstdigit=number/10000;
    int seconddigit=(number/1000)%10;
    int thirddigit=(number/100)%10;
    int forthdigit=(number/10)%10;
    int fifthdigit=number%10;
    if (firstdigit==fifthdigit&&seconddigit==forthdigit)
    Console.WriteLine("Polindrom!");
    else Console.WriteLine("Not polindrom");
}
Console.WriteLine("Please insert 5-digit number");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number)>=10000&&Math.Abs(number)<=99999)
Polindrom(number);
else Console.WriteLine("The number is not 5-digit");
*/

// Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistance3d (double x1, double y1, double z1, double x2, double y2, double z2)
{
   return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)); 
  
}
Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double dist = FindDistance3d (x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Distance between points is {dist}");
*/
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int n)
{
    int i = 1;
    while(i <= n)
    {
        Console.WriteLine(i*i*i);
        i++;
    }

}
Console.Write("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("All cubes of numbers till your number");
Cube(number);


