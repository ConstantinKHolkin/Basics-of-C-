//Задайте одномерный массив, заполненный случайными
//числами. Определите количество простых чисел в этом
//массиве.
//Примеры
//[1 3 4 19 3] => 2
//[4 3 4 1 9 5 21 13] => 3

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

bool IsPrime(int num)
{
    if (num == 1) return false;
    for (int i = 2; i <= num/2; i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}

int CountPrime(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(IsPrime(array[i])) count++;
    }
    return count;
}

System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of arr element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of arr element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
PrintArray(array);
System.Console.WriteLine(CountPrime(array));
System.Console.WriteLine(NumCounter(array));
System.Console.WriteLine(ConvertToNum(array));

//Задайте массив из N случайных целых чисел (N вводится с
//клавиатуры).
//Найдите количество чисел, которые оканчиваются на 1 и
//делятся нацело на 7.
//Пример
//[1 5 11 21 81 4 0 91 2 3] => 2

int NumCounter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] % 10 == 1 && array[i] % 7 == 0) count++;

    }
    return count;
}

//Заполните массив на N (вводится с консоли, не более 8)
//случайных целых чисел от 0 до 9.
//Сформируйте целое число, которое будет состоять из цифр из
//массива. Старший разряд числа находится на 0-м индексе,
//младший – на последнем.
//Пример
//[1 3 2 4 2 3] => 132423
//[2 3 1] => 231

int ConvertToNum (int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result = result + array[i] * (int)Math.Pow(10, array.Length - 1 - i);
    }
    return result;
}

