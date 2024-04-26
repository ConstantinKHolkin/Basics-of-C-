int FactNumber (int n)
{
    if (n == 1 || n == 0)   
    {
        return 1;
    }
     return n * FactNumber(n-1);
     
    
}

System.Console.WriteLine(FactNumber(5));