using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation;

namespace Substring
{
    public class SubstringMain
    {
        public static void Main(string[] args)
        {
            string s1 = "";
            string s2 = "";
            bool validInputs =false;
            while (!validInputs)
            {
                Console.Write("Enter Main String : ");
                s1 = Console.ReadLine();

                Console.Write("Enter substring to find in the Main string : ");
                s2 = Console.ReadLine();

                Validation.Testing obj = new Validation.Testing();
                if (obj.validate(s1, s2) == true)
                {
                    validInputs=true;
                }
                else
                {
                    validInputs = false;
                }
            }

            substring classinstance = new substring();
            string result = classinstance.StringOccurance(s1, s2);
            
            
            if (result == "")
            {
                Console.WriteLine("There are no indexes matching");
            }
            else
            {
                Console.WriteLine($"Substring found at [ {result}] Indexes");
            }

        }
    }
}
