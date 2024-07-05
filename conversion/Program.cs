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

        Console.WriteLine("Result: {0:F8}", resultFloat);
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
