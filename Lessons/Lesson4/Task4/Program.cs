int SizeArray (string s)
{
    int size = 0;
    foreach (char e in s)
    {
        if(Char.IsAsciiLetter(e) == false)
        {
            size = size + 1;
        }
    }
    return size;
}

int[] CrateArry (int size)
{
    int[] arry = new int[size];
    return arry;
}


int[] RecordArray (int[] array, string s)
{
    int i = 0;
    if (array.Length > 0)
    {
        foreach (char e in s)
        {
            if (Char.IsAsciiLetter(e) == false)
            {
                array [i] = int.Parse(Char.ToString(e));
                i = i + 1;
            }


        }
        return array;
    }
    else
    {
        return array;
    }
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}

System.Console.WriteLine("Введите строку");
string str = System.Console.ReadLine();
int[] array = CrateArry(SizeArray(str));
int[] result = RecordArray (array, str);
PrintArray (result);
