using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;

namespace Classes.Tests {
    [TestClass]
    public class ProductUnitTests {
        [TestMethod]
        public void Given_TodayIsBetweenStartDateAndEndDate_When_IsValidIsCalled_Then_ShouldReturnTrue() {

            //Arrange
            Product product = new Product(1, "Paine", "Se mananca", DateTime.Parse("1/1/2009"), DateTime.Parse("1/1/2020"), 100, 20);

            //Act
            bool isValid = product.IsValid();

            //Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void Given_TodayIsAfterEndDate_When_IsValidIsCalled_Then_ShouldReturnFalse() {

            //Arrange
            Product product = new Product(1, "Paine", "Se mananca", DateTime.Parse("1/1/2009"), DateTime.Parse("1/1/2015"), 100, 20);

            //Act
            bool isValid = product.IsValid();

            //Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void Given_TodayIsBeforeStartDate_When_IsValidIsCalled_Then_ShouldReturnFalse()
        {

            //Arrange
            Product product = new Product(1, "Paine", "Se mananca", DateTime.Parse("1/1/2020"), DateTime.Parse("1/1/2025"), 100, 20);

            //Act
            bool isValid = product.IsValid();

            //Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void Given_PriceAndVatAreCorrect_When_ComputeVatIsCalled_Then_ShouldReturnExpectedResult() {
            //Arrange
            Product product = new Product(1, "Paine", "Se mananca", DateTime.Parse("1/1/2009"), DateTime.Parse("1/1/2015"), 100, 20);
            int expectedResult = 120;

            //Act
            int actualResult = product.ComputeVAT();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Given_VatIsWrong_When_ComputeVatIsCalled_Then_ShouldThrowArgumentException() {
            //Arrange
            Product product = new Product(1, "Paine", "Se mananca", DateTime.Parse("1/1/2009"), DateTime.Parse("1/1/2015"), 100, -30);

            //Act
            Action action = () => product.ComputeVAT();

            //Assert
            action.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        public void Given_PriceIsWrong_When_ComputeVatIsCalled_Then_ShouldThrowArgumentException()
        {
            //Arrange
            Product product = new Product(1, "Paine", "Se mananca", DateTime.Parse("1/1/2009"), DateTime.Parse("1/1/2015"), -100, 30);

            //Act
            Action action = () => product.ComputeVAT();

            //Assert
            action.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        public void Given_PriceAndVatAreWrong_When_ComputeVatIsCalled_Then_ShouldThrowArgumentException()
        {
            //Arrange
            Product product = new Product(1, "Paine", "Se mananca", DateTime.Parse("1/1/2009"), DateTime.Parse("1/1/2015"), -100, -30);

            //Act
            Action action = () => product.ComputeVAT();

            //Assert
            action.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        public void Given_GettingProductName_When_GetNameIsCalled_Then_NameShouldBeCorrect() {
            // Arrange
            Product product = new Product(1, "Pizza", "ala", new DateTime(), new DateTime(), 100, 20);
            String testName = "Pizza";
            // Act && Assert
            product.Name.Should().Be(testName);
        }
    }
}
