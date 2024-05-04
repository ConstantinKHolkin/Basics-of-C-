
// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void SearchForNaturalNumbers (int m,int n)
{
    if (m > 0 && n > 0)
    {
        if (n < m)
        {
            SearchForNaturalNumbers(m - 1, n);
            System.Console.Write(m + " ");
        }
        else if (n > m)
        {
            SearchForNaturalNumbers(m, n - 1);
            System.Console.Write(n + " ");
        }
        else
        {
            System.Console.Write(m + " ");
        }
    }
    else 
    {
        System.Console.WriteLine("There are no natural numbers!");
    }

}


System.Console.WriteLine("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

SearchForNaturalNumbers (m, n);