using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new UnitTestMethods();



            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]//Add test data <-------
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test1 = new UnitTestMethods();
            //Act
            var actual = test1.Subtract(minuend, subtrhend);
            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,5,15)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            var test2 = new UnitTestMethods();
            //Arrange
            var actual = test2.MultiplyTest(num1, num2);
            //Act
            Assert.Equal(expected, actual);
            //Assert

        }

        [Theory]
        [InlineData(8,2,4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test3 = new UnitTestMethods();
            var actual = test3.DivideTest(num1, num2);
            Assert.Equal(expected, actual);
            //Act

            //Assert

        }

    }
}
