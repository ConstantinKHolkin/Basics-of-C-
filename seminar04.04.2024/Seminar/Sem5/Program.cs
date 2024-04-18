//задача 1:
//Задайте двумерный массив. Найдите элементы, у которых оба
//индекса чётные, и замените эти элементы на их квадраты.
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

