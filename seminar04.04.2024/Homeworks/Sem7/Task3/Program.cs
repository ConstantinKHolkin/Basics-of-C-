// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


int[] CreateArray(int[] array, int min, int max, int i = 0)
{
    
    if (i < array.Length)
    {
        array[i] = new Random().Next(min, max+1);
        CreateArray(array, min, max, i+1);
    }
    return array;
}

void PrintArray (int [] array, int i = 0)
{
    if (i < array.Length)
    {
        PrintArray(array, i + 1);
        System.Console.Write(array[i] + " ");
    }
}


System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of arr element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of arr element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
array = CreateArray(array, min, max);
PrintArray(array);