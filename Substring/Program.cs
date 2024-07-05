namespace Substring
{
    public class substring
    {
        public string StringOccurance(string MainString, string substring)
        {
            string result = "";

            int count = 0;
            
            for (int index = 0; index <= MainString.Length - substring.Length; index++)
            {
                if (MainString.Substring(index, substring.Length) == substring)
                {
                    count++;
                    result += (index + " ");
                }
            }
            
            Console.WriteLine("Times of Occurences : " + count);
            
            return result;
        }
    }
}