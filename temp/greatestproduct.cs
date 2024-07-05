class greatestproduct
{
    public static void Main(string[] args)
    {
        string s1 = Console.ReadLine();
        int max = 0;
        string digits = "";
        for (int i = 0; i <= s1.Length - 4; i++)
        {
            string substring = s1.Substring(i, 4);
            int product = calculate(substring);
            if (product > max)
            {
                max = product;
                digits = substring;
            }
        }
        Console.WriteLine($"{digits.Substring(0, 1)}*{digits.Substring(1, 1)}*{digits.Substring(2, 1)}*{digits.Substring(3, 1)} = " + max);
    }

    public static int calculate(string str)
    {
        int product = 1;
        foreach (char c in str)
        {
            //int digit = c - '0';
            //product*=digit;
            product *= (int)Char.GetNumericValue(c);

        }
        return product;
    }
}
