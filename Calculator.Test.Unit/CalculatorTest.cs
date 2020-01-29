using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator = CalculatorExercise.Calculator;

namespace Calculator.Test.Unit
{
  [TestFixture]
    public class CalculatorTest
    {
        private CalculatorExercise.Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new CalculatorExercise.Calculator();
        }
        [Test]
        public void AddPositiveWithNegative()
        {
            //Arrange
            var uut = new CalculatorExercise.Calculator();

            //Act + Assert
            Assert.That(uut.Add(3, -5), Is.EqualTo(-2));
        }

        [Test]
        public void MultiplyTest()
        {
            var uut = new CalculatorExercise.Calculator();

            Assert.That(uut.Multiply(5, 4), Is.EqualTo(20));
        }

        [Test]
        public void SubtractTest()
        {
            Assert.That(uut.Subtract(10,7), Is.EqualTo(3));
        }
    }
}
    