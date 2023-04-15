// See https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement

// Dummy Data
string data = "Kyle,Tom,Frank,Bob,Jan";
List<string> firstNames = data.Split(',').ToList();

// For Each
foreach (string name in firstNames)
{
    Console.WriteLine(name);
}