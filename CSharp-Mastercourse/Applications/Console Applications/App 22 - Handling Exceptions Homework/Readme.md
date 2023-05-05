# Handling Exceptions Homework

Instructions: Create a console application with a for loop that throws an exception after five iterations. Catch the exception.

## Application Preview

To see the code source click here: Program.cs

![example](https://github.com/Thesnowmanndev/CSharp-Education/blob/main/CSharp-Mastercourse/Applications/Console%20Applications/App%2022%20-%20Handling%20Exceptions%20Homework/example.png?raw=true)

## Code Preview:

```
try
{
	for (int i = 1; i <= 10; i++)
	{
		Console.WriteLine("Iteration: " + i);

		if (i == 5)
		{
			throw new Exception("Exception occurred after 5 iterations.");
		}
	}
}
catch (Exception ex)
{

	Console.WriteLine("Exception caught: " + ex.Message);
}
```