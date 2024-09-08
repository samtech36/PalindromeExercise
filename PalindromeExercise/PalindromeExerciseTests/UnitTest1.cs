using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
            [Theory]
            [InlineData("racecar", true)]
            [InlineData("RAce Car", true)]
            [InlineData("Coding", false)]
            [InlineData("I am playing sports", false)]
            [InlineData("I am eating food", false)]

            public void Test1(string actualword, bool expected)
            {
                //Arrange
                var WordSmith = new WordSmith();
                
                //Act
                var actual = WordSmith.IsAPalindrome(actualword);
                
                //Assert
                Assert.Equal(expected, actual);
            }
            
    }
}
