using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PalindromeNameSpace;

namespace Tests
{
    [TestClass()]
    public class PalindromeUnitTest
    {
        [TestMethod]
        public void UnitTest1()
        {
            //Test the method "Palindrome.Ispalindrome()".

            //Unit test case 1.1
            //Not a palindrome partition
            string input1 = "abc";
            int startIndex1 = 0;
            int endIndex1 = 2;
            Assert.IsFalse(Palindrome.IsPalindrome(input1, startIndex1, endIndex1));

            //Unit test case 1.2
            //A palindrome partition of length 1
            string input2 = "abc";
            int startIndex2 = 0;
            int endIndex2 = 0;
            Assert.IsTrue(Palindrome.IsPalindrome(input2, startIndex2, endIndex2));

            //Unit test case 1.3
            //A palindrome partition of length 2
            string input3 = "aab";
            int startIndex3 = 0;
            int endIndex3 = 1;
            Assert.IsTrue(Palindrome.IsPalindrome(input3, startIndex3, endIndex3));

            //Unit test case 1.4
            //A palindrome partition of length 3
            string input4 = "aba";
            int startIndex4 = 0;
            int endIndex4 = 2;
            Assert.IsTrue(Palindrome.IsPalindrome(input4, startIndex4, endIndex4));
        }

        [TestMethod()]
        public void UnitTest2()
        {
            //Test the method "Palindrome.GetAllPalindromePartitions()"

            //Unit test case 2.1
            //There are no palindrome partitions with a length greater than 1.
            string input1 = "abc";
            List<List<string>> expected1 = new List<List<string>>();
            expected1.Add(new List<string>(new[] { "a", "b", "c" }));
            List<List<string>> actual1 =
                Palindrome.GetAllPalindromePartitions(input1);

            Assert.AreEqual(expected1.Count, actual1.Count);
            for (int i = 0; i < expected1.Count; i++)
            {
                CollectionAssert.AreEqual(expected1[i], actual1[i]);
            }

            //Unit test case 2.2
            //There is a palindrome partition of length 2.  
            string input2 = "aabc";
            List<List<string>> expected2 = new List<List<string>>();
            expected2.Add(new List<string>(new[] { "a", "a", "b", "c" }));
            expected2.Add(new List<string>(new[] { "aa", "b", "c" }));
            List<List<string>> actual2 =
                Palindrome.GetAllPalindromePartitions(input2);

            Assert.AreEqual(expected2.Count, actual2.Count);
            for (int i = 0; i < expected2.Count; i++)
            {
                CollectionAssert.AreEqual(expected2[i], actual2[i]);
            }

            //Unit test case 2.3
            //There is a palindrome partition of length 3.
            string input3 = "abcbd";
            List<List<string>> expected3 = new List<List<string>>();
            expected3.Add(new List<string>(new[] { "a", "b", "c", "b", "d" }));
            expected3.Add(new List<string>(new[] { "a", "bcb", "d" }));
            List<List<string>> actual3 =
                Palindrome.GetAllPalindromePartitions(input3);

            Assert.AreEqual(expected3.Count, actual3.Count);
            for (int i = 0; i < expected3.Count; i++)
            {
                CollectionAssert.AreEqual(expected3[i], actual3[i]);
            }
        }
    }
}
