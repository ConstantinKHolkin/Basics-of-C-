// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] InputCharArray(int rows, int colons)
{
    char[,] array = new char[rows,colons];
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] = Convert.ToChar(Console.ReadLine());
        }   
    }
    return array;
}
string CharArrayToString(char[,] charArray)
{
    string result = string.Empty;
    for (int i = 0; i < charArray.GetLength(0); i++)
    {
        
        for (int j = 0; j < charArray.GetLength(1); j++)
        {
           result = result + charArray[i,j];
        }  
    }
    return result;
}

System.Console.WriteLine("Input matrix rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input matrix colons: ");
int colons = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CharArrayToString(InputCharArray(rows, colons)));
