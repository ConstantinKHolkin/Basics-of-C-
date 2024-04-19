// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

string Request()
{
    System.Console.WriteLine("Введите число");
    System.Console.WriteLine("Для выхода используйте символ q или число, сумма цифр которого чётная");
    string input = System.Console.ReadLine();
    return input;
}

bool CheckNum (string input)
{

    if (input == "q")
    {
        System.Console.WriteLine("Вы использовали символ q. Программа завершина!");
        return false;
    }
    else 
    {
        int num = Convert.ToInt32(input);
        int sum = 0;
          while (num > 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            if (sum % 2 == 0)
            {
                System.Console.WriteLine("Вы использовали число, сумма цифр которого чётная. Программа завершина!");
                return false;
            }
            else
            {
                return true;
            }
    }
}

void RepitRequest ()
{
    while (CheckNum(Request()) == true)
    {
        Request();
    }
}


RepitRequest ();