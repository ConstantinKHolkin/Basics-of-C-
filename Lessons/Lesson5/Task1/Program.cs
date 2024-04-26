int FactNumber (int n) //Метод факториала числа (Рекурсия)
{
    if (n == 1 || n == 0) // Условия остановки
    {
        return 1;
    }
     return n * FactNumber(n-1); //Рекурсия
     
    
}

System.Console.WriteLine(FactNumber(5));