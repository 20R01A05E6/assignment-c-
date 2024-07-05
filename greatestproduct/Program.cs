class temp
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Digits : ");
        string inputString = Console.ReadLine();
        if (inputString == "")
        {
            throw new Exception("Input Should not be Empty");
        }
        int maxProduct = 0;
        string digits = "";
        for (int i = 0; i <= inputString.Length - 4; i++)
        {
            string substring = inputString.Substring(i, 4);
            
            int product = calculate(substring); //Converting Characters into Integers

            if (product > maxProduct)
            {
                maxProduct = product;
                digits = substring;
            }
        }
        Console.WriteLine("");
        Console.WriteLine($"{digits.Substring(0, 1)}*" +
                          $"{digits.Substring(1, 1)}*" +
                          $"{digits.Substring(2, 1)}*" +
                          $"{digits.Substring(3, 1)} = " + maxProduct);
    }

    public static int calculate(string inputString)
    {
        int product = 1;
        foreach (char character in inputString)
        {
            //int digit = c - '0';
            //product*=digit;
            product *= (int)Char.GetNumericValue(character);

        }
        return product;
    }
}