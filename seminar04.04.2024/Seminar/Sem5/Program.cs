//задача 1:
//Задайте двумерный массив. Найдите элементы, у которых оба
//индекса чётные, и замените эти элементы на их квадраты.

//задача 2:
//Задайте двумерный массив. Найдите сумму элементов,
//находящихся на главной диагонали (с индексами (0,0); (1;1) и
//т.д.
//Пример
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4

// задача 3:
// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

int[,] CreateMatrix(int rows, int colons, int min, int max)
{
    int[,] matrix = new int[rows, colons];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colons; j++)
        {
            matrix[i, j] = new Random().Next(min, max+1);//[min,max] [0,9]
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} "); 
        }
        System.Console.WriteLine(); 
    }
}

int[,] EvenIndxSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i,j] = matrix[i,j] * matrix[i,j];
            }
        }    
    }
    return matrix;
}

int SumMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
               sum += matrix[i,j];
            }
        }   
    }
    return sum;
}

double[] MidlSumArray (int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(0)];
    double summatrix = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summatrix += matrix[i,j];
        }   
        arr [i] = summatrix/matrix.GetLength(1);
        summatrix = 0;
    }
    return arr;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

System.Console.WriteLine("Input matrix rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input matrix colons: ");
int colons = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of arr element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of arr element: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] matrix = CreateMatrix(rows,colons, min, max);
PrintMatrix (matrix);
PrintMatrix(EvenIndxSquare(matrix));
System.Console.WriteLine(SumMatrix(matrix));
PrintArray(MidlSumArray(matrix));
