// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
string ReverseString(string str)
{
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
string SimplifyingTheString(string str)
{
    str = str.Replace(" ", "").ToLower();
    return str;
}
void Comparison (string str, string str2)
{
    if (str == str2)
    {
        System.Console.WriteLine("Строка является палиндромом.");
    }
    else 
    {
        System.Console.WriteLine("Строка не является палиндромом.");
    }
}


System.Console.WriteLine("Введите строку: ");
string str = Console.ReadLine();
str = SimplifyingTheString(str);
string str2 = ReverseString(str);
Comparison(str, str2);
   
   
