using Microsoft.VisualStudio.TestTools.UnitTesting;
using Substring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Substring.Tests
{
    [TestClass()]
    public class substringTests
    {
        [TestMethod()]
        public void FinalResult()
        {
            substring obj=new substring();
            string Mainstring = "abcdefabcdefabcdef";
            string Substring = "abcdef";
            string expectedresult = "0 6 12 ";
            string actualresult = obj.StringOccurance(Mainstring, Substring);
            Assert.AreEqual(expectedresult,actualresult);
        }
    }
}