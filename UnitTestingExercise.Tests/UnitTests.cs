using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator = new Calculator();


            //Act
            // and store its result in a variable named actual
            // call the Add method that is located in the Calculator class
            var actual = calculator.Add(num1, num2, num3);


            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 1, 4)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var actual = calculator.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,3,15)]//Add test data <-------
        [InlineData(2,0,0)]
        [InlineData(5,-5,-25)]
        [InlineData(-5,-5,25)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var actual = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        //[InlineData(5,0)]//Add test data <-------
        [InlineData(10, 2, 5)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected,actual);
        }


        [Theory]
        [InlineData(5,0)]//Add test data <-------
        public void DivideByZeroTest(int num1, int num2)
        {
            //Arrange
            Calculator calculator = new Calculator();
            
            //Act/Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(num1, num2));
        }
    }
}
