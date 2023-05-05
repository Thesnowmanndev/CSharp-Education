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