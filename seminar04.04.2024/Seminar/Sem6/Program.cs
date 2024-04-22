// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

string CharArrayToString(char[] charArray)
{
    string result = string.Empty;
    for (int i = 0; i < charArray.Length; i++)
    {
        result = result + charArray[i];
    }
    return result;
}

char[] InputCharArray()
{
    System.Console.WriteLine("Input number of array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    char[] array = new char[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToChar(Console.ReadLine());
    }
    return array;
}

System.Console.WriteLine(CharArrayToString(InputCharArray()));


