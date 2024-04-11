/* 
Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.
Примеры
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да



Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6]

Найдите произведения пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и
т.д. Результат запишите в новый массив.
Пример
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)
*/


 int[] CreateArray (int size, int min, int max)
 {
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next (min, max+1); //[min, max] [0,9]
    }
    return array;
 }

 void PrintArray (int[] array)
 {
     for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array [i] + " ");
    }
 }

 bool FindNumArray(int[] array, int num)
 {
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] == num)
        {
            return true;
        }
    }
    return false;
 }

int[] ChangeArry(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        array [i] = -array [i];
    }
    return array;

}

int [] ArrayOfPairs (int[] array)
{
    int[] numbers = new int[array.Length/2];
    for (int i = 0; i < numbers.Length;i++)
    {
        numbers [i] = array [i] * array [array.Length-i-1];
    }
    return numbers;
}
 Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input minimal vale off arr element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max vale off arr element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size,min,max);
PrintArray(array);

Console.WriteLine("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindNumArray(array, num));

PrintArray(ChangeArry(array));

PrintArray(ArrayOfPairs(array));