using MyCalc;
using NUnit.Framework;

namespace CalcTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Tests for CalcPower
        [Test]
        public void GetPowerByResistensAndCurrentTest()
        {
            // Arrange - Go get your variables, classes, functions, whatever you need
            var temp = new CalcPower();

            // Act - Execute this function
            var result = temp.GetPowerByResistanceAndCurrent(100, 500); // Example values

            // Assert - Whatever is returned is what you want
            Assert.AreEqual(25000000, result);

        }

        [Test]
        public void GetPowerByVoltageAndCurrentTest()
        {
            // Arrange
            var temp = new CalcPower();

            // Act
            var result = temp.GetPowerByVoltageAndCurrent(10, 2); 

            // Assert
            Assert.AreEqual(20, result);
        }

        [Test]
        public void GetPowerByVoltageAndResistanceTest()
        {
            // Arrange
            var temp = new CalcPower();

            // Act
            var result = temp.GetPowerByVoltageAndResistance(5, 25); 

            // Assert
            Assert.AreEqual(1, result);
        }

        // Tests for CalcVoltage
        [Test]
        public void GetVoltageByResistanceAndCurrentTest()
        {
            // Arrange
            var voltageCalculator = new CalcVoltage();

            // Act
            var result = voltageCalculator.GetVoltageByResistanceAndCurrent(100, 5);

            // Assert
            Assert.AreEqual(500, result);
        }

        [Test]
        public void GetVoltageByPowerAndCurrentTest()
        {
            // Arrange
            var voltageCalculator = new CalcVoltage();

            // Act
            var result = voltageCalculator.GetVoltageByPowerAndCurrent(1000, 10);

            // Assert
            Assert.AreEqual(100, result);
        }

        [Test]
        public void GetVoltageByPowerAndResistanceTest()
        {
            // Arrange
            var voltageCalculator = new CalcVoltage();

            // Act
            var result = voltageCalculator.GetVoltageByPowerAndResistance(400, 4);

            // Assert
            Assert.AreEqual(40, result);
        }

        // Tests for CalcCurrent
        [Test]
        public void GetCurrentByPowerAndResistanceTest()
        {
            // Arrange
            var currentCalculator = new CalcCurrent();

            // Act
            var result = currentCalculator.GetCurrentByPowerAndResistance(100, 25);

            // Assert
            Assert.AreEqual(2, result); 
        }

        [Test]
        public void GetVoltageByPowerAndVoltageTest()
        {
            // Arrange
            var currentCalculator = new CalcCurrent();

            // Act
            var result = currentCalculator.GetVoltageByPowerAndVoltage(400, 200);

            // Assert
            Assert.AreEqual(2, result); 
        }

        [Test]
        public void GetCurrentByVoltageAndResistanceTest()
        {
            // Arrange
            var currentCalculator = new CalcCurrent();

            // Act
            var result = currentCalculator.GetCurrentByVoltageAndResistance(220, 110);

            // Assert
            Assert.AreEqual(2, result); 
        }

        // Tests for CalcResistance
        [Test]
        public void GetResistanceByVoltageAndCurrentTest()
        {
            // Arrange
            var resistanceCalculator = new CalcResistance();

            // Act
            var result = resistanceCalculator.GetResistanceByVoltageAndCurrent(220, 10);

            // Assert
            Assert.AreEqual(22, result); 
        }

        [Test]
        public void GetResistanceByVoltageAndPowerTest()
        {
            // Arrange
            var resistanceCalculator = new CalcResistance();

            // Act
            var result = resistanceCalculator.GetResistanceByVoltageAndPower(110, 2200);

            // Assert
            Assert.AreEqual(5.5, result);
        }

        [Test]
        public void GetResistanceByPowerAndCurrentTest()
        {
            // Arrange
            var resistanceCalculator = new CalcResistance();

            // Act
            var result = resistanceCalculator.GetResistanceByPowerAndCurrent(400, 16);

            // Assert
            Assert.AreEqual(1.5625, result); 
        }
    }
}
