// See https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement for more

// Dummy Data
List<string> data = new List<string>();
data.Add("Kyle");
data.Add("Tom");
data.Add("Dan");
data.Add("Albert");
data.Add("Fred");

// Simple for loop
for (int i = 0; i < data.Count; i++)
{
    Console.WriteLine(data[i]);
}

// Dummy Data 2
List<decimal> data2 = new();
data2.Add(22.71M);
data2.Add(1.59M);
data2.Add(67.53M);
data2.Add(42.87M);
data2.Add(3.37M);

decimal total = 0;

// Math with for loops
for (int i = 0; i < data2.Count;i++)
{
    total += data2[i];
}

Console.WriteLine($"Total Cost: ${total}");