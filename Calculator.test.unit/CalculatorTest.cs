using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.test.unit
{ 
    [TestFixture]
    public class CalculatorTest
    {
        private CalculatorInt uut;

        // Arrange
        [SetUp]
        public void setup()
        {
            uut = new CalculatorInt();
        }

        // Add - testman
        [Test]
        public void addTwoNumbers_OneItem_Return4()
        {
            // Add & Assert
            Assert.That(uut.Add(2,2), Is.EqualTo(4));
        }

        [Test]
        public void addTwoNumbers_OneItem_Return0()
        {
            // Add & Assert
            Assert.That(uut.Add(-2, 2), Is.EqualTo(0));
        }

        [Test]
        public void addTwoNumbers_OneItem_ReturnMinus4()
        {
            // Add & Assert
            Assert.That(uut.Add(-2, -2), Is.EqualTo(-4));
        }

        // Subtract
        [Test]
        public void SubtractTwoNumbers_OneItem_Return0()
        {
            // Add & Assert
            Assert.That(uut.Subtract(2, 2), Is.EqualTo(0));
        }

        [Test]
        public void SubtractTwoNumbers_OneItem_Return6()
        {
            // Add & Assert
            Assert.That(uut.Subtract(4, -2), Is.EqualTo(6));
        }

        [Test]
        public void SubtractTwoNumbers_BothMinus_Return6()
        {
            // Add & Assert
            Assert.That(uut.Subtract(-4, -2), Is.EqualTo(-2));
        }

        // Multiply
        [Test]
        public void MultiplyTwoNumbers_BothPlus_Return16()
        {
            // Add & Assert
            Assert.That(uut.Multiply(4, 4), Is.EqualTo(16));
        }

        [Test]
        public void MultiplyTwoNumbers_OneMinus_ReturnMinus16()
        {
            // Add & Assert
            Assert.That(uut.Multiply(4, -4), Is.EqualTo(-16));
        }

        [Test]
        public void MultiplyTwoNumbers_BothMinus_Return16()
        {
            // Add & Assert
            Assert.That(uut.Multiply(-4, -4), Is.EqualTo(16));
        }

        // Pow
        [Test]
        public void PowerTwoNumbers_BothPlus_Return4()
        {
            // Add & Assert
            Assert.That(uut.Power(2, 2), Is.EqualTo(4));
        }

        [Test]
        public void PowerTwoNumbers_OnePlus_Return4()
        {
            // Add & Assert
            Assert.That(uut.Power(-2, 2), Is.EqualTo(4));
        }

        [Test]
        public void PowerTwoNumbers_BothMinus_Return()
        {
            // Add & Assert
            Assert.That(uut.Power(-2, -2), Is.EqualTo(0.25));
        }

    }
}
