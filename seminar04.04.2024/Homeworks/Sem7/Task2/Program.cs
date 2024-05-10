// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Akkerman(int m, int n) //Расчет функции Аккермана
{
    if (m < 0 || n < 0) //при отрицательном чесле вызов исключения
    {
        throw new ArgumentOutOfRangeException();
    }
    else if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else 
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }

}

//Запрос у пользователя числа
System.Console.WriteLine("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

//Вывод функции
System.Console.WriteLine(Akkerman(m,n));

