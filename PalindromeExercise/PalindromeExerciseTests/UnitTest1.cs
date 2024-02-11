using PalindromeExercise;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("race car", true)]
        [InlineData("Able was I ere I saw Elba", true)]
        [InlineData("A man a plan a canal Panama", true)]
        [InlineData("Evil is a name of a foeman as I live", true)]
        [InlineData("Hello",  false)]



        public void Test1(string palindrome, bool expected)
        {
            WordSmith instance = new WordSmith();
            bool actual = instance.UsePalindrome(palindrome);
            Assert.Equal(expected, actual);
            
        }
    }
}
