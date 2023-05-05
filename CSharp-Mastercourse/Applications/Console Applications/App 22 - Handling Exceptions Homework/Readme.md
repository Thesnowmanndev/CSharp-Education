# Handling Exceptions Homework

Instructions: Create a console application with a for loop that throws an exception after five iterations. Catch the exception.

## Application Preview

To see the code source click here: Program.cs

!example

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