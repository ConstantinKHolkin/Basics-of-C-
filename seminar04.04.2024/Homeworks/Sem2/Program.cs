/*Урок 2. Простые Алгоритмы
Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.*/

//Задача 1
void CheckNum (int a)
{
    if (a % 7 == 0 && a % 23 == 0)
    {
        System.Console.WriteLine("The number is a multiple of 7 and 23.");
    }
    else
    {
        System.Console.WriteLine("he number is not a multiple of 7 and 23.");
    }
}

System.Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
CheckNum(a);

//Задача 2

int CoordinateQuarterSearch (int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x > 0 && y < 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
         return 3; 
    }
   else 
    {
        return 4;
    }

}

System.Console.Write("Input X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input Y: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"The is a quarter: {CoordinateQuarterSearch (x, y)}");

//Задача 3

void IargestNumberInTheNumber (int num)
{
    if (num >= 10 && num <= 99)
    {
        int dec = num / 10;
        int ed = num % 10;

        if (dec > ed)
        {
            System.Console.WriteLine($"Max = {dec}");
        }
        else
        {
            System.Console.WriteLine($"Max = {ed}");
        }
    }
    else
    {
        Console.WriteLine("You input not number from 10 to 99 ");
    }
   

}

System.Console.Write("Input number from 10 to 99: ");
int num = Convert.ToInt32(Console.ReadLine());
IargestNumberInTheNumber (num);

//Задача 4

void CommaNumber (int num1)
{
    if (num1 > 0)
    {
        int div = 10;
        for (; div <= num1; div*=10)
        {
            
        }
        div /= 10;
        int separator = 0;
        while (div >= 10)
        {
            separator = num1/div;
            System.Console.Write($"{separator}, ");
            num1= num1 % div;
            div /= 10;
        }
        separator = num1/div;
        System.Console.Write($"{separator}");
    }

    else
    {
      System.Console.WriteLine("The number must be greater than 0");
      System.Console.Write("Input number: ");
      int num2 = Convert.ToInt32(Console.ReadLine());
      CommaNumber(num2);
    }
}

System.Console.Write("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
CommaNumber(num1);