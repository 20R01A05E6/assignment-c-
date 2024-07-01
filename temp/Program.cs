// Assignment :
// 1st

class substring
{
    public static void Main(string[] args)
    {
        //int a = Convert.ToInt32(Console.ReadLine());
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        string s3 = "";
        int count = 0;
        for (int i = 0; i <= s1.Length - s2.Length; i++)
        {
            if (s1.Substring(i, s2.Length) == s2)
            {
                count++;
                s3 += i;
            }
        }
        Console.WriteLine("Times of Occurences : " + count);
        Console.WriteLine("Indexes : " + s3);

    }
}



//-----------------------------------------------------------

// 2nd

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


//----------------------------------------------------------

// 3rd






class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first float number (n): ");
        float n = float.Parse(Console.ReadLine());
        Console.Write("Enter the second float number (m): ");
        float m = float.Parse(Console.ReadLine());

        string nBinary = FloatToBinary(n);
        string mBinary = FloatToBinary(m);

        float resultFloat = n + m;

        Console.WriteLine("Result: {0:F5}", resultFloat);
    }

    public static string FloatToBinary(float num)
    {
        byte[] bytes = BitConverter.GetBytes(num);
        Array.Reverse(bytes);
        string binary = "";
        foreach (byte b in bytes)
        {
            binary += Convert.ToString(b, 2).PadLeft(8, '0');
        }
        return binary;
    }

    public static float BinaryToFloat(string binary)
    {
        byte[] bytes = new byte[4];
        for (int i = 0; i < 4; i++)
        {
            bytes[i] = Convert.ToByte(binary.Substring(i * 8, 8), 2);
        }
        Array.Reverse(bytes);
        return BitConverter.ToSingle(bytes, 0);
    }
}