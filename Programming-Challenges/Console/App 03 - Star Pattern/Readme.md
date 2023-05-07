# Star Pattern

Write a program that displays the following pattern:

```
   *
  ***
 *****
*******
 *****
  ***
   *
```

# Application Example

## [Program.cs](https://github.com/Thesnowmanndev/CSharp-Education/blob/main/Programming-Challenges/Console/App%2003%20-%20Star%20Pattern/StarPattern/Program.cs)

```
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
```

## Application in Operation:
![example](https://github.com/Thesnowmanndev/CSharp-Education/blob/main/Programming-Challenges/Console/App%2003%20-%20Star%20Pattern/example.png?raw=true)