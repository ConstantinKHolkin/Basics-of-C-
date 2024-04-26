void OpenMatryoshca (int size)
{
    if (size == 0)
    {
        return;
    }

    System.Console.WriteLine($"Open matryoshca of {size}");
    OpenMatryoshca(size - 1);
}

OpenMatryoshca(5);