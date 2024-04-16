void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = 0;
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        System.Console.Write($"{e} ");
    }
}
int[] arry = {1, 2, 3, 4, 5};
ZeroEvenElements(arry);
PrintArray(arry);