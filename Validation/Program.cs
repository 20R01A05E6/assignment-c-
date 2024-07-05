using System.Text.RegularExpressions;

namespace Validation
{
    public class Testing()
    {
        public bool validate(string s1, string s2)
        {

            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            try
            {
                if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
                {
                    throw new Exception("Inputs should not be empty.");
                }

                if (regexItem.IsMatch(s1) || regexItem.IsMatch(s2))
                {
                    throw new FormatException("Inputs should not contain digits.");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}. Please enter valid string inputs.");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;

            }

            return true;
        }

/*
        try
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
            {
                throw new Exception("Inputs should not be empty.");
            }

            if (ContainsDigits(s1) || ContainsDigits(s2))
            {
                throw new FormatException("Inputs should not contain digits.");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Please enter valid string inputs.");
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return false;

        }
        return true;
        }
        private static bool ContainsDigits(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }*/

        static void Main(string[] args)
        {
        }
    }
}