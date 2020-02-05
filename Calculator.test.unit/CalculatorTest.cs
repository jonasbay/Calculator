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
        // Add
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

        // Add på en lettere måde
        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(uut.Add(a,b), Is.EqualTo(result));
        }

        // Test add overloading
        [TestCase(3, 10)]
        [TestCase(-3, 4)]
        [TestCase(0, 7)]
        public void Add_AddTogetherWithAccumulator_ResultIsCorrect(int a, int result)
        {
            uut.Add(5,2);
            Assert.That(uut.Add(a), Is.EqualTo(result));
        }

        // Subtract
        [Test]
        public void SubtractTwoNumbers_OneItem_Return0()
        {
            // Add & Assert
            Assert.That(uut.Subtract(2, 2), Is.EqualTo(0));
        }

        // Test subtract overloading
        [TestCase(3, 7)]
        [TestCase(-3, 13)]
        [TestCase(0, 10)]
        public void Subtract_SubtractWithAccumulator(int a, int result)
        {
            uut.subtract(12, 2); //Accumulator is 10
            Assert.That(uut.subtrackt(a), Is.EqualTo(result));
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

        // Pow overloading test
        [TestCase(2, 16)]
        [TestCase(-2, 0.025)]
        [TestCase(0,1)]
        public void Pow_Overloading_ResultIsTrue(double exp, double result)
        {
            uut.Power(2, 2);
            // Add & Assert
            Assert.That(uut.Power(exp), Is.EqualTo(result).Within(0.05));
        }

        // Divided
        [TestCase(4, 2, 2)]
        [TestCase(-10, -2, 5)]
        [TestCase(-3, 2, -1.5)]
        [TestCase(3, -2, -1.5)]
        public void Divide_TwoNumbers_ResultTrue(double a, double b, double result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }

        [Test]
        public void TestDivideWithZero_ThrowException()
        {
            Assert.Throws<DivideException>(() => uut.Divide(5, 0));
        }

        // Test Accumulator
        [TestCase(5,2,7)]
        [TestCase(-2,19,17)]
        public void AccumulatorTest_returnTrueResult(int a, int b, int result)
        {
            uut.Add(a, b);
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        // Clear
        [Test]
        public void ClearAccumulator()
        {
            uut.clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }
    }
}