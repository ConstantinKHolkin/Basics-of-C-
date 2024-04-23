
string GetLettersFromString (string s)
{
    string letters ="";
    foreach (char e in s)
    {
        if(Char.IsAsciiLetter(e)== true)
        {
            letters += e;
        }
    }
    return letters;
}
System.Console.WriteLine("Введите строку");
string str = System.Console.ReadLine();
System.Console.WriteLine(GetLettersFromString (str));
