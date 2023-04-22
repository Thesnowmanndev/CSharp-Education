namespace StaticClassesHomework
{
    public static class GenerateMessages
    {
        public static void PrintItems(List<decimal> input)
        {
            Console.Clear();
            Console.WriteLine("Items in List:");
            int i = 1;
            foreach (decimal item in input)
            {
                Console.WriteLine($"{i}. Item Price: ${item}.");
                i++;
            }
        }

        public static string PrintTotal(List<decimal> input)
        {
            decimal total = CalculateData.Add(input);
            string totalValueMessage = $"\nThe total cost is ${total}.";

            return totalValueMessage;
        }

        public static string PrintNewAccountBalance(decimal accountBalance, decimal totalCost)
        {
            decimal output = 0M;
            output = CalculateData.SubtractFromBalance(accountBalance, totalCost);
            string outputText = $"\nYour new account balance is ${output}. (${accountBalance} - ${totalCost}).";

            return outputText;
        }
    }
}
