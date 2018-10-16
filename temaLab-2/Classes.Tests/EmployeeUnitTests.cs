using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;

namespace Classes.Tests {
    [TestClass]
    public class EmployeeUnitTests {

        private Employee sut;

        [TestInitialize]
        public void TestInitialize() {
            sut = new Manager(1, "Veorica", "Dancila", new DateTime(), new DateTime(), 100);
        }

        [TestCleanup]
        public void TestCleanup() {
            sut = null;
        }

        [TestMethod]
        public void Given_FirstNameAndLastNameForManager_When_GetFullNameIsCalled_Then_ShouldReturnManagerFullName() {
            
            //Arrange
            String expectedResult = "Veorica Dancila";

            //Act
            String actualResult = sut.GetFullName();

            //Assert
            actualResult.Should().Be(expectedResult);
        }

        [TestMethod]
        public void Given_TodayIsBetweenStartDateAndEndDate_When_IsActiveIsCalled_Then_ShouldReturnTrue() {

            //Arrange
            sut.SetStartDate(DateTime.Parse("1/1/2010"));
            sut.SetEndDate(DateTime.Parse("1/1/2020"));

            //Act
            bool isActive = sut.IsActive();

            //Assert
            Assert.IsTrue(isActive);
        }

        [TestMethod]
        public void Given_TodayIsAfterEndDate_When_IsActiveIsCalled_Then_ShouldReturnFalse() {

            //Arrange
            sut.SetStartDate(DateTime.Parse("1/1/2010"));
            sut.SetEndDate(DateTime.Parse("1/1/2015"));

            //Act
            bool isActive = sut.IsActive();

            //Assert
            Assert.IsFalse(isActive);
        }

        [TestMethod]
        public void Given_TodayIsBeforeStartDate_When_IsActiveIsCalled_Then_ShouldReturnFalse()
        {

            //Arrange
            sut.SetStartDate(DateTime.Parse("1/1/2020"));
            sut.SetEndDate(DateTime.Parse("1/1/2025"));

            //Act
            bool isActive = sut.IsActive();

            //Assert
            Assert.IsFalse(isActive);
        }

        [TestMethod]
        public void Given_SalutationManager_When_SalutationIsCalled_Then_ShouldReturnHelloManager()
        {

            //Arrange && Act && Assert
            sut.Salutation().Should().Be("Hello Manager");
        }

        //[TestMethod]
        // public void Given_Get_When_GetIdIsCalled_Then_ShouldReturnId()
        // {

        //     //Arrange && Act && Assert
        //     sut.Id.Should().Be(1);
        // }

        // [TestMethod]
        // public void Given_Salary_When_GetSalaryIsCalled_Then_ShouldReturnSalary()
        // {

        //     //Arrange && Act && Assert
        //     sut.Salary.Should().Be(100);
        // }

        [TestMethod]
        public void Given_FirstNameAndLastNameForArchitect_When_GetFullNameIsCalled_Then_ShouldReturnArchitectFullName()
        {
            //Arrange && Act && Assert
            new Architect(1, "Veorica", "Dancila", new DateTime(), new DateTime(), 100).GetFullName().Should().Be("Veorica Dancila");
        }

        [TestMethod]
        public void Given_SalutationArchitect_When_SalutationIsCalled_Then_ShouldReturnHelloArchitect()
        {
            //Arrange && Act && Assert
            new Architect(1, "Veorica", "Dancila", new DateTime(), new DateTime(), 100).Salutation().Should().Be("Hello Architect");
        }
    }
}