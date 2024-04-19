// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.


string Request()// Запрос у пользователя входные данные
{
    System.Console.WriteLine("Введите число");
    System.Console.WriteLine("Для выхода используйте символ q или число, сумма цифр которого чётная");
    string input = System.Console.ReadLine();
    return input;
}

bool CheckNum (string input) //Проверка введенного символа
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

void RepitRequest () //реализация повтора
{
    while (CheckNum(Request()) == true)
    {
        Request();
    }
}


RepitRequest ();


// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillingTheArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

int SummEvenNumbers (int[] array)
{
    int sum = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

System.Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillingTheArray (size);
System.Console.WriteLine($"Количество четных чисел равна: {SummEvenNumbers(array)}");

// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreateArray(int size, int min, int max) //Заполнение массива
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(min, max);
            }
            System.Console.WriteLine($"Массив создан.");
            return array;
        }

        void PrintArray(int[] array) // Печать массива массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write(array[i] + " ");
            }
            System.Console.WriteLine();
        }

        int[] ReverseArray(int[] array)// Переворачиваем массив
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
            System.Console.WriteLine($"Массив перевернут.");
            return array;
        }

        System.Console.WriteLine($"Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Введите минимальное значение элемента: ");
        int min = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Введите максимальное значение элемента: ");
        int max = Convert.ToInt32(Console.ReadLine());
        int[] array = CreateArray(size, min, max);
        PrintArray(array);
        ReverseArray(array);
        PrintArray(array);