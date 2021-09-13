using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LabNet2021.Library;

namespace LabNet2021.Test
{
    [TestClass]
    public class TestLogic
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void IntegerExtensions_DivideByZero_ThrowException()
        {
            //Arrange
            int number = 22;

            //Act   
            number.DivideForZero();

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Logic_DivisionOfTwoNumber_ThrowException()
        {
            //Arrange
            int num1 = 7;
            int num2 = 0;

            //Act 
            Logic.DivisionOfTwoNumber(num1, num2);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        public void Logic_DivisionOfTwoNumber_ResultOfTheDivision()
        {
            //Arrange
            int num1 = 7;
            int num2 = 2;
            float result;

            //Act 
            result = Logic.DivisionOfTwoNumber(num1, num2);

            //Assert
            Assert.AreEqual(3.5, result);
        }

        [TestMethod]
        public void Logic_ValidationInteger_OneIntNumber()
        {
            //Arrange
            string number = "25";
            int result;

            //Act 
            result = Logic.ValidationInteger(number);

            //Assert
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputException))]
        public void Logic_ValidationInteger_ThrowException()
        {
            //Arrange 
            string number = "Treinta";

            //Act 
            Logic.ValidationInteger(number);

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(SmokeBombException))]
        public void Logic_SmokeBomb_ThrowException()
        {
            //Arrange no objects or attributes required

            //Act 
            Logic.SmokeBomb();

            //Assert is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(FieldAccessException))]
        public void Logic_FielAccess_ThrowException()
        {
            //Arrange no objects or attributes required

            //Act 
            Logic.FieldAccess();

            //Assert is handled by the ExpectedException
        }
    }
}
