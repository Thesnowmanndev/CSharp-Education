public class Validators
{
    public static bool ValidateInputIsNumber(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false; 
        }

        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        return true;
    }
}