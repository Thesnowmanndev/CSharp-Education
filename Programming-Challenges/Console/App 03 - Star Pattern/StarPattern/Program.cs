int size = 4;

// Top side of star
for  (int i = 1; i <= size; i++)
{
    for (int j = 1; j <= size - i; j++)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

// Bottom side of star
for (int i = size - 1; i >= 1; i--)
{
    for (int j = 1; j <= size - i; j++)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}