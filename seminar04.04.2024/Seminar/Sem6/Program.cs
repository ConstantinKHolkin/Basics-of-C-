// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string CharArrayToString(char[] charArray)
// {
//     string result = string.Empty;
//     for (int i = 0; i < charArray.Length; i++)
//     {
//         result = result + charArray[i];
//     }
//     return result;
// }

// char[] InputCharArray()
// {
//     System.Console.WriteLine("Input number of array size: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     char[] array = new char[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToChar(Console.ReadLine());
//     }
//     return array;
// }

// System.Console.WriteLine(CharArrayToString(InputCharArray()));


// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// char[] StringToCharArray (string str)
// {
//     char[] chars = new char[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i];
//     }
//     return chars;
// }

// void PrintCharsArray(char[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(" ' " + array[i] + " ' ");
//     }
//     System.Console.WriteLine();
// }

// PrintCharsArray(StringToCharArray("Hello!"));

// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int SumOfVowels (string str)
{
    int result =0;
    string str1 = "aoeiuy";
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < str1.Length; j++)
        {
            if (str1[j] == str[i])
            {
                result++;
            }
        }
    }
    return result;
}  

System.Console.WriteLine(SumOfVowels("Hello"));